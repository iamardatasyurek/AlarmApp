
namespace AlarmAppV2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.currentTimeLbl = new System.Windows.Forms.Label();
            this.hourComboBox = new System.Windows.Forms.ComboBox();
            this.minComboBox = new System.Windows.Forms.ComboBox();
            this.amPmComboBox = new System.Windows.Forms.ComboBox();
            this.SetAlarmBtn = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SetSoundBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.alarmSoundLbl = new System.Windows.Forms.Label();
            this.headerBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formTitleLbl = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearBtn = new System.Windows.Forms.Button();
            this.currentDateLbl = new System.Windows.Forms.Label();
            this.hourLbl = new System.Windows.Forms.Label();
            this.minuteLbl = new System.Windows.Forms.Label();
            this.ampmLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeDefaultSound = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.headerBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // currentTimeLbl
            // 
            this.currentTimeLbl.AutoSize = true;
            this.currentTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.currentTimeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.currentTimeLbl.Location = new System.Drawing.Point(0, 64);
            this.currentTimeLbl.Name = "currentTimeLbl";
            this.currentTimeLbl.Size = new System.Drawing.Size(397, 73);
            this.currentTimeLbl.TabIndex = 0;
            this.currentTimeLbl.Text = "10:10:10 PM";
            // 
            // hourComboBox
            // 
            this.hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hourComboBox.FormattingEnabled = true;
            this.hourComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hourComboBox.Location = new System.Drawing.Point(24, 46);
            this.hourComboBox.Name = "hourComboBox";
            this.hourComboBox.Size = new System.Drawing.Size(81, 23);
            this.hourComboBox.TabIndex = 3;
            // 
            // minComboBox
            // 
            this.minComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minComboBox.FormattingEnabled = true;
            this.minComboBox.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.minComboBox.Location = new System.Drawing.Point(115, 46);
            this.minComboBox.Name = "minComboBox";
            this.minComboBox.Size = new System.Drawing.Size(81, 23);
            this.minComboBox.TabIndex = 4;
            // 
            // amPmComboBox
            // 
            this.amPmComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amPmComboBox.FormattingEnabled = true;
            this.amPmComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.amPmComboBox.Location = new System.Drawing.Point(208, 46);
            this.amPmComboBox.Name = "amPmComboBox";
            this.amPmComboBox.Size = new System.Drawing.Size(81, 23);
            this.amPmComboBox.TabIndex = 5;
            // 
            // SetAlarmBtn
            // 
            this.SetAlarmBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.SetAlarmBtn.FlatAppearance.BorderSize = 0;
            this.SetAlarmBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
            this.SetAlarmBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(126)))));
            this.SetAlarmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetAlarmBtn.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SetAlarmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SetAlarmBtn.Location = new System.Drawing.Point(194, 144);
            this.SetAlarmBtn.Name = "SetAlarmBtn";
            this.SetAlarmBtn.Size = new System.Drawing.Size(95, 29);
            this.SetAlarmBtn.TabIndex = 6;
            this.SetAlarmBtn.Text = "Set Alarm";
            this.SetAlarmBtn.UseVisualStyleBackColor = false;
            this.SetAlarmBtn.Click += new System.EventHandler(this.SetAlarmBtn_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(24, 77);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 243);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(784, 285);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // SetSoundBtn
            // 
            this.SetSoundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.SetSoundBtn.FlatAppearance.BorderSize = 0;
            this.SetSoundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetSoundBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SetSoundBtn.Location = new System.Drawing.Point(24, 106);
            this.SetSoundBtn.Name = "SetSoundBtn";
            this.SetSoundBtn.Size = new System.Drawing.Size(51, 26);
            this.SetSoundBtn.TabIndex = 9;
            this.SetSoundBtn.Text = "Sound";
            this.SetSoundBtn.UseVisualStyleBackColor = false;
            this.SetSoundBtn.Click += new System.EventHandler(this.SetSoundBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // alarmSoundLbl
            // 
            this.alarmSoundLbl.AutoSize = true;
            this.alarmSoundLbl.BackColor = System.Drawing.Color.Transparent;
            this.alarmSoundLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.alarmSoundLbl.Location = new System.Drawing.Point(81, 112);
            this.alarmSoundLbl.Name = "alarmSoundLbl";
            this.alarmSoundLbl.Size = new System.Drawing.Size(74, 15);
            this.alarmSoundLbl.TabIndex = 10;
            this.alarmSoundLbl.Text = "Music Name";
            // 
            // headerBar
            // 
            this.headerBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.headerBar.Controls.Add(this.pictureBox1);
            this.headerBar.Controls.Add(this.formTitleLbl);
            this.headerBar.Controls.Add(this.minimizeBtn);
            this.headerBar.Controls.Add(this.quitBtn);
            this.headerBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBar.Location = new System.Drawing.Point(0, 0);
            this.headerBar.Name = "headerBar";
            this.headerBar.Size = new System.Drawing.Size(784, 43);
            this.headerBar.TabIndex = 11;
            this.headerBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerBar_MouseDown);
            this.headerBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerBar_MouseMove);
            this.headerBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerBar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // formTitleLbl
            // 
            this.formTitleLbl.AutoSize = true;
            this.formTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.formTitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.formTitleLbl.Location = new System.Drawing.Point(51, 9);
            this.formTitleLbl.Name = "formTitleLbl";
            this.formTitleLbl.Size = new System.Drawing.Size(126, 29);
            this.formTitleLbl.TabIndex = 2;
            this.formTitleLbl.Text = "AlarmApp";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(89)))));
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(115)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(713, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "―";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.quitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitBtn.FlatAppearance.BorderSize = 0;
            this.quitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(68)))), ((int)(((byte)(5)))));
            this.quitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(131)))), ((int)(((byte)(107)))));
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitBtn.Location = new System.Drawing.Point(747, 8);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(25, 25);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "X";
            this.quitBtn.UseVisualStyleBackColor = false;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "infoContext";
            this.notifyIcon.BalloonTipTitle = "infoTitle";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AlarmApp";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(98, 26);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.clearBtn.Location = new System.Drawing.Point(21, 214);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(65, 23);
            this.clearBtn.TabIndex = 12;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // currentDateLbl
            // 
            this.currentDateLbl.AutoSize = true;
            this.currentDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(0)))));
            this.currentDateLbl.Location = new System.Drawing.Point(21, 143);
            this.currentDateLbl.Name = "currentDateLbl";
            this.currentDateLbl.Size = new System.Drawing.Size(361, 25);
            this.currentDateLbl.TabIndex = 13;
            this.currentDateLbl.Text = "Wednesday, September 30, 2022";
            // 
            // hourLbl
            // 
            this.hourLbl.AutoSize = true;
            this.hourLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hourLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.hourLbl.Location = new System.Drawing.Point(45, 25);
            this.hourLbl.Name = "hourLbl";
            this.hourLbl.Size = new System.Drawing.Size(41, 18);
            this.hourLbl.TabIndex = 15;
            this.hourLbl.Text = "Hour";
            // 
            // minuteLbl
            // 
            this.minuteLbl.AutoSize = true;
            this.minuteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minuteLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.minuteLbl.Location = new System.Drawing.Point(128, 25);
            this.minuteLbl.Name = "minuteLbl";
            this.minuteLbl.Size = new System.Drawing.Size(52, 18);
            this.minuteLbl.TabIndex = 16;
            this.minuteLbl.Text = "Minute";
            // 
            // ampmLbl
            // 
            this.ampmLbl.AutoSize = true;
            this.ampmLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ampmLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.ampmLbl.Location = new System.Drawing.Point(218, 25);
            this.ampmLbl.Name = "ampmLbl";
            this.ampmLbl.Size = new System.Drawing.Size(65, 18);
            this.ampmLbl.TabIndex = 17;
            this.ampmLbl.Text = "AM / PM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.changeDefaultSound);
            this.panel1.Controls.Add(this.amPmComboBox);
            this.panel1.Controls.Add(this.hourComboBox);
            this.panel1.Controls.Add(this.ampmLbl);
            this.panel1.Controls.Add(this.minComboBox);
            this.panel1.Controls.Add(this.minuteLbl);
            this.panel1.Controls.Add(this.SetAlarmBtn);
            this.panel1.Controls.Add(this.hourLbl);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.SetSoundBtn);
            this.panel1.Controls.Add(this.alarmSoundLbl);
            this.panel1.Location = new System.Drawing.Point(449, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 188);
            this.panel1.TabIndex = 18;
            // 
            // changeDefaultSound
            // 
            this.changeDefaultSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.changeDefaultSound.FlatAppearance.BorderSize = 0;
            this.changeDefaultSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(149)))), ((int)(((byte)(146)))));
            this.changeDefaultSound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(129)))), ((int)(((byte)(126)))));
            this.changeDefaultSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeDefaultSound.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeDefaultSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.changeDefaultSound.Location = new System.Drawing.Point(24, 138);
            this.changeDefaultSound.Name = "changeDefaultSound";
            this.changeDefaultSound.Size = new System.Drawing.Size(104, 41);
            this.changeDefaultSound.TabIndex = 18;
            this.changeDefaultSound.Text = "Change Default Sound";
            this.changeDefaultSound.UseVisualStyleBackColor = false;
            this.changeDefaultSound.Click += new System.EventHandler(this.changeDefaultSound_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(784, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentDateLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.headerBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.currentTimeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.headerBar.ResumeLayout(false);
            this.headerBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label currentTimeLbl;
        private System.Windows.Forms.ComboBox hourComboBox;
        private System.Windows.Forms.ComboBox minComboBox;
        private System.Windows.Forms.ComboBox amPmComboBox;
        private System.Windows.Forms.Button SetAlarmBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SetSoundBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label alarmSoundLbl;
        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label formTitleLbl;
        private System.Windows.Forms.Label currentDateLbl;
        private System.Windows.Forms.Label hourLbl;
        private System.Windows.Forms.Label minuteLbl;
        private System.Windows.Forms.Label ampmLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button changeDefaultSound;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

