
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RocketImageButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.TopTextLabel = new System.Windows.Forms.Label();
            this.DownTextLabel = new System.Windows.Forms.Label();
            this.ScoreDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RocketImageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).BeginInit();
            this.SuspendLayout();
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
            // ScoreDataGrid
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.ScoreDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ScoreDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ScoreDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.ScoreDataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ScoreDataGrid.Location = new System.Drawing.Point(7, 131);
            this.ScoreDataGrid.Name = "ScoreDataGrid";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScoreDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            this.ScoreDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ScoreDataGrid.Size = new System.Drawing.Size(453, 486);
            this.ScoreDataGrid.TabIndex = 4;
            // 
            // TeamScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(465, 629);
            this.Controls.Add(this.ScoreDataGrid);
            this.Controls.Add(this.DownTextLabel);
            this.Controls.Add(this.TopTextLabel);
            this.Controls.Add(this.RocketImageButton);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamScoreForm";
            this.Text = "Yarışma İçerisinde Bulunan Projelerin Genel Skorları";
            this.Load += new System.EventHandler(this.TeamScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RocketImageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScoreDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton RocketImageButton;
        private System.Windows.Forms.Label TopTextLabel;
        private System.Windows.Forms.Label DownTextLabel;
        private System.Windows.Forms.DataGridView ScoreDataGrid;
    }
}