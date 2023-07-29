namespace RisxPert
{
    partial class Fase1
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Grabar = new System.Windows.Forms.Button();
            this.Analista = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Tabla1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ffuncion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sustitucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profundidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agresion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vulnerabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(47, 56);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(134, 39);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Grabar
            // 
            this.Grabar.Location = new System.Drawing.Point(47, 101);
            this.Grabar.Name = "Grabar";
            this.Grabar.Size = new System.Drawing.Size(134, 39);
            this.Grabar.TabIndex = 0;
            this.Grabar.Text = "Grabar";
            this.Grabar.UseVisualStyleBackColor = true;
            this.Grabar.Click += new System.EventHandler(this.Grabar_Click);
            // 
            // Analista
            // 
            this.Analista.AutoSize = true;
            this.Analista.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analista.Location = new System.Drawing.Point(1059, 9);
            this.Analista.Name = "Analista";
            this.Analista.Size = new System.Drawing.Size(95, 28);
            this.Analista.TabIndex = 2;
            this.Analista.Text = "Analista:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1160, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(980, 42);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(73, 28);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1059, 47);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // Tabla1
            // 
            this.Tabla1.BackgroundColor = System.Drawing.Color.White;
            this.Tabla1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tabla1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NombreRiesgo,
            this.Activo,
            this.Riesgo,
            this.Daño,
            this.Ffuncion,
            this.Sustitucion,
            this.Profundidad,
            this.Extension,
            this.Agresion,
            this.Vulnerabilidad});
            this.Tabla1.Location = new System.Drawing.Point(29, 161);
            this.Tabla1.Name = "Tabla1";
            this.Tabla1.RowHeadersWidth = 51;
            this.Tabla1.RowTemplate.Height = 24;
            this.Tabla1.Size = new System.Drawing.Size(1211, 325);
            this.Tabla1.TabIndex = 9;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "ID";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Numero.Width = 50;
            // 
            // NombreRiesgo
            // 
            this.NombreRiesgo.HeaderText = "Nombre del Riesgo";
            this.NombreRiesgo.MinimumWidth = 6;
            this.NombreRiesgo.Name = "NombreRiesgo";
            this.NombreRiesgo.Width = 125;
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.MinimumWidth = 6;
            this.Activo.Name = "Activo";
            this.Activo.Width = 125;
            // 
            // Riesgo
            // 
            this.Riesgo.HeaderText = "Riesgo";
            this.Riesgo.MinimumWidth = 6;
            this.Riesgo.Name = "Riesgo";
            this.Riesgo.Width = 125;
            // 
            // Daño
            // 
            this.Daño.HeaderText = "Daño";
            this.Daño.MinimumWidth = 6;
            this.Daño.Name = "Daño";
            this.Daño.Width = 125;
            // 
            // Ffuncion
            // 
            this.Ffuncion.HeaderText = "F";
            this.Ffuncion.MinimumWidth = 6;
            this.Ffuncion.Name = "Ffuncion";
            this.Ffuncion.Visible = false;
            this.Ffuncion.Width = 50;
            // 
            // Sustitucion
            // 
            this.Sustitucion.HeaderText = "S";
            this.Sustitucion.MinimumWidth = 6;
            this.Sustitucion.Name = "Sustitucion";
            this.Sustitucion.Visible = false;
            this.Sustitucion.Width = 50;
            // 
            // Profundidad
            // 
            this.Profundidad.HeaderText = "P";
            this.Profundidad.MinimumWidth = 6;
            this.Profundidad.Name = "Profundidad";
            this.Profundidad.Visible = false;
            this.Profundidad.Width = 50;
            // 
            // Extension
            // 
            this.Extension.HeaderText = "E";
            this.Extension.MinimumWidth = 6;
            this.Extension.Name = "Extension";
            this.Extension.Visible = false;
            this.Extension.Width = 50;
            // 
            // Agresion
            // 
            this.Agresion.HeaderText = "A";
            this.Agresion.MinimumWidth = 6;
            this.Agresion.Name = "Agresion";
            this.Agresion.Visible = false;
            this.Agresion.Width = 50;
            // 
            // Vulnerabilidad
            // 
            this.Vulnerabilidad.HeaderText = "V";
            this.Vulnerabilidad.MinimumWidth = 6;
            this.Vulnerabilidad.Name = "Vulnerabilidad";
            this.Vulnerabilidad.Visible = false;
            this.Vulnerabilidad.Width = 50;
            // 
            // Fase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 511);
            this.Controls.Add(this.Tabla1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Analista);
            this.Controls.Add(this.Grabar);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fase1";
            this.Text = "Fase1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Grabar;
        private System.Windows.Forms.Label Analista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView Tabla1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ffuncion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sustitucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profundidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agresion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vulnerabilidad;
    }
}