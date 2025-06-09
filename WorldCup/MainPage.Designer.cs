namespace WorldCup
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblChooseTeam = new Label();
            cbTeams = new ComboBox();
            btnList = new Button();
            lblFavouritePlayers = new Label();
            lblAllPlayers = new Label();
            flpFavouritePlayers = new FlowLayoutPanel();
            flpAllPlayers = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.125F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.875F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(lblFavouritePlayers, 0, 1);
            tableLayoutPanel1.Controls.Add(lblAllPlayers, 1, 1);
            tableLayoutPanel1.Controls.Add(flpFavouritePlayers, 0, 2);
            tableLayoutPanel1.Controls.Add(flpAllPlayers, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.669811F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.36792469F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.962265F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.6192665F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.3807335F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 92F));
            tableLayoutPanel2.Controls.Add(lblChooseTeam, 0, 0);
            tableLayoutPanel2.Controls.Add(cbTeams, 1, 0);
            tableLayoutPanel2.Controls.Add(btnList, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(395, 35);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // lblChooseTeam
            // 
            lblChooseTeam.Anchor = AnchorStyles.Left;
            lblChooseTeam.AutoSize = true;
            lblChooseTeam.Location = new Point(3, 7);
            lblChooseTeam.Name = "lblChooseTeam";
            lblChooseTeam.Size = new Size(111, 20);
            lblChooseTeam.TabIndex = 0;
            lblChooseTeam.Text = "Choose a team:";
            // 
            // cbTeams
            // 
            cbTeams.Enabled = false;
            cbTeams.FormattingEnabled = true;
            cbTeams.Location = new Point(132, 3);
            cbTeams.Name = "cbTeams";
            cbTeams.Size = new Size(158, 28);
            cbTeams.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.Location = new Point(305, 3);
            btnList.Name = "btnList";
            btnList.Size = new Size(87, 29);
            btnList.TabIndex = 2;
            btnList.Text = "List";
            btnList.UseVisualStyleBackColor = true;
            // 
            // lblFavouritePlayers
            // 
            lblFavouritePlayers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblFavouritePlayers.AutoSize = true;
            lblFavouritePlayers.Location = new Point(3, 44);
            lblFavouritePlayers.Name = "lblFavouritePlayers";
            lblFavouritePlayers.Size = new Size(395, 20);
            lblFavouritePlayers.TabIndex = 3;
            lblFavouritePlayers.Text = "Favourite Players";
            // 
            // lblAllPlayers
            // 
            lblAllPlayers.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblAllPlayers.AutoSize = true;
            lblAllPlayers.Location = new Point(404, 44);
            lblAllPlayers.Name = "lblAllPlayers";
            lblAllPlayers.Size = new Size(393, 20);
            lblAllPlayers.TabIndex = 4;
            lblAllPlayers.Text = "All Players";
            // 
            // flpFavouritePlayers
            // 
            flpFavouritePlayers.BackColor = SystemColors.InactiveBorder;
            flpFavouritePlayers.Dock = DockStyle.Fill;
            flpFavouritePlayers.Location = new Point(3, 71);
            flpFavouritePlayers.Name = "flpFavouritePlayers";
            flpFavouritePlayers.Size = new Size(395, 350);
            flpFavouritePlayers.TabIndex = 5;
            // 
            // flpAllPlayers
            // 
            flpAllPlayers.BackColor = SystemColors.InactiveBorder;
            flpAllPlayers.Dock = DockStyle.Fill;
            flpAllPlayers.Location = new Point(404, 71);
            flpAllPlayers.Name = "flpAllPlayers";
            flpAllPlayers.Size = new Size(393, 350);
            flpAllPlayers.TabIndex = 6;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainPage";
            Text = " World Cup Statistics";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblChooseTeam;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox cbTeams;
        private Button btnList;
        private Label lblFavouritePlayers;
        private Label lblAllPlayers;
        private FlowLayoutPanel flpFavouritePlayers;
        private FlowLayoutPanel flpAllPlayers;
    }
}