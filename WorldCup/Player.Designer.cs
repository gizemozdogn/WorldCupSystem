namespace WorldCup
{
    partial class Player
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
            pbProfile = new PictureBox();
            lblName = new Label();
            lblShirtNumber = new Label();
            lblPosition = new Label();
            pbFavourite = new PictureBox();
            lblIsCaptain = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFavourite).BeginInit();
            SuspendLayout();
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.defaultUser;
            pbProfile.Location = new Point(15, 20);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(121, 120);
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(145, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(70, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Jane Doe";
            // 
            // lblShirtNumber
            // 
            lblShirtNumber.AutoSize = true;
            lblShirtNumber.Location = new Point(30, 143);
            lblShirtNumber.Name = "lblShirtNumber";
            lblShirtNumber.Size = new Size(97, 20);
            lblShirtNumber.TabIndex = 2;
            lblShirtNumber.Text = "Shirt Number";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(145, 47);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(61, 20);
            lblPosition.TabIndex = 3;
            lblPosition.Text = "Position";
            // 
            // pbFavourite
            // 
            pbFavourite.Image = Properties.Resources.notFavIcon;
            pbFavourite.Location = new Point(298, 110);
            pbFavourite.Name = "pbFavourite";
            pbFavourite.Size = new Size(46, 40);
            pbFavourite.TabIndex = 4;
            pbFavourite.TabStop = false;
            // 
            // lblIsCaptain
            // 
            lblIsCaptain.AutoSize = true;
            lblIsCaptain.Location = new Point(221, 20);
            lblIsCaptain.Name = "lblIsCaptain";
            lblIsCaptain.Size = new Size(70, 20);
            lblIsCaptain.TabIndex = 5;
            lblIsCaptain.Text = "IsCaptain";
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblIsCaptain);
            Controls.Add(pbFavourite);
            Controls.Add(lblPosition);
            Controls.Add(lblShirtNumber);
            Controls.Add(lblName);
            Controls.Add(pbProfile);
            Name = "Player";
            Size = new Size(360, 173);
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFavourite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProfile;
        private Label lblName;
        private Label lblShirtNumber;
        private Label lblPosition;
        private PictureBox pbFavourite;
        private Label lblIsCaptain;
    }
}
