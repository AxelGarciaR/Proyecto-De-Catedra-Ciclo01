namespace PingPong_Generacion_de_figuras_Grupo3
{
    partial class PingPongMenuP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPongMenuP));
            this.label1 = new System.Windows.Forms.Label();
            this.lbIniciarPingPong = new System.Windows.Forms.Label();
            this.lbSalirAplicacion = new System.Windows.Forms.Label();
            this.PbSalir = new System.Windows.Forms.PictureBox();
            this.PbRean = new System.Windows.Forms.PictureBox();
            this.lbControles = new System.Windows.Forms.Label();
            this.PbReini = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡BIENVENIDO!";
            // 
            // lbIniciarPingPong
            // 
            this.lbIniciarPingPong.AutoSize = true;
            this.lbIniciarPingPong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIniciarPingPong.ForeColor = System.Drawing.Color.White;
            this.lbIniciarPingPong.Location = new System.Drawing.Point(283, 181);
            this.lbIniciarPingPong.Name = "lbIniciarPingPong";
            this.lbIniciarPingPong.Size = new System.Drawing.Size(76, 25);
            this.lbIniciarPingPong.TabIndex = 1;
            this.lbIniciarPingPong.Text = "Iniciar";
            this.lbIniciarPingPong.Click += new System.EventHandler(this.lbIniciarPingPong_Click);
            this.lbIniciarPingPong.MouseLeave += new System.EventHandler(this.lbReanudar_MouseLeave);
            this.lbIniciarPingPong.MouseHover += new System.EventHandler(this.lbReanudar_MouseHover);
            // 
            // lbSalirAplicacion
            // 
            this.lbSalirAplicacion.AutoSize = true;
            this.lbSalirAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalirAplicacion.ForeColor = System.Drawing.Color.White;
            this.lbSalirAplicacion.Location = new System.Drawing.Point(283, 315);
            this.lbSalirAplicacion.Name = "lbSalirAplicacion";
            this.lbSalirAplicacion.Size = new System.Drawing.Size(150, 25);
            this.lbSalirAplicacion.TabIndex = 4;
            this.lbSalirAplicacion.Text = "Salir al menu";
            this.lbSalirAplicacion.Click += new System.EventHandler(this.lbSalirAplicacion_Click);
            this.lbSalirAplicacion.MouseLeave += new System.EventHandler(this.LbSalir_MouseLeave);
            this.lbSalirAplicacion.MouseHover += new System.EventHandler(this.LbSalir_MouseHover);
            // 
            // PbSalir
            // 
            this.PbSalir.Image = ((System.Drawing.Image)(resources.GetObject("PbSalir.Image")));
            this.PbSalir.Location = new System.Drawing.Point(227, 302);
            this.PbSalir.Name = "PbSalir";
            this.PbSalir.Size = new System.Drawing.Size(50, 53);
            this.PbSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbSalir.TabIndex = 7;
            this.PbSalir.TabStop = false;
            this.PbSalir.Visible = false;
            this.PbSalir.Click += new System.EventHandler(this.PbSalir_Click);
            // 
            // PbRean
            // 
            this.PbRean.Image = ((System.Drawing.Image)(resources.GetObject("PbRean.Image")));
            this.PbRean.Location = new System.Drawing.Point(227, 169);
            this.PbRean.Name = "PbRean";
            this.PbRean.Size = new System.Drawing.Size(50, 53);
            this.PbRean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbRean.TabIndex = 10;
            this.PbRean.TabStop = false;
            this.PbRean.Visible = false;
            this.PbRean.Click += new System.EventHandler(this.PbRean_Click);
            // 
            // lbControles
            // 
            this.lbControles.AutoSize = true;
            this.lbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbControles.ForeColor = System.Drawing.Color.White;
            this.lbControles.Location = new System.Drawing.Point(283, 247);
            this.lbControles.Name = "lbControles";
            this.lbControles.Size = new System.Drawing.Size(113, 25);
            this.lbControles.TabIndex = 2;
            this.lbControles.Text = "Controles";
            this.lbControles.Click += new System.EventHandler(this.lbControles_Click);
            this.lbControles.MouseLeave += new System.EventHandler(this.LbReiniciar_MouseLeave);
            this.lbControles.MouseHover += new System.EventHandler(this.LbReiniciar_MouseHover);
            // 
            // PbReini
            // 
            this.PbReini.Image = ((System.Drawing.Image)(resources.GetObject("PbReini.Image")));
            this.PbReini.Location = new System.Drawing.Point(227, 235);
            this.PbReini.Name = "PbReini";
            this.PbReini.Size = new System.Drawing.Size(50, 53);
            this.PbReini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbReini.TabIndex = 9;
            this.PbReini.TabStop = false;
            this.PbReini.Visible = false;
            this.PbReini.Click += new System.EventHandler(this.PbReini_Click);
            // 
            // PingPongMenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(708, 534);
            this.Controls.Add(this.PbRean);
            this.Controls.Add(this.PbReini);
            this.Controls.Add(this.PbSalir);
            this.Controls.Add(this.lbSalirAplicacion);
            this.Controls.Add(this.lbControles);
            this.Controls.Add(this.lbIniciarPingPong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PingPongMenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPong";
            this.Load += new System.EventHandler(this.PingPongMenuP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbRean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbReini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIniciarPingPong;
        private System.Windows.Forms.Label lbSalirAplicacion;
        private System.Windows.Forms.PictureBox PbSalir;
        private System.Windows.Forms.PictureBox PbRean;
        private System.Windows.Forms.Label lbControles;
        private System.Windows.Forms.PictureBox PbReini;
    }
}