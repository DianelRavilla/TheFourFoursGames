namespace PAII_Proyecto5
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MENU_LEFTWRAPPER = new System.Windows.Forms.Panel();
            this.SUBTITULO = new System.Windows.Forms.Label();
            this.TITULO = new System.Windows.Forms.Label();
            this.btnNuevaPartida = new System.Windows.Forms.Label();
            this.btnCreditos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Label();
            this.Opcion1 = new System.Windows.Forms.PictureBox();
            this.PANEL_CREDITOS = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MENU_LEFTWRAPPER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opcion1)).BeginInit();
            this.PANEL_CREDITOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_LEFTWRAPPER
            // 
            this.MENU_LEFTWRAPPER.BackColor = System.Drawing.Color.Black;
            this.MENU_LEFTWRAPPER.Controls.Add(this.SUBTITULO);
            this.MENU_LEFTWRAPPER.Controls.Add(this.TITULO);
            this.MENU_LEFTWRAPPER.Controls.Add(this.btnNuevaPartida);
            this.MENU_LEFTWRAPPER.Controls.Add(this.btnCreditos);
            this.MENU_LEFTWRAPPER.Controls.Add(this.btnSalir);
            this.MENU_LEFTWRAPPER.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU_LEFTWRAPPER.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENU_LEFTWRAPPER.Location = new System.Drawing.Point(0, 0);
            this.MENU_LEFTWRAPPER.Name = "MENU_LEFTWRAPPER";
            this.MENU_LEFTWRAPPER.Size = new System.Drawing.Size(650, 700);
            this.MENU_LEFTWRAPPER.TabIndex = 0;
            // 
            // SUBTITULO
            // 
            this.SUBTITULO.AutoSize = true;
            this.SUBTITULO.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBTITULO.ForeColor = System.Drawing.Color.White;
            this.SUBTITULO.Location = new System.Drawing.Point(155, 130);
            this.SUBTITULO.Name = "SUBTITULO";
            this.SUBTITULO.Size = new System.Drawing.Size(327, 29);
            this.SUBTITULO.TabIndex = 6;
            this.SUBTITULO.Text = "El juego de los cuatro cuatros";
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Kristen ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TITULO.ForeColor = System.Drawing.Color.White;
            this.TITULO.Location = new System.Drawing.Point(63, 42);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(500, 88);
            this.TITULO.TabIndex = 5;
            this.TITULO.Text = "THE 4-FOURS";
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.AutoSize = true;
            this.btnNuevaPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevaPartida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaPartida.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaPartida.ForeColor = System.Drawing.Color.White;
            this.btnNuevaPartida.Location = new System.Drawing.Point(128, 210);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(399, 79);
            this.btnNuevaPartida.TabIndex = 2;
            this.btnNuevaPartida.Text = "NUEVA PARTIDA";
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            this.btnNuevaPartida.MouseLeave += new System.EventHandler(this.btnNuevaPartida_MouseLeave);
            this.btnNuevaPartida.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnNuevaPartida_MouseMove);
            // 
            // btnCreditos
            // 
            this.btnCreditos.AutoSize = true;
            this.btnCreditos.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreditos.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditos.ForeColor = System.Drawing.Color.White;
            this.btnCreditos.Location = new System.Drawing.Point(190, 295);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(262, 79);
            this.btnCreditos.TabIndex = 3;
            this.btnCreditos.Text = "CREDITOS";
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            this.btnCreditos.MouseLeave += new System.EventHandler(this.btnOpciones_MouseLeave);
            this.btnCreditos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnOpciones_MouseMove);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Poppins", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(235, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(158, 79);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseDown);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSalir_MouseMove);
            // 
            // Opcion1
            // 
            this.Opcion1.BackgroundImage = global::PAII_Proyecto5.Properties.Resources.MENU_RIGHTWRAPPER_ANIMATION;
            this.Opcion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Opcion1.Image = global::PAII_Proyecto5.Properties.Resources.MENU_RIGHTWRAPPER_ANIMATION;
            this.Opcion1.Location = new System.Drawing.Point(650, 0);
            this.Opcion1.Name = "Opcion1";
            this.Opcion1.Size = new System.Drawing.Size(650, 700);
            this.Opcion1.TabIndex = 1;
            this.Opcion1.TabStop = false;
            // 
            // PANEL_CREDITOS
            // 
            this.PANEL_CREDITOS.BackColor = System.Drawing.Color.Black;
            this.PANEL_CREDITOS.BackgroundImage = global::PAII_Proyecto5.Properties.Resources.LIBRO_FLOR;
            this.PANEL_CREDITOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PANEL_CREDITOS.Controls.Add(this.label4);
            this.PANEL_CREDITOS.Controls.Add(this.label3);
            this.PANEL_CREDITOS.Controls.Add(this.label2);
            this.PANEL_CREDITOS.Controls.Add(this.label1);
            this.PANEL_CREDITOS.Controls.Add(this.pictureBox1);
            this.PANEL_CREDITOS.Location = new System.Drawing.Point(701, 42);
            this.PANEL_CREDITOS.Name = "PANEL_CREDITOS";
            this.PANEL_CREDITOS.Size = new System.Drawing.Size(541, 578);
            this.PANEL_CREDITOS.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(202, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "2019-2020";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(116, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "cdvillalbar@est.emi.edu.bo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "EST:. CARLOS DANIEL VILLALBA RADA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESCUELA MILITAR DE INGENIERIA \r\nUNIDAD ACDEMICA SANTA CRUZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PAII_Proyecto5.Properties.Resources.Logo_EMI;
            this.pictureBox1.Location = new System.Drawing.Point(122, 432);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.PANEL_CREDITOS);
            this.Controls.Add(this.Opcion1);
            this.Controls.Add(this.MENU_LEFTWRAPPER);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MENU_LEFTWRAPPER.ResumeLayout(false);
            this.MENU_LEFTWRAPPER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Opcion1)).EndInit();
            this.PANEL_CREDITOS.ResumeLayout(false);
            this.PANEL_CREDITOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MENU_LEFTWRAPPER;
        private System.Windows.Forms.Label btnSalir;
        private System.Windows.Forms.Label btnCreditos;
        private System.Windows.Forms.Label btnNuevaPartida;
        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.PictureBox Opcion1;
        private System.Windows.Forms.Label SUBTITULO;
        private System.Windows.Forms.Panel PANEL_CREDITOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

