namespace form_ejercicio12_seleccion_de_pais_lista
{
    partial class Form1
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
            this.cbo_paises = new System.Windows.Forms.ComboBox();
            this.lbl_list = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.lbl_indice = new System.Windows.Forms.Label();
            this.txt_informacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbo_paises
            // 
            this.cbo_paises.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_paises.FormattingEnabled = true;
            this.cbo_paises.Location = new System.Drawing.Point(12, 108);
            this.cbo_paises.Name = "cbo_paises";
            this.cbo_paises.Size = new System.Drawing.Size(310, 28);
            this.cbo_paises.TabIndex = 0;
            this.cbo_paises.SelectedIndexChanged += new System.EventHandler(this.cbo_paises_SelectedIndexChanged);
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list.Location = new System.Drawing.Point(62, 53);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(182, 25);
            this.lbl_list.TabIndex = 2;
            this.lbl_list.Text = "Selecciona un pais:";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(525, 53);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(249, 25);
            this.lbl_info.TabIndex = 3;
            this.lbl_info.Text = "Informacin acerca del pais:";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_cerrar.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.Location = new System.Drawing.Point(94, 348);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(150, 46);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_indice
            // 
            this.lbl_indice.AutoSize = true;
            this.lbl_indice.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_indice.Location = new System.Drawing.Point(155, 196);
            this.lbl_indice.Name = "lbl_indice";
            this.lbl_indice.Size = new System.Drawing.Size(0, 25);
            this.lbl_indice.TabIndex = 5;
            // 
            // txt_informacion
            // 
            this.txt_informacion.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_informacion.Location = new System.Drawing.Point(357, 93);
            this.txt_informacion.Multiline = true;
            this.txt_informacion.Name = "txt_informacion";
            this.txt_informacion.Size = new System.Drawing.Size(597, 345);
            this.txt_informacion.TabIndex = 6;
            this.txt_informacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.txt_informacion);
            this.Controls.Add(this.lbl_indice);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.cbo_paises);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_paises;
        private System.Windows.Forms.Label lbl_list;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label lbl_indice;
        private System.Windows.Forms.TextBox txt_informacion;
    }
}

