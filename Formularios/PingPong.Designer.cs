namespace PingPong_Generacion_de_figuras_Grupo3
{
    partial class PingPong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPong));
            this.label1 = new System.Windows.Forms.Label();
            this.LbReanudar = new System.Windows.Forms.Label();
            this.LbReiniciar = new System.Windows.Forms.Label();
            this.LbSalirAlmenu = new System.Windows.Forms.Label();
            this.LbSalir = new System.Windows.Forms.Label();
            this.PbSalir = new System.Windows.Forms.PictureBox();
            this.PbMenu = new System.Windows.Forms.PictureBox();
            this.PbReini = new System.Windows.Forms.PictureBox();
            this.PbRean = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRean)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monocraft", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAUSED";
            // 
            // LbReanudar
            // 
            this.LbReanudar.AutoSize = true;
            this.LbReanudar.Font = new System.Drawing.Font("Monocraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReanudar.ForeColor = System.Drawing.Color.White;
            this.LbReanudar.Location = new System.Drawing.Point(284, 202);
            this.LbReanudar.Name = "LbReanudar";
            this.LbReanudar.Size = new System.Drawing.Size(125, 29);
            this.LbReanudar.TabIndex = 1;
            this.LbReanudar.Text = "Reanudar";
            this.LbReanudar.MouseLeave += new System.EventHandler(this.lbReanudar_MouseLeave);
            this.LbReanudar.MouseHover += new System.EventHandler(this.lbReanudar_MouseHover);
            // 
            // LbReiniciar
            // 
            this.LbReiniciar.AutoSize = true;
            this.LbReiniciar.Font = new System.Drawing.Font("Monocraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbReiniciar.ForeColor = System.Drawing.Color.White;
            this.LbReiniciar.Location = new System.Drawing.Point(284, 268);
            this.LbReiniciar.Name = "LbReiniciar";
            this.LbReiniciar.Size = new System.Drawing.Size(139, 29);
            this.LbReiniciar.TabIndex = 2;
            this.LbReiniciar.Text = "Reiniciar";
            this.LbReiniciar.MouseLeave += new System.EventHandler(this.LbReiniciar_MouseLeave);
            this.LbReiniciar.MouseHover += new System.EventHandler(this.LbReiniciar_MouseHover);
            // 
            // LbSalirAlmenu
            // 
            this.LbSalirAlmenu.AutoSize = true;
            this.LbSalirAlmenu.Font = new System.Drawing.Font("Monocraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSalirAlmenu.ForeColor = System.Drawing.Color.White;
            this.LbSalirAlmenu.Location = new System.Drawing.Point(284, 403);
            this.LbSalirAlmenu.Name = "LbSalirAlmenu";
            this.LbSalirAlmenu.Size = new System.Drawing.Size(195, 29);
            this.LbSalirAlmenu.TabIndex = 3;
            this.LbSalirAlmenu.Text = "Salir al menu";
            this.LbSalirAlmenu.MouseLeave += new System.EventHandler(this.LbSalirAlmenu_MouseLeave);
            this.LbSalirAlmenu.MouseHover += new System.EventHandler(this.LbSalirAlmenu_MouseHover);
            // 
            // LbSalir
            // 
            this.LbSalir.AutoSize = true;
            this.LbSalir.Font = new System.Drawing.Font("Monocraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbSalir.ForeColor = System.Drawing.Color.White;
            this.LbSalir.Location = new System.Drawing.Point(284, 336);
            this.LbSalir.Name = "LbSalir";
            this.LbSalir.Size = new System.Drawing.Size(83, 29);
            this.LbSalir.TabIndex = 4;
            this.LbSalir.Text = "Salir";
            this.LbSalir.MouseLeave += new System.EventHandler(this.LbSalir_MouseLeave);
            this.LbSalir.MouseHover += new System.EventHandler(this.LbSalir_MouseHover);
            // 
            // PbSalir
            // 
            this.PbSalir.Image = ((System.Drawing.Image)(resources.GetObject("PbSalir.Image")));
            this.PbSalir.Location = new System.Drawing.Point(228, 323);
            this.PbSalir.Name = "PbSalir";
            this.PbSalir.Size = new System.Drawing.Size(50, 53);
            this.PbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSalir.TabIndex = 7;
            this.PbSalir.TabStop = false;
            this.PbSalir.Visible = false;
            // 
            // PbMenu
            // 
            this.PbMenu.Image = ((System.Drawing.Image)(resources.GetObject("PbMenu.Image")));
            this.PbMenu.Location = new System.Drawing.Point(228, 392);
            this.PbMenu.Name = "PbMenu";
            this.PbMenu.Size = new System.Drawing.Size(50, 53);
            this.PbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbMenu.TabIndex = 8;
            this.PbMenu.TabStop = false;
            this.PbMenu.Visible = false;
            // 
            // PbReini
            // 
            this.PbReini.Image = ((System.Drawing.Image)(resources.GetObject("PbReini.Image")));
            this.PbReini.Location = new System.Drawing.Point(228, 256);
            this.PbReini.Name = "PbReini";
            this.PbReini.Size = new System.Drawing.Size(50, 53);
            this.PbReini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbReini.TabIndex = 9;
            this.PbReini.TabStop = false;
            this.PbReini.Visible = false;
            // 
            // PbRean
            // 
            this.PbRean.Image = ((System.Drawing.Image)(resources.GetObject("PbRean.Image")));
            this.PbRean.Location = new System.Drawing.Point(228, 190);
            this.PbRean.Name = "PbRean";
            this.PbRean.Size = new System.Drawing.Size(50, 53);
            this.PbRean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRean.TabIndex = 10;
            this.PbRean.TabStop = false;
            this.PbRean.Visible = false;
            // 
            // PingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(708, 534);
            this.Controls.Add(this.PbRean);
            this.Controls.Add(this.PbReini);
            this.Controls.Add(this.PbMenu);
            this.Controls.Add(this.PbSalir);
            this.Controls.Add(this.LbSalir);
            this.Controls.Add(this.LbSalirAlmenu);
            this.Controls.Add(this.LbReiniciar);
            this.Controls.Add(this.LbReanudar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PingPong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRean)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbReanudar;
        private System.Windows.Forms.Label LbReiniciar;
        private System.Windows.Forms.Label LbSalirAlmenu;
        private System.Windows.Forms.Label LbSalir;
        private System.Windows.Forms.PictureBox PbSalir;
        private System.Windows.Forms.PictureBox PbMenu;
        private System.Windows.Forms.PictureBox PbReini;
        private System.Windows.Forms.PictureBox PbRean;
    }
}