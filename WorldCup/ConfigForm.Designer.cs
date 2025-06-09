namespace WorldCup
{
    partial class ConfigForm
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
            cbGender = new ComboBox();
            lblLanguage = new Label();
            btnSave = new Button();
            lblTitle = new Label();
            panel1 = new Panel();
            cbLanguage = new ComboBox();
            lblGender = new Label();
            btnExit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(185, 91);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(151, 28);
            cbGender.TabIndex = 0;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(185, 68);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(74, 20);
            lblLanguage.TabIndex = 3;
            lblLanguage.Text = "Language";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(352, 90);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 28);
            btnSave.TabIndex = 4;
            btnSave.Text = "OK";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.ImageAlign = ContentAlignment.BottomLeft;
            lblTitle.Location = new Point(14, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(62, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Settings";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.DimGray;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(-4, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 38);
            panel1.TabIndex = 6;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(21, 91);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(151, 28);
            cbLanguage.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(21, 68);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 1;
            lblGender.Text = "Gender";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(448, 90);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // ConfigForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 154);
            Controls.Add(btnExit);
            Controls.Add(lblGender);
            Controls.Add(cbLanguage);
            Controls.Add(btnSave);
            Controls.Add(lblLanguage);
            Controls.Add(cbGender);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfigForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbGender;
        private Label lblLanguage;
        private Button btnSave;
        private Label lblTitle;
        private Panel panel1;
        private ComboBox cbLanguage;
        private Label lblGender;
        private Button btnExit;
    }
}
