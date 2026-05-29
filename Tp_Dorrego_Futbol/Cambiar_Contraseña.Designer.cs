namespace Tp_Dorrego_Futbol
{
    partial class Cambiar_Contraseña
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
            this.btn_CambiarContraseña = new System.Windows.Forms.Button();
            this.txtbActual = new System.Windows.Forms.TextBox();
            this.txtbNueva = new System.Windows.Forms.TextBox();
            this.txtbRepetir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_CambiarContraseña
            // 
            this.btn_CambiarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CambiarContraseña.Location = new System.Drawing.Point(598, 407);
            this.btn_CambiarContraseña.Name = "btn_CambiarContraseña";
            this.btn_CambiarContraseña.Size = new System.Drawing.Size(176, 38);
            this.btn_CambiarContraseña.TabIndex = 0;
            this.btn_CambiarContraseña.Text = "Cambiar Contraseña";
            this.btn_CambiarContraseña.UseVisualStyleBackColor = true;
            this.btn_CambiarContraseña.Click += new System.EventHandler(this.btn_CambiarContraseña_Click);
            // 
            // txtbActual
            // 
            this.txtbActual.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbActual.Location = new System.Drawing.Point(598, 202);
            this.txtbActual.Name = "txtbActual";
            this.txtbActual.Size = new System.Drawing.Size(176, 29);
            this.txtbActual.TabIndex = 1;
            // 
            // txtbNueva
            // 
            this.txtbNueva.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbNueva.Location = new System.Drawing.Point(598, 266);
            this.txtbNueva.Name = "txtbNueva";
            this.txtbNueva.Size = new System.Drawing.Size(176, 29);
            this.txtbNueva.TabIndex = 2;
            // 
            // txtbRepetir
            // 
            this.txtbRepetir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtbRepetir.Location = new System.Drawing.Point(598, 334);
            this.txtbRepetir.Name = "txtbRepetir";
            this.txtbRepetir.Size = new System.Drawing.Size(176, 29);
            this.txtbRepetir.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contraseña Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña Nueva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar Contraseña ";
            // 
            // Cambiar_Contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1320, 698);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbRepetir);
            this.Controls.Add(this.txtbNueva);
            this.Controls.Add(this.txtbActual);
            this.Controls.Add(this.btn_CambiarContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cambiar_Contraseña";
            this.Text = "Cambiar_Contraseña";
            this.Load += new System.EventHandler(this.Cambiar_Contraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CambiarContraseña;
        private System.Windows.Forms.TextBox txtbActual;
        private System.Windows.Forms.TextBox txtbNueva;
        private System.Windows.Forms.TextBox txtbRepetir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}