namespace Tp_Dorrego_Futbol
{
    partial class Menu_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.Icono_Maximizar = new System.Windows.Forms.PictureBox();
            this.Icono_Minimizar = new System.Windows.Forms.PictureBox();
            this.Icono_Cerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.resaturar_icono = new System.Windows.Forms.PictureBox();
            this.Menu_vertical = new System.Windows.Forms.FlowLayoutPanel();
            this.Foto_Dorrego = new System.Windows.Forms.PictureBox();
            this.Administración_boton = new System.Windows.Forms.Button();
            this.panel_Contenedor = new System.Windows.Forms.Panel();
            this.panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resaturar_icono)).BeginInit();
            this.Menu_vertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Dorrego)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Menu
            // 
            this.panel_Menu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Menu.Controls.Add(this.resaturar_icono);
            this.panel_Menu.Controls.Add(this.Icono_Maximizar);
            this.panel_Menu.Controls.Add(this.Icono_Cerrar);
            this.panel_Menu.Controls.Add(this.Icono_Minimizar);
            this.panel_Menu.Controls.Add(this.pictureBox1);
            this.panel_Menu.Controls.Add(this.label1);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Menu.Location = new System.Drawing.Point(250, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(1320, 50);
            this.panel_Menu.TabIndex = 0;
            this.panel_Menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Menu_MouseDown);
            // 
            // Icono_Maximizar
            // 
            this.Icono_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icono_Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Maximizar.Image")));
            this.Icono_Maximizar.Location = new System.Drawing.Point(1231, 9);
            this.Icono_Maximizar.Name = "Icono_Maximizar";
            this.Icono_Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Icono_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Maximizar.TabIndex = 4;
            this.Icono_Maximizar.TabStop = false;
            this.Icono_Maximizar.Click += new System.EventHandler(this.Icono_Maximizar_Click);
            // 
            // Icono_Minimizar
            // 
            this.Icono_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icono_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Minimizar.Image")));
            this.Icono_Minimizar.Location = new System.Drawing.Point(1184, 9);
            this.Icono_Minimizar.Name = "Icono_Minimizar";
            this.Icono_Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Icono_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Minimizar.TabIndex = 3;
            this.Icono_Minimizar.TabStop = false;
            this.Icono_Minimizar.Click += new System.EventHandler(this.Icono_Minimizar_Click);
            // 
            // Icono_Cerrar
            // 
            this.Icono_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Icono_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icono_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Icono_Cerrar.Image")));
            this.Icono_Cerrar.Location = new System.Drawing.Point(1278, 12);
            this.Icono_Cerrar.Name = "Icono_Cerrar";
            this.Icono_Cerrar.Size = new System.Drawing.Size(25, 25);
            this.Icono_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icono_Cerrar.TabIndex = 0;
            this.Icono_Cerrar.TabStop = false;
            this.Icono_Cerrar.Click += new System.EventHandler(this.Icono_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menú";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // resaturar_icono
            // 
            this.resaturar_icono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resaturar_icono.Image = ((System.Drawing.Image)(resources.GetObject("resaturar_icono.Image")));
            this.resaturar_icono.Location = new System.Drawing.Point(1231, 9);
            this.resaturar_icono.Name = "resaturar_icono";
            this.resaturar_icono.Size = new System.Drawing.Size(30, 30);
            this.resaturar_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resaturar_icono.TabIndex = 5;
            this.resaturar_icono.TabStop = false;
            this.resaturar_icono.Visible = false;
            this.resaturar_icono.Click += new System.EventHandler(this.resaturar_icono_Click);
            // 
            // Menu_vertical
            // 
            this.Menu_vertical.BackColor = System.Drawing.Color.Black;
            this.Menu_vertical.Controls.Add(this.Foto_Dorrego);
            this.Menu_vertical.Controls.Add(this.Administración_boton);
            this.Menu_vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_vertical.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Menu_vertical.Location = new System.Drawing.Point(0, 0);
            this.Menu_vertical.Name = "Menu_vertical";
            this.Menu_vertical.Size = new System.Drawing.Size(250, 748);
            this.Menu_vertical.TabIndex = 1;
            this.Menu_vertical.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_vertical_Paint);
            // 
            // Foto_Dorrego
            // 
            this.Foto_Dorrego.Image = ((System.Drawing.Image)(resources.GetObject("Foto_Dorrego.Image")));
            this.Foto_Dorrego.Location = new System.Drawing.Point(3, 3);
            this.Foto_Dorrego.Name = "Foto_Dorrego";
            this.Foto_Dorrego.Size = new System.Drawing.Size(247, 75);
            this.Foto_Dorrego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto_Dorrego.TabIndex = 4;
            this.Foto_Dorrego.TabStop = false;
            // 
            // Administración_boton
            // 
            this.Administración_boton.BackColor = System.Drawing.Color.Black;
            this.Administración_boton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Administración_boton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Administración_boton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Administración_boton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administración_boton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Administración_boton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Administración_boton.Location = new System.Drawing.Point(3, 84);
            this.Administración_boton.Name = "Administración_boton";
            this.Administración_boton.Size = new System.Drawing.Size(250, 54);
            this.Administración_boton.TabIndex = 2;
            this.Administración_boton.Text = " Administración";
            this.Administración_boton.UseVisualStyleBackColor = false;
            this.Administración_boton.Click += new System.EventHandler(this.Administración_boton_Click);
            // 
            // panel_Contenedor
            // 
            this.panel_Contenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenedor.Location = new System.Drawing.Point(250, 0);
            this.panel_Contenedor.Name = "panel_Contenedor";
            this.panel_Contenedor.Size = new System.Drawing.Size(1320, 748);
            this.panel_Contenedor.TabIndex = 2;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1570, 748);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.panel_Contenedor);
            this.Controls.Add(this.Menu_vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.Text = "Dorrego Sist.";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icono_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resaturar_icono)).EndInit();
            this.Menu_vertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Foto_Dorrego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel Menu_vertical;
        private System.Windows.Forms.Button Administración_boton;
        private System.Windows.Forms.Panel panel_Contenedor;
        private System.Windows.Forms.PictureBox Foto_Dorrego;
        private System.Windows.Forms.PictureBox Icono_Cerrar;
        private System.Windows.Forms.PictureBox Icono_Maximizar;
        private System.Windows.Forms.PictureBox Icono_Minimizar;
        private System.Windows.Forms.PictureBox resaturar_icono;
    }
}

