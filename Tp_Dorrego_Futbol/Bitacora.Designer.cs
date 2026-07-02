namespace Tp_Dorrego_Futbol
{
    partial class Bitacora
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
            this.dataGridViewBitacora = new System.Windows.Forms.DataGridView();
            this.label_B1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_B2 = new System.Windows.Forms.Label();
            this.label_B3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_B9 = new System.Windows.Forms.Label();
            this.label_B6 = new System.Windows.Forms.Label();
            this.dateFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dateFechadesde = new System.Windows.Forms.DateTimePicker();
            this.label_B5 = new System.Windows.Forms.Label();
            this.label_B8 = new System.Windows.Forms.Label();
            this.label_B7 = new System.Windows.Forms.Label();
            this.label_B4 = new System.Windows.Forms.Label();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbLogin = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAplicarBitacora = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBitacora
            // 
            this.dataGridViewBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBitacora.Location = new System.Drawing.Point(97, 112);
            this.dataGridViewBitacora.Name = "dataGridViewBitacora";
            this.dataGridViewBitacora.Size = new System.Drawing.Size(982, 274);
            this.dataGridViewBitacora.TabIndex = 0;
            this.dataGridViewBitacora.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBitacora_CellClick);
            this.dataGridViewBitacora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBitacora_CellContentClick);
            // 
            // label_B1
            // 
            this.label_B1.AutoSize = true;
            this.label_B1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B1.Location = new System.Drawing.Point(92, 69);
            this.label_B1.Name = "label_B1";
            this.label_B1.Size = new System.Drawing.Size(195, 30);
            this.label_B1.TabIndex = 1;
            this.label_B1.Text = "Bitacora de eventos";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.label_B2);
            this.groupBox3.Controls.Add(this.label_B3);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(97, 404);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(982, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label_B2
            // 
            this.label_B2.AutoSize = true;
            this.label_B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B2.Location = new System.Drawing.Point(105, 47);
            this.label_B2.Name = "label_B2";
            this.label_B2.Size = new System.Drawing.Size(65, 16);
            this.label_B2.TabIndex = 8;
            this.label_B2.Text = "Nombre : ";
            // 
            // label_B3
            // 
            this.label_B3.AutoSize = true;
            this.label_B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B3.Location = new System.Drawing.Point(558, 44);
            this.label_B3.Name = "label_B3";
            this.label_B3.Size = new System.Drawing.Size(63, 16);
            this.label_B3.TabIndex = 7;
            this.label_B3.Text = "Apellido :";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(647, 44);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(182, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 21);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.Text = "Datos del Usuario";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox4.Controls.Add(this.label_B9);
            this.groupBox4.Controls.Add(this.label_B6);
            this.groupBox4.Controls.Add(this.dateFechaHasta);
            this.groupBox4.Controls.Add(this.dateFechadesde);
            this.groupBox4.Controls.Add(this.label_B5);
            this.groupBox4.Controls.Add(this.label_B8);
            this.groupBox4.Controls.Add(this.label_B7);
            this.groupBox4.Controls.Add(this.label_B4);
            this.groupBox4.Controls.Add(this.cmbCriticidad);
            this.groupBox4.Controls.Add(this.cmbEvento);
            this.groupBox4.Controls.Add(this.cmbModulo);
            this.groupBox4.Controls.Add(this.cmbLogin);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(97, 512);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(982, 148);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label_B9
            // 
            this.label_B9.AutoSize = true;
            this.label_B9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B9.Location = new System.Drawing.Point(599, 110);
            this.label_B9.Name = "label_B9";
            this.label_B9.Size = new System.Drawing.Size(70, 16);
            this.label_B9.TabIndex = 17;
            this.label_B9.Text = "Fecha fin : ";
            // 
            // label_B6
            // 
            this.label_B6.AutoSize = true;
            this.label_B6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B6.Location = new System.Drawing.Point(584, 59);
            this.label_B6.Name = "label_B6";
            this.label_B6.Size = new System.Drawing.Size(85, 16);
            this.label_B6.TabIndex = 16;
            this.label_B6.Text = "Fecha inicio :";
            // 
            // dateFechaHasta
            // 
            this.dateFechaHasta.Location = new System.Drawing.Point(691, 106);
            this.dateFechaHasta.Name = "dateFechaHasta";
            this.dateFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dateFechaHasta.TabIndex = 15;
            this.dateFechaHasta.Value = new System.DateTime(2026, 6, 16, 19, 4, 34, 0);
            // 
            // dateFechadesde
            // 
            this.dateFechadesde.Location = new System.Drawing.Point(691, 56);
            this.dateFechadesde.Name = "dateFechadesde";
            this.dateFechadesde.Size = new System.Drawing.Size(200, 20);
            this.dateFechadesde.TabIndex = 14;
            this.dateFechadesde.Value = new System.DateTime(2026, 6, 16, 19, 4, 34, 0);
            // 
            // label_B5
            // 
            this.label_B5.AutoSize = true;
            this.label_B5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B5.Location = new System.Drawing.Point(293, 59);
            this.label_B5.Name = "label_B5";
            this.label_B5.Size = new System.Drawing.Size(69, 16);
            this.label_B5.TabIndex = 13;
            this.label_B5.Text = "Criticidad :";
            // 
            // label_B8
            // 
            this.label_B8.AutoSize = true;
            this.label_B8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B8.Location = new System.Drawing.Point(307, 111);
            this.label_B8.Name = "label_B8";
            this.label_B8.Size = new System.Drawing.Size(55, 16);
            this.label_B8.TabIndex = 12;
            this.label_B8.Text = "Evento :";
            // 
            // label_B7
            // 
            this.label_B7.AutoSize = true;
            this.label_B7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B7.Location = new System.Drawing.Point(20, 110);
            this.label_B7.Name = "label_B7";
            this.label_B7.Size = new System.Drawing.Size(58, 16);
            this.label_B7.TabIndex = 11;
            this.label_B7.Text = "Modulo :";
            // 
            // label_B4
            // 
            this.label_B4.AutoSize = true;
            this.label_B4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B4.Location = new System.Drawing.Point(32, 59);
            this.label_B4.Name = "label_B4";
            this.label_B4.Size = new System.Drawing.Size(46, 16);
            this.label_B4.TabIndex = 10;
            this.label_B4.Text = "Login :";
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(371, 54);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCriticidad.TabIndex = 9;
            // 
            // cmbEvento
            // 
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Location = new System.Drawing.Point(371, 110);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(121, 21);
            this.cmbEvento.TabIndex = 8;
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(92, 110);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(121, 21);
            this.cmbModulo.TabIndex = 7;
            // 
            // cmbLogin
            // 
            this.cmbLogin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogin.FormattingEnabled = true;
            this.cmbLogin.Location = new System.Drawing.Point(92, 54);
            this.cmbLogin.Name = "cmbLogin";
            this.cmbLogin.Size = new System.Drawing.Size(121, 21);
            this.cmbLogin.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(53, 21);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.Text = "Filtros";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(279, 673);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(105, 34);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAplicarBitacora
            // 
            this.btnAplicarBitacora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarBitacora.Location = new System.Drawing.Point(523, 673);
            this.btnAplicarBitacora.Name = "btnAplicarBitacora";
            this.btnAplicarBitacora.Size = new System.Drawing.Size(105, 34);
            this.btnAplicarBitacora.TabIndex = 5;
            this.btnAplicarBitacora.Text = "Aplicar";
            this.btnAplicarBitacora.UseVisualStyleBackColor = true;
            this.btnAplicarBitacora.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(767, 673);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 34);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1309, 732);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAplicarBitacora);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label_B1);
            this.Controls.Add(this.dataGridViewBitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bitacora";
            this.Text = "Bitacora";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bitacora_FormClosed);
            this.Load += new System.EventHandler(this.Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBitacora)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBitacora;
        private System.Windows.Forms.Label label_B1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label groupBox1;
        private System.Windows.Forms.Label label_B5;
        private System.Windows.Forms.Label label_B8;
        private System.Windows.Forms.Label label_B7;
        private System.Windows.Forms.Label label_B4;
        private System.Windows.Forms.ComboBox cmbCriticidad;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbLogin;
        private System.Windows.Forms.Label groupBox2;
        private System.Windows.Forms.Label label_B2;
        private System.Windows.Forms.Label label_B3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label_B9;
        private System.Windows.Forms.Label label_B6;
        private System.Windows.Forms.DateTimePicker dateFechaHasta;
        private System.Windows.Forms.DateTimePicker dateFechadesde;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicarBitacora;
        private System.Windows.Forms.Button btnImprimir;
    }
}