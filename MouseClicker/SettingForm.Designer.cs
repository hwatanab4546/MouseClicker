namespace MouseClicker
{
    partial class SettingForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbCntrl = new System.Windows.Forms.CheckBox();
            this.cbShift = new System.Windows.Forms.CheckBox();
            this.cbAlt = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxClickButton = new System.Windows.Forms.ComboBox();
            this.nudCursorPosX = new System.Windows.Forms.NumericUpDown();
            this.nudCursorPosY = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudClickCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudClickIntervalMs = new System.Windows.Forms.NumericUpDown();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCursorPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCursorPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickIntervalMs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "修飾キー";
            // 
            // cbCntrl
            // 
            this.cbCntrl.AutoSize = true;
            this.cbCntrl.Location = new System.Drawing.Point(156, 31);
            this.cbCntrl.Name = "cbCntrl";
            this.cbCntrl.Size = new System.Drawing.Size(49, 16);
            this.cbCntrl.TabIndex = 1;
            this.cbCntrl.Text = "Cntrl";
            this.cbCntrl.UseVisualStyleBackColor = true;
            // 
            // cbShift
            // 
            this.cbShift.AutoSize = true;
            this.cbShift.Location = new System.Drawing.Point(211, 31);
            this.cbShift.Name = "cbShift";
            this.cbShift.Size = new System.Drawing.Size(48, 16);
            this.cbShift.TabIndex = 2;
            this.cbShift.Text = "Shift";
            this.cbShift.UseVisualStyleBackColor = true;
            // 
            // cbAlt
            // 
            this.cbAlt.AutoSize = true;
            this.cbAlt.Location = new System.Drawing.Point(265, 31);
            this.cbAlt.Name = "cbAlt";
            this.cbAlt.Size = new System.Drawing.Size(39, 16);
            this.cbAlt.TabIndex = 3;
            this.cbAlt.Text = "Alt";
            this.cbAlt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ホットキー";
            // 
            // txtKeyCode
            // 
            this.txtKeyCode.Location = new System.Drawing.Point(156, 53);
            this.txtKeyCode.Name = "txtKeyCode";
            this.txtKeyCode.Size = new System.Drawing.Size(100, 19);
            this.txtKeyCode.TabIndex = 5;
            this.txtKeyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "マウスカーソル座標";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "(";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(7, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = ")";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "クリックボタン";
            // 
            // cbxClickButton
            // 
            this.cbxClickButton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClickButton.FormattingEnabled = true;
            this.cbxClickButton.Location = new System.Drawing.Point(156, 103);
            this.cbxClickButton.Name = "cbxClickButton";
            this.cbxClickButton.Size = new System.Drawing.Size(113, 20);
            this.cbxClickButton.TabIndex = 13;
            // 
            // nudCursorPosX
            // 
            this.nudCursorPosX.Location = new System.Drawing.Point(169, 78);
            this.nudCursorPosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCursorPosX.Name = "nudCursorPosX";
            this.nudCursorPosX.Size = new System.Drawing.Size(100, 19);
            this.nudCursorPosX.TabIndex = 8;
            this.nudCursorPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudCursorPosY
            // 
            this.nudCursorPosY.Location = new System.Drawing.Point(288, 79);
            this.nudCursorPosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudCursorPosY.Name = "nudCursorPosY";
            this.nudCursorPosY.Size = new System.Drawing.Size(100, 19);
            this.nudCursorPosY.TabIndex = 10;
            this.nudCursorPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "クリック回数";
            // 
            // nudClickCount
            // 
            this.nudClickCount.Location = new System.Drawing.Point(156, 129);
            this.nudClickCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudClickCount.Name = "nudClickCount";
            this.nudClickCount.Size = new System.Drawing.Size(100, 19);
            this.nudClickCount.TabIndex = 15;
            this.nudClickCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudClickCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "クリック間隔(ミリ秒)";
            // 
            // nudClickIntervalMs
            // 
            this.nudClickIntervalMs.Location = new System.Drawing.Point(156, 154);
            this.nudClickIntervalMs.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudClickIntervalMs.Name = "nudClickIntervalMs";
            this.nudClickIntervalMs.Size = new System.Drawing.Size(100, 19);
            this.nudClickIntervalMs.TabIndex = 17;
            this.nudClickIntervalMs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudClickIntervalMs.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(233, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(328, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(436, 245);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.nudClickIntervalMs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudClickCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCursorPosY);
            this.Controls.Add(this.nudCursorPosX);
            this.Controls.Add(this.cbxClickButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKeyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAlt);
            this.Controls.Add(this.cbShift);
            this.Controls.Add(this.cbCntrl);
            this.Controls.Add(this.label1);
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudCursorPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCursorPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudClickIntervalMs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbCntrl;
        private System.Windows.Forms.CheckBox cbShift;
        private System.Windows.Forms.CheckBox cbAlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxClickButton;
        private System.Windows.Forms.NumericUpDown nudCursorPosX;
        private System.Windows.Forms.NumericUpDown nudCursorPosY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudClickCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudClickIntervalMs;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}