using AlarmAppV2.UserController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlarmAppV2
{
    public partial class Form1 : Form
    {
        bool drag = false;
        bool alarmRinging;
        Point startPoint = new Point(0, 0);
        AlarmTimeController alarmTimeController;
   
        public Form1()
        {            
            alarmTimeController = new AlarmTimeController();
            alarmTimeController.onUpdateAlarmList += UpdateAndDisplayAlarmInfoPanel;
            InitializeComponent();            
            SetFirstForm();
        }
        // TODO: check per min not sec for timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTimeLbl.Text = DateTime.Now.ToLongTimeString();
            currentDateLbl.Text = DateTime.Now.ToLongDateString();

            alarmRinging = alarmTimeController.UpdateTimer();

            if (alarmRinging)
            {
                IconShow();
                MessageBox.Show(DateTime.Now.ToShortTimeString(), "Ring Ring Ring ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void SetAlarmBtn_Click(object sender, EventArgs e)
        {
            bool alarmCreated = false;
            if (hourComboBox.Text.ToString() != "" && minComboBox.Text.ToString() != "" && amPmComboBox.Text.ToString() != "")
            {                
                alarmCreated = alarmTimeController.SetAlarm(hourComboBox.Text, minComboBox.Text, amPmComboBox.Text,
                    dateTimePicker.Text, dateTimePicker.Value.Date.ToShortDateString());                
                alarmSoundLbl.Text = alarmTimeController.audioPath.Split("\\").Last().ToString();

                if (!alarmCreated)
                {
                    MessageBox.Show("Alarm propteries are cannot be the same");
                }
            }
            else
            {
                MessageBox.Show("hour and min box cannot be null ");
            }
        }

        private void UpdateAndDisplayAlarmInfoPanel(List<AlarmTime> _alarmTimeList)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (AlarmTime currentAlarmTime in _alarmTimeList)
            {
                AlarmControl tempAlarmControl = new AlarmControl();
                tempAlarmControl.SetAlarmInfoLabel(currentAlarmTime.alarmInfoString);
                tempAlarmControl.SetActiveCheckBox(currentAlarmTime.Active);
                flowLayoutPanel1.Controls.Add(tempAlarmControl);
            }
        }

        private void SetSoundBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files (*.wav)|*.wav";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                alarmTimeController.SetAudioPath(openFileDialog.FileName);
                alarmSoundLbl.Text = alarmTimeController.audioPath.Split("\\").Last().ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            alarmTimeController.ClearAlarmList();
        }

        void SetFirstForm()
        {
            alarmSoundLbl.Text = alarmTimeController.audioPath.Split("\\").Last().ToString();
            hourComboBox.Text = DateTime.Now.Hour.ToString();
            minComboBox.Text = DateTime.Now.ToString().Split(":")[1].Split(" ")[0];
            amPmComboBox.Text = DateTime.Now.ToString("tt", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            IconHidden();
        }
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) IconShow();
            else IconHidden();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void IconHidden()
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon.Visible = true;
            ShowInTaskbar = false;
        }
        void IconShow()
        {
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
            ShowInTaskbar = true;
        }
        private void headerBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void headerBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point newPoint = PointToScreen(e.Location);
                this.Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }
        private void headerBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void changeDefaultSound_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media Files (*.wav)|*.wav";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                alarmTimeController.SetDefaultAudioPath(openFileDialog.FileName);
                alarmSoundLbl.Text = alarmTimeController.GetDefaultAudioPath().Split("\\").Last().ToString();
            }
        }
    }
}
