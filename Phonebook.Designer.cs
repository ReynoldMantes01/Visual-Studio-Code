namespace LoginForm
{
    partial class Phonebook
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
            label7 = new Label();
            buttonNew = new Button();
            dataGridView = new DataGridView();
            panel1 = new Panel();
            textEmail = new TextBox();
            textNumber = new TextBox();
            label3 = new Label();
            textName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            textSearchBox = new TextBox();
            label4 = new Label();
            buttonEdit = new Button();
            buttonCancel = new Button();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label2.Location = new Point(357, 15);
            label2.Name = "label2";
            label2.Size = new Size(88, 37);
            label2.TabIndex = 5;
            label2.Text = "BOOK";
            label2.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            label1.Location = new Point(258, 15);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(110, 37);
            label1.TabIndex = 4;
            label1.Text = "PHONE";
            label1.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(274, 421);
            label7.Name = "label7";
            label7.Size = new Size(142, 19);
            label7.TabIndex = 7;
            label7.Text = "Back to MAINMENU";
            label7.UseWaitCursor = true;
            label7.Click += label7_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(357, 386);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(75, 23);
            buttonNew.TabIndex = 3;
            buttonNew.Text = "New";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(25, 213);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(650, 167);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(textEmail);
            panel1.Controls.Add(textNumber);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(25, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 123);
            panel1.TabIndex = 33;
            // 
            // textEmail
            // 
            textEmail.BackColor = Color.FromArgb(230, 231, 233);
            textEmail.BorderStyle = BorderStyle.FixedSingle;
            textEmail.Cursor = Cursors.IBeam;
            textEmail.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textEmail.ForeColor = SystemColors.ControlText;
            textEmail.Location = new Point(105, 85);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(517, 20);
            textEmail.TabIndex = 3;
            textEmail.TextChanged += textEmail_TextChanged;
            // 
            // textNumber
            // 
            textNumber.BackColor = Color.FromArgb(230, 231, 233);
            textNumber.BorderStyle = BorderStyle.FixedSingle;
            textNumber.Cursor = Cursors.IBeam;
            textNumber.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textNumber.ForeColor = SystemColors.ControlText;
            textNumber.Location = new Point(105, 50);
            textNumber.Name = "textNumber";
            textNumber.Size = new Size(408, 20);
            textNumber.TabIndex = 2;
            textNumber.TextChanged += textNumber_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(49, 19);
            label3.TabIndex = 39;
            label3.Text = "Email:";
            label3.UseWaitCursor = true;
            // 
            // textName
            // 
            textName.BackColor = Color.FromArgb(230, 231, 233);
            textName.BorderStyle = BorderStyle.FixedSingle;
            textName.Cursor = Cursors.IBeam;
            textName.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textName.ForeColor = SystemColors.ControlText;
            textName.Location = new Point(105, 13);
            textName.Name = "textName";
            textName.Size = new Size(299, 20);
            textName.TabIndex = 1;
            textName.TextChanged += textName_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(22, 14);
            label6.Name = "label6";
            label6.Size = new Size(53, 19);
            label6.TabIndex = 37;
            label6.Text = "Name:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 51);
            label5.Name = "label5";
            label5.Size = new Size(69, 19);
            label5.TabIndex = 38;
            label5.Text = "Number:";
            label5.UseWaitCursor = true;
            // 
            // textSearchBox
            // 
            textSearchBox.BackColor = Color.FromArgb(230, 231, 233);
            textSearchBox.BorderStyle = BorderStyle.FixedSingle;
            textSearchBox.Cursor = Cursors.IBeam;
            textSearchBox.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textSearchBox.ForeColor = SystemColors.ControlText;
            textSearchBox.Location = new Point(130, 187);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(517, 20);
            textSearchBox.TabIndex = 4;
            textSearchBox.TextChanged += textSearchBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(47, 188);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 41;
            label4.Text = "Search:";
            label4.UseWaitCursor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(438, 386);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(519, 386);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Delete";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(600, 386);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 42;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // Phonebook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 231, 233);
            ClientSize = new Size(704, 449);
            Controls.Add(buttonSave);
            Controls.Add(buttonCancel);
            Controls.Add(buttonEdit);
            Controls.Add(textSearchBox);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(dataGridView);
            Controls.Add(buttonNew);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Phonebook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phonebook";
            Load += Phonebook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label7;
        private Button buttonNew;
        private DataGridView dataGridView;
        private Panel panel1;
        private TextBox textEmail;
        private TextBox textNumber;
        private Label label3;
        private TextBox textName;
        private Label label6;
        private Label label5;
        private TextBox textSearchBox;
        private Label label4;
        private Button buttonEdit;
        private Button buttonCancel;
        private Button buttonSave;
    }
}