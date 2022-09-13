using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlarmAppV2.UserController
{
    public delegate void OnCheckBoxInteracted(string infoString, bool active);
    public delegate void OnDeleteButton(string infoString);    
    public partial class AlarmControl : UserControl
    {
        public static event OnCheckBoxInteracted OnCheckBoxInteracted;
        public static event OnDeleteButton OnDeleteButton;
        public AlarmControl()
        {
            InitializeComponent();
        }
        
        public void SetAlarmInfoLabel(string info)
        {
            alarmInfoLbl.Text = info;
        }
        public void SetActiveCheckBox(bool active)
        {
            alarmActiveCBox.Checked = active;
        }

        private void alarmActiveCBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OnCheckBoxInteracted != null)
            {
                OnCheckBoxInteracted?.Invoke(alarmInfoLbl.Text, alarmActiveCBox.Checked);
            }            
        }
        
        private void alarmDeleteBtn_Click(object sender, EventArgs e)
        {
            if (OnDeleteButton != null)
            {
                OnDeleteButton?.Invoke(alarmInfoLbl.Text);
            }
        }
    }
}
