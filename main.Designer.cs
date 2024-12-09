namespace LoginForm
{
    partial class Main
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
            button2 = new Button();
            button1 = new Button();
            logout = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(213, 53);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 5;
            label2.Text = "MENU";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(131, 53);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(92, 37);
            label1.TabIndex = 4;
            label1.Text = "MAIN";
            label1.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(106, 245);
            button2.Name = "button2";
            button2.Size = new Size(234, 44);
            button2.TabIndex = 3;
            button2.Text = "PHONEBOOK";
            button2.UseVisualStyleBackColor = false;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.Location = new Point(106, 191);
            button1.Name = "button1";
            button1.Size = new Size(234, 44);
            button1.TabIndex = 2;
            button1.Text = "AREA OF RECTANGLE";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // logout
            // 
            logout.BackColor = Color.DarkRed;
            logout.Cursor = Cursors.Hand;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            logout.ForeColor = SystemColors.Control;
            logout.Location = new Point(106, 346);
            logout.Name = "logout";
            logout.Size = new Size(234, 44);
            logout.TabIndex = 4;
            logout.Text = "LOG OUT";
            logout.UseVisualStyleBackColor = false;
            logout.UseWaitCursor = true;
            logout.Click += logout_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.Location = new Point(106, 137);
            button3.Name = "button3";
            button3.Size = new Size(234, 44);
            button3.TabIndex = 1;
            button3.Text = "CALCULATOR";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(106, 296);
            button4.Name = "button4";
            button4.Size = new Size(234, 44);
            button4.TabIndex = 6;
            button4.Text = "Slot Machine";
            button4.UseVisualStyleBackColor = false;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 231, 233);
            ClientSize = new Size(447, 425);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(logout);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Main";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button logout;
        private Button button3;
        private Button button4;
    }
}