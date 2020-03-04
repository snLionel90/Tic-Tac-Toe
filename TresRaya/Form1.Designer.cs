namespace TresEnRaya
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirPorPatasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIUDAXDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mASINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.labelTxt = new System.Windows.Forms.Label();
            this.labelTurnoJ1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cojones = new System.Windows.Forms.Label();
            this.Informacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.aIUDAXDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJuegoToolStripMenuItem,
            this.salirPorPatasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoJuegoToolStripMenuItem
            // 
            this.nuevoJuegoToolStripMenuItem.Name = "nuevoJuegoToolStripMenuItem";
            this.nuevoJuegoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevoJuegoToolStripMenuItem.Text = "Nuevo Juego";
            this.nuevoJuegoToolStripMenuItem.Click += new System.EventHandler(this.NuevoJuegoToolStripMenuItem_Click);
            // 
            // salirPorPatasToolStripMenuItem
            // 
            this.salirPorPatasToolStripMenuItem.Name = "salirPorPatasToolStripMenuItem";
            this.salirPorPatasToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirPorPatasToolStripMenuItem.Text = "Salir por patas";
            this.salirPorPatasToolStripMenuItem.Click += new System.EventHandler(this.SalirPorPatasToolStripMenuItem_Click);
            // 
            // aIUDAXDToolStripMenuItem
            // 
            this.aIUDAXDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mASINFOToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.aIUDAXDToolStripMenuItem.Name = "aIUDAXDToolStripMenuItem";
            this.aIUDAXDToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.aIUDAXDToolStripMenuItem.Text = "ayuda ";
            // 
            // mASINFOToolStripMenuItem
            // 
            this.mASINFOToolStripMenuItem.Name = "mASINFOToolStripMenuItem";
            this.mASINFOToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.mASINFOToolStripMenuItem.Text = "mas info";
            this.mASINFOToolStripMenuItem.Click += new System.EventHandler(this.mASINFOToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(50, 51);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(125, 100);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.button_click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(200, 51);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(125, 100);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(355, 51);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(125, 100);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(50, 173);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(125, 100);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(200, 173);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(125, 100);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(355, 173);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(125, 100);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(50, 294);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(125, 100);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(200, 294);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(125, 100);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(355, 294);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(125, 100);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            // 
            // labelTxt
            // 
            this.labelTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTxt.Location = new System.Drawing.Point(90, 478);
            this.labelTxt.Name = "labelTxt";
            this.labelTxt.Size = new System.Drawing.Size(216, 43);
            this.labelTxt.TabIndex = 10;
            this.labelTxt.UseMnemonic = false;
            // 
            // labelTurnoJ1
            // 
            this.labelTurnoJ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTurnoJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurnoJ1.Location = new System.Drawing.Point(91, 414);
            this.labelTurnoJ1.Name = "labelTurnoJ1";
            this.labelTurnoJ1.Size = new System.Drawing.Size(215, 40);
            this.labelTurnoJ1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Turnos";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 121);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nota:\r\nX -->Jugador 1\r\nO ---> jugador 2";
            // 
            // cojones
            // 
            this.cojones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cojones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cojones.Location = new System.Drawing.Point(514, 182);
            this.cojones.Name = "cojones";
            this.cojones.Size = new System.Drawing.Size(100, 23);
            this.cojones.TabIndex = 15;
            // 
            // Informacion
            // 
            this.Informacion.AllowDrop = true;
            this.Informacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Informacion.Location = new System.Drawing.Point(342, 414);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(282, 107);
            this.Informacion.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "(C)Lionel Sanchez";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Informacion);
            this.Controls.Add(this.cojones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTurnoJ1);
            this.Controls.Add(this.labelTxt);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirPorPatasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIUDAXDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mASINFOToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Label labelTxt;
        private System.Windows.Forms.Label labelTurnoJ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem nuevoJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label cojones;
        private System.Windows.Forms.Label Informacion;
        private System.Windows.Forms.Label label3;
    }
}

