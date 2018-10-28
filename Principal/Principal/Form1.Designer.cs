namespace Principal
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
            this.txt_lexico = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbl_lexico = new System.Windows.Forms.ListView();
            this.Descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TOKEN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_archivo = new System.Windows.Forms.TextBox();
            this.lbl_archivo_seleccionado = new System.Windows.Forms.Label();
            this.btn_archivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_lexico
            // 
            this.txt_lexico.Location = new System.Drawing.Point(612, 342);
            this.txt_lexico.Multiline = true;
            this.txt_lexico.Name = "txt_lexico";
            this.txt_lexico.Size = new System.Drawing.Size(301, 197);
            this.txt_lexico.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(571, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Analisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbl_lexico
            // 
            this.tbl_lexico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Descripcion,
            this.TOKEN});
            this.tbl_lexico.FullRowSelect = true;
            this.tbl_lexico.GridLines = true;
            this.tbl_lexico.Location = new System.Drawing.Point(22, 337);
            this.tbl_lexico.Name = "tbl_lexico";
            this.tbl_lexico.Size = new System.Drawing.Size(573, 202);
            this.tbl_lexico.TabIndex = 9;
            this.tbl_lexico.UseCompatibleStateImageBehavior = false;
            this.tbl_lexico.View = System.Windows.Forms.View.Details;
            // 
            // Descripcion
            // 
            this.Descripcion.Text = "Descripcion";
            this.Descripcion.Width = 436;
            // 
            // TOKEN
            // 
            this.TOKEN.Text = "TOKEN";
            this.TOKEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TOKEN.Width = 112;
            // 
            // txt_archivo
            // 
            this.txt_archivo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_archivo.ForeColor = System.Drawing.Color.ForestGreen;
            this.txt_archivo.Location = new System.Drawing.Point(22, 112);
            this.txt_archivo.Multiline = true;
            this.txt_archivo.Name = "txt_archivo";
            this.txt_archivo.Size = new System.Drawing.Size(573, 202);
            this.txt_archivo.TabIndex = 8;
            // 
            // lbl_archivo_seleccionado
            // 
            this.lbl_archivo_seleccionado.AutoSize = true;
            this.lbl_archivo_seleccionado.Location = new System.Drawing.Point(173, 28);
            this.lbl_archivo_seleccionado.Name = "lbl_archivo_seleccionado";
            this.lbl_archivo_seleccionado.Size = new System.Drawing.Size(250, 17);
            this.lbl_archivo_seleccionado.TabIndex = 7;
            this.lbl_archivo_seleccionado.Text = "Archivo seleccionado                           ";
            // 
            // btn_archivo
            // 
            this.btn_archivo.Location = new System.Drawing.Point(22, 18);
            this.btn_archivo.Name = "btn_archivo";
            this.btn_archivo.Size = new System.Drawing.Size(145, 37);
            this.btn_archivo.TabIndex = 6;
            this.btn_archivo.Text = "Seleccionar archivo";
            this.btn_archivo.UseVisualStyleBackColor = true;
            this.btn_archivo.Click += new System.EventHandler(this.btn_archivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 596);
            this.Controls.Add(this.txt_lexico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbl_lexico);
            this.Controls.Add(this.txt_archivo);
            this.Controls.Add(this.lbl_archivo_seleccionado);
            this.Controls.Add(this.btn_archivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lexico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView tbl_lexico;
        private System.Windows.Forms.ColumnHeader Descripcion;
        private System.Windows.Forms.ColumnHeader TOKEN;
        private System.Windows.Forms.TextBox txt_archivo;
        private System.Windows.Forms.Label lbl_archivo_seleccionado;
        private System.Windows.Forms.Button btn_archivo;
    }
}

