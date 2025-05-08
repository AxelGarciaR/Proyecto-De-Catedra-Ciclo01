namespace PingPong_Generacion_de_figuras_Grupo3.Formularios
{
    partial class PingPongGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PingPongGame));
            this.timerPingPong = new System.Windows.Forms.Timer(this.components);
            this.pbxJugador1 = new System.Windows.Forms.PictureBox();
            this.pbxJugador2 = new System.Windows.Forms.PictureBox();
            this.pbxPelota = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbPuntaje2 = new System.Windows.Forms.Label();
            this.lbPuntaje1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // timerPingPong
            // 
            this.timerPingPong.Tick += new System.EventHandler(this.timerPingPong_Tick);
            // 
            // pbxJugador1
            // 
            this.pbxJugador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(32)))), ((int)(((byte)(87)))));
            this.pbxJugador1.Location = new System.Drawing.Point(12, 150);
            this.pbxJugador1.Name = "pbxJugador1";
            this.pbxJugador1.Size = new System.Drawing.Size(20, 100);
            this.pbxJugador1.TabIndex = 0;
            this.pbxJugador1.TabStop = false;
            // 
            // pbxJugador2
            // 
            this.pbxJugador2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(32)))), ((int)(((byte)(87)))));
            this.pbxJugador2.Location = new System.Drawing.Point(618, 150);
            this.pbxJugador2.Name = "pbxJugador2";
            this.pbxJugador2.Size = new System.Drawing.Size(20, 100);
            this.pbxJugador2.TabIndex = 1;
            this.pbxJugador2.TabStop = false;
            this.pbxJugador2.Click += new System.EventHandler(this.pbxJugador2_Click);
            // 
            // pbxPelota
            // 
            this.pbxPelota.BackColor = System.Drawing.Color.Transparent;
            this.pbxPelota.Image = ((System.Drawing.Image)(resources.GetObject("pbxPelota.Image")));
            this.pbxPelota.Location = new System.Drawing.Point(300, 176);
            this.pbxPelota.Name = "pbxPelota";
            this.pbxPelota.Size = new System.Drawing.Size(50, 50);
            this.pbxPelota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPelota.TabIndex = 2;
            this.pbxPelota.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Location = new System.Drawing.Point(320, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(320, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox4.Location = new System.Drawing.Point(320, 288);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 50);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Location = new System.Drawing.Point(320, 388);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 50);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.Location = new System.Drawing.Point(320, 200);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 50);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // lbPuntaje2
            // 
            this.lbPuntaje2.AutoSize = true;
            this.lbPuntaje2.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntaje2.Font = new System.Drawing.Font("Monocraft", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPuntaje2.Location = new System.Drawing.Point(389, 12);
            this.lbPuntaje2.Name = "lbPuntaje2";
            this.lbPuntaje2.Size = new System.Drawing.Size(40, 43);
            this.lbPuntaje2.TabIndex = 11;
            this.lbPuntaje2.Text = "0";
            // 
            // lbPuntaje1
            // 
            this.lbPuntaje1.AutoSize = true;
            this.lbPuntaje1.BackColor = System.Drawing.Color.Transparent;
            this.lbPuntaje1.Font = new System.Drawing.Font("Monocraft", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntaje1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbPuntaje1.Location = new System.Drawing.Point(226, 12);
            this.lbPuntaje1.Name = "lbPuntaje1";
            this.lbPuntaje1.Size = new System.Drawing.Size(40, 43);
            this.lbPuntaje1.TabIndex = 12;
            this.lbPuntaje1.Text = "0";
            // 
            // PingPongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(650, 450);
            this.Controls.Add(this.lbPuntaje1);
            this.Controls.Add(this.lbPuntaje2);
            this.Controls.Add(this.pbxPelota);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxJugador2);
            this.Controls.Add(this.pbxJugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PingPongGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PingPongGame";
            this.Load += new System.EventHandler(this.PingPongGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxJugador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerPingPong;
        private System.Windows.Forms.PictureBox pbxJugador1;
        private System.Windows.Forms.PictureBox pbxJugador2;
        private System.Windows.Forms.PictureBox pbxPelota;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbPuntaje2;
        private System.Windows.Forms.Label lbPuntaje1;
    }
}