namespace LoginForm
{
    partial class area
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            textWitdth = new TextBox();
            label5 = new Label();
            label7 = new Label();
            textLength = new TextBox();
            button2 = new Button();
            textArea = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(126, 35);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(87, 37);
            label1.TabIndex = 6;
            label1.Text = "AREA";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(160, 65);
            label2.Name = "label2";
            label2.Size = new Size(159, 37);
            label2.TabIndex = 7;
            label2.Text = "RECTANGLE";
            label2.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label4.Location = new Point(220, 35);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(37, 37);
            label4.TabIndex = 9;
            label4.Text = "O";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label3.Location = new Point(246, 35);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(31, 37);
            label3.TabIndex = 10;
            label3.Text = "F";
            label3.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(46, 164);
            label6.Name = "label6";
            label6.Size = new Size(110, 19);
            label6.TabIndex = 21;
            label6.Text = "ENTER WITDTH";
            label6.UseWaitCursor = true;
            label6.Click += label6_Click_1;
            // 
            // textWitdth
            // 
            textWitdth.BackColor = Color.FromArgb(230, 231, 233);
            textWitdth.BorderStyle = BorderStyle.FixedSingle;
            textWitdth.Cursor = Cursors.IBeam;
            textWitdth.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textWitdth.ForeColor = SystemColors.ControlText;
            textWitdth.Location = new Point(161, 163);
            textWitdth.Name = "textWitdth";
            textWitdth.Size = new Size(234, 20);
            textWitdth.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(126, 127);
            label5.Name = "label5";
            label5.Size = new Size(191, 21);
            label5.TabIndex = 22;
            label5.Text = "Formula: Area(A) = w ᕁ l";
            label5.UseWaitCursor = true;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(46, 205);
            label7.Name = "label7";
            label7.Size = new Size(109, 19);
            label7.TabIndex = 24;
            label7.Text = "ENTER LENGTH";
            label7.UseWaitCursor = true;
            // 
            // textLength
            // 
            textLength.BackColor = Color.FromArgb(230, 231, 233);
            textLength.BorderStyle = BorderStyle.FixedSingle;
            textLength.Cursor = Cursors.IBeam;
            textLength.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textLength.ForeColor = SystemColors.ControlText;
            textLength.Location = new Point(161, 204);
            textLength.Name = "textLength";
            textLength.Size = new Size(234, 20);
            textLength.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(46, 242);
            button2.Name = "button2";
            button2.Size = new Size(349, 44);
            button2.TabIndex = 3;
            button2.Text = "CALCULATE";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // textArea
            // 
            textArea.BackColor = Color.FromArgb(230, 231, 233);
            textArea.BorderStyle = BorderStyle.FixedSingle;
            textArea.Cursor = Cursors.IBeam;
            textArea.Font = new Font("MS UI Gothic", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textArea.ForeColor = SystemColors.ControlText;
            textArea.Location = new Point(46, 292);
            textArea.Name = "textArea";
            textArea.Size = new Size(349, 61);
            textArea.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(148, 372);
            label8.Name = "label8";
            label8.Size = new Size(142, 19);
            label8.TabIndex = 5;
            label8.Text = "Back to MAINMENU";
            label8.UseWaitCursor = true;
            label8.Click += label8_Click;
            // 
            // area
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 231, 233);
            ClientSize = new Size(447, 425);
            Controls.Add(label8);
            Controls.Add(textArea);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textLength);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textWitdth);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "area";
            Text = "area";
            Load += area_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox textWitdth;
        private Label label5;
        private Label label7;
        private TextBox textLength;
        private Button button2;
        private TextBox textArea;
        private Label label8;
    }
}