namespace LoginForm
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
            button1 = new Button();
            label1 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            checkboxShowPas = new CheckBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            textPassword = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(109, 312);
            button1.Name = "button1";
            button1.Size = new Size(234, 25);
            button1.TabIndex = 4;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(134, 28);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(84, 37);
            label1.TabIndex = 1;
            label1.Text = "USER";
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 233);
            textUsername.BorderStyle = BorderStyle.FixedSingle;
            textUsername.Cursor = Cursors.IBeam;
            textUsername.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textUsername.ForeColor = SystemColors.ControlText;
            textUsername.Location = new Point(109, 209);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(234, 20);
            textUsername.TabIndex = 1;
            textUsername.UseWaitCursor = true;
            textUsername.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(208, 28);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 3;
            label2.Text = "LOGIN";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // checkboxShowPas
            // 
            checkboxShowPas.AutoSize = true;
            checkboxShowPas.Cursor = Cursors.Hand;
            checkboxShowPas.FlatStyle = FlatStyle.Flat;
            checkboxShowPas.Location = new Point(238, 287);
            checkboxShowPas.Name = "checkboxShowPas";
            checkboxShowPas.Size = new Size(105, 19);
            checkboxShowPas.TabIndex = 3;
            checkboxShowPas.Text = "Show Password";
            checkboxShowPas.UseVisualStyleBackColor = true;
            checkboxShowPas.UseWaitCursor = true;
            checkboxShowPas.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(162, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(109, 187);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 9;
            label3.Text = "Username";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(109, 239);
            label4.Name = "label4";
            label4.Size = new Size(67, 19);
            label4.TabIndex = 10;
            label4.Text = "Password";
            label4.UseWaitCursor = true;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.FixedSingle;
            textPassword.Cursor = Cursors.IBeam;
            textPassword.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textPassword.ForeColor = SystemColors.ControlText;
            textPassword.Location = new Point(109, 261);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(234, 20);
            textPassword.TabIndex = 2;
            textPassword.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(109, 343);
            button2.Name = "button2";
            button2.Size = new Size(234, 25);
            button2.TabIndex = 5;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 425);
            Controls.Add(button2);
            Controls.Add(textPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(checkboxShowPas);
            Controls.Add(label2);
            Controls.Add(textUsername);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "USER LOGIN";
            UseWaitCursor = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textUsername;
        private Label label2;
        private CheckBox checkboxShowPas;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private TextBox textPassword;
        private Button button2;
    }
}
