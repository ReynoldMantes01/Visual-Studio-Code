namespace LoginForm
{
    partial class FormRegister
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
            label2 = new Label();
            label1 = new Label();
            textPas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textUsername = new TextBox();
            textConfirmPas = new TextBox();
            label3 = new Label();
            checkBoxpass = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(198, 28);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 5;
            label2.Text = "Started";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(146, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(62, 37);
            label1.TabIndex = 4;
            label1.Text = "Get";
            // 
            // textPas
            // 
            textPas.BackColor = Color.FromArgb(230, 231, 233);
            textPas.BorderStyle = BorderStyle.FixedSingle;
            textPas.Cursor = Cursors.IBeam;
            textPas.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPas.ForeColor = SystemColors.ControlText;
            textPas.Location = new Point(106, 159);
            textPas.Name = "textPas";
            textPas.PasswordChar = '*';
            textPas.Size = new Size(234, 20);
            textPas.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(106, 137);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 20;
            label5.Text = "Password";
            label5.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(106, 85);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 19;
            label6.Text = "Username";
            label6.UseWaitCursor = true;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.FixedSingle;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUsername.ForeColor = SystemColors.ControlText;
            textUsername.Location = new Point(106, 107);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(234, 20);
            textUsername.TabIndex = 1;
            // 
            // textConfirmPas
            // 
            textConfirmPas.BackColor = Color.FromArgb(230, 231, 233);
            textConfirmPas.BorderStyle = BorderStyle.FixedSingle;
            textConfirmPas.Cursor = Cursors.IBeam;
            textConfirmPas.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textConfirmPas.ForeColor = SystemColors.ControlText;
            textConfirmPas.Location = new Point(106, 210);
            textConfirmPas.Name = "textConfirmPas";
            textConfirmPas.PasswordChar = '*';
            textConfirmPas.Size = new Size(234, 20);
            textConfirmPas.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(106, 188);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 23;
            label3.Text = "Confirm Password";
            label3.UseWaitCursor = true;
            // 
            // checkBoxpass
            // 
            checkBoxpass.AutoSize = true;
            checkBoxpass.Cursor = Cursors.Hand;
            checkBoxpass.FlatStyle = FlatStyle.Flat;
            checkBoxpass.Location = new Point(235, 236);
            checkBoxpass.Name = "checkBoxpass";
            checkBoxpass.Size = new Size(105, 19);
            checkBoxpass.TabIndex = 4;
            checkBoxpass.Text = "Show Password";
            checkBoxpass.UseVisualStyleBackColor = true;
            checkBoxpass.UseWaitCursor = true;
            checkBoxpass.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(106, 271);
            button2.Name = "button2";
            button2.Size = new Size(234, 25);
            button2.TabIndex = 5;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(106, 302);
            button1.Name = "button1";
            button1.Size = new Size(234, 25);
            button1.TabIndex = 6;
            button1.Text = "CLEAR";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(146, 341);
            label4.Name = "label4";
            label4.Size = new Size(163, 19);
            label4.TabIndex = 27;
            label4.Text = "Already Have an Account";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(172, 360);
            label7.Name = "label7";
            label7.Size = new Size(106, 19);
            label7.TabIndex = 7;
            label7.Text = "Back to LOGIN";
            label7.UseWaitCursor = true;
            label7.Click += label7_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 231, 233);
            ClientSize = new Size(447, 425);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(textConfirmPas);
            Controls.Add(label3);
            Controls.Add(checkBoxpass);
            Controls.Add(textPas);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormRegister";
            Text = "FormRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textPas;
        private Label label5;
        private Label label6;
        private TextBox textUsername;
        private TextBox textConfirmPas;
        private Label label3;
        private CheckBox checkBoxpass;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label7;
    }
}