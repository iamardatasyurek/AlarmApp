
namespace AlarmAppV2.UserController
{
    partial class AlarmControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.alarmInfoLbl = new System.Windows.Forms.Label();
            this.alarmActiveCBox = new System.Windows.Forms.CheckBox();
            this.alarmDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alarmInfoLbl
            // 
            this.alarmInfoLbl.AutoSize = true;
            this.alarmInfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.alarmInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alarmInfoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.alarmInfoLbl.Location = new System.Drawing.Point(13, 18);
            this.alarmInfoLbl.Name = "alarmInfoLbl";
            this.alarmInfoLbl.Size = new System.Drawing.Size(487, 29);
            this.alarmInfoLbl.TabIndex = 12;
            this.alarmInfoLbl.Text = "Wednesday, September 30, 2022 - 12:59 AM";
            // 
            // alarmActiveCBox
            // 
            this.alarmActiveCBox.AutoSize = true;
            this.alarmActiveCBox.BackColor = System.Drawing.Color.Transparent;
            this.alarmActiveCBox.Checked = true;
            this.alarmActiveCBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alarmActiveCBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.alarmActiveCBox.Location = new System.Drawing.Point(612, 27);
            this.alarmActiveCBox.Name = "alarmActiveCBox";
            this.alarmActiveCBox.Size = new System.Drawing.Size(59, 19);
            this.alarmActiveCBox.TabIndex = 13;
            this.alarmActiveCBox.Text = "Active";
            this.alarmActiveCBox.UseVisualStyleBackColor = false;
            this.alarmActiveCBox.CheckedChanged += new System.EventHandler(this.alarmActiveCBox_CheckedChanged);
            // 
            // alarmDeleteBtn
            // 
            this.alarmDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(139)))), ((int)(((byte)(136)))));
            this.alarmDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alarmDeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.alarmDeleteBtn.Location = new System.Drawing.Point(677, 23);
            this.alarmDeleteBtn.Name = "alarmDeleteBtn";
            this.alarmDeleteBtn.Size = new System.Drawing.Size(72, 23);
            this.alarmDeleteBtn.TabIndex = 14;
            this.alarmDeleteBtn.Text = "Delete ⌫";
            this.alarmDeleteBtn.UseVisualStyleBackColor = false;
            this.alarmDeleteBtn.Click += new System.EventHandler(this.alarmDeleteBtn_Click);
            // 
            // AlarmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.alarmDeleteBtn);
            this.Controls.Add(this.alarmActiveCBox);
            this.Controls.Add(this.alarmInfoLbl);
            this.Name = "AlarmControl";
            this.Size = new System.Drawing.Size(756, 65);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label alarmInfoLbl;
        private System.Windows.Forms.CheckBox alarmActiveCBox;
        private System.Windows.Forms.Button alarmDeleteBtn;
    }
}
