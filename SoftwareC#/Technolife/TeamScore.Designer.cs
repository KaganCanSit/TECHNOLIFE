
namespace Technolife
{
    partial class TeamScoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamScoreForm));
            this.ScoreDataGrid = new System.Windows.Forms.DataGridView();
            this.RocketImageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TopTextLabel = new System.Windows.Forms.Label();
            this.DownTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketImageButton)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreDataGrid
            // 
            this.ScoreDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.ScoreDataGrid.Location = new System.Drawing.Point(7, 131);
            this.ScoreDataGrid.Name = "ScoreDataGrid";
            this.ScoreDataGrid.Size = new System.Drawing.Size(451, 486);
            this.ScoreDataGrid.TabIndex = 0;
            this.ScoreDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScoreDataGrid_CellContentClick);
            // 
            // RocketImageButton
            // 
            this.RocketImageButton.BackColor = System.Drawing.Color.Transparent;
            this.RocketImageButton.Image = ((System.Drawing.Image)(resources.GetObject("RocketImageButton.Image")));
            this.RocketImageButton.ImageActive = null;
            this.RocketImageButton.Location = new System.Drawing.Point(32, 10);
            this.RocketImageButton.Name = "RocketImageButton";
            this.RocketImageButton.Size = new System.Drawing.Size(106, 115);
            this.RocketImageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RocketImageButton.TabIndex = 1;
            this.RocketImageButton.TabStop = false;
            this.RocketImageButton.Zoom = 10;
            // 
            // TopTextLabel
            // 
            this.TopTextLabel.AutoSize = true;
            this.TopTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopTextLabel.Font = new System.Drawing.Font("Gotham Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopTextLabel.ForeColor = System.Drawing.Color.Black;
            this.TopTextLabel.Location = new System.Drawing.Point(198, 30);
            this.TopTextLabel.Name = "TopTextLabel";
            this.TopTextLabel.Size = new System.Drawing.Size(206, 22);
            this.TopTextLabel.TabIndex = 2;
            this.TopTextLabel.Text = "KANATLANIYORUZ!";
            // 
            // DownTextLabel
            // 
            this.DownTextLabel.AutoSize = true;
            this.DownTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.DownTextLabel.ForeColor = System.Drawing.Color.Black;
            this.DownTextLabel.Location = new System.Drawing.Point(178, 71);
            this.DownTextLabel.Name = "DownTextLabel";
            this.DownTextLabel.Size = new System.Drawing.Size(255, 26);
            this.DownTextLabel.TabIndex = 3;
            this.DownTextLabel.Text = "Şu an sistemimizde yer alan projelerin genel bilgilerini \r\nburadan inceleyebilirs" +
    "in.";
            this.DownTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 629);
            this.Controls.Add(this.DownTextLabel);
            this.Controls.Add(this.TopTextLabel);
            this.Controls.Add(this.RocketImageButton);
            this.Controls.Add(this.ScoreDataGrid);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamScoreForm";
            this.Text = "Yarışma İçerisinde Bulunan Projelerin Genel Skorları";
            this.Load += new System.EventHandler(this.TeamScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RocketImageButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoreDataGrid;
        private Bunifu.Framework.UI.BunifuImageButton RocketImageButton;
        private System.Windows.Forms.Label TopTextLabel;
        private System.Windows.Forms.Label DownTextLabel;
    }
}