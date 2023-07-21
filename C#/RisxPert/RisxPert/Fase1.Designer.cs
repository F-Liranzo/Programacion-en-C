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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreRiesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Riesgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Analista = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // 
            // Grabar
            // 
            this.Grabar.Location = new System.Drawing.Point(47, 101);
            this.Grabar.Name = "Grabar";
            this.Grabar.Size = new System.Drawing.Size(134, 39);
            this.Grabar.TabIndex = 0;
            this.Grabar.Text = "Grabar";
            this.Grabar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.NombreRiesgo,
            this.Activo,
            this.Riesgo,
            this.Daño});
            this.dataGridView1.Location = new System.Drawing.Point(47, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(921, 325);
            this.dataGridView1.TabIndex = 1;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "#";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 125;
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
            this.Fecha.Location = new System.Drawing.Point(1059, 40);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(73, 28);
            this.Fecha.TabIndex = 2;
            this.Fecha.Text = "Fecha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1160, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // Fase1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 511);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Analista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Grabar);
            this.Controls.Add(this.Agregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fase1";
            this.Text = "Fase1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Grabar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreRiesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Riesgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Daño;
        private System.Windows.Forms.Label Analista;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.TextBox textBox2;
    }
}