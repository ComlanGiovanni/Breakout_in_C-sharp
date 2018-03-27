namespace Breakout
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgBall = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBall
            // 
            this.imgBall.BackColor = System.Drawing.Color.Black;
            this.imgBall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgBall.Location = new System.Drawing.Point(535, 332);
            this.imgBall.Name = "imgBall";
            this.imgBall.Size = new System.Drawing.Size(25, 25);
            this.imgBall.TabIndex = 0;
            this.imgBall.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // imgBar
            // 
            this.imgBar.BackColor = System.Drawing.Color.White;
            this.imgBar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgBar.Location = new System.Drawing.Point(250, 620);
            this.imgBar.Name = "imgBar";
            this.imgBar.Size = new System.Drawing.Size(173, 12);
            this.imgBar.TabIndex = 1;
            this.imgBar.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.imgBar);
            this.Controls.Add(this.imgBall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.imgBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox imgBar;
    }
}

