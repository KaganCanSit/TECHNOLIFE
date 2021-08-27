
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.TopTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreDataGrid
            // 
            this.ScoreDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ScoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScoreDataGrid.Location = new System.Drawing.Point(12, 89);
            this.ScoreDataGrid.Name = "ScoreDataGrid";
            this.ScoreDataGrid.Size = new System.Drawing.Size(451, 528);
            this.ScoreDataGrid.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(88, 82);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // TopTextLabel
            // 
            this.TopTextLabel.AutoSize = true;
            this.TopTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TopTextLabel.Font = new System.Drawing.Font("Gotham Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TopTextLabel.ForeColor = System.Drawing.Color.Black;
            this.TopTextLabel.Location = new System.Drawing.Point(149, 15);
            this.TopTextLabel.Name = "TopTextLabel";
            this.TopTextLabel.Size = new System.Drawing.Size(206, 22);
            this.TopTextLabel.TabIndex = 2;
            this.TopTextLabel.Text = "KANATLANIYORUZ!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(129, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şu an sistemimizde yer alan projelerin genel bilgilerini \r\nburadan inceleyebilirs" +
    "in.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TeamScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopTextLabel);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.ScoreDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamScoreForm";
            this.Text = "Yarışma İçerisinde Bulunan Projelerin Genel Skorları";
            this.Load += new System.EventHandler(this.TeamScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ScoreDataGrid;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label TopTextLabel;
        private System.Windows.Forms.Label label1;
    }
}