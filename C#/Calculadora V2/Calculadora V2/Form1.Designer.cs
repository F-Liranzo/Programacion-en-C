namespace Calculadora_V2
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnElevarCuadrado = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnSigno = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(27, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(475, 76);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(27, 109);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 75);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(27, 199);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 75);
            this.btnSiete.TabIndex = 1;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(27, 291);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(75, 75);
            this.btnCuatro.TabIndex = 1;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(27, 385);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 75);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(120, 109);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 75);
            this.btnBorrarTodo.TabIndex = 1;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(120, 199);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(75, 75);
            this.btnOcho.TabIndex = 1;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(120, 291);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 75);
            this.btnCinco.TabIndex = 1;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(120, 385);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 75);
            this.btnDos.TabIndex = 1;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(215, 109);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 75);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "< -";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(215, 199);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(75, 75);
            this.btnNueve.TabIndex = 1;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(215, 291);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 75);
            this.btnSeis.TabIndex = 1;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(215, 385);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 75);
            this.btnTres.TabIndex = 1;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.Location = new System.Drawing.Point(337, 109);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(75, 75);
            this.btnRaizCuadrada.TabIndex = 1;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(337, 199);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 75);
            this.btnDividir.TabIndex = 1;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "∕";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(337, 291);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 75);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnElevarCuadrado
            // 
            this.btnElevarCuadrado.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevarCuadrado.Location = new System.Drawing.Point(427, 109);
            this.btnElevarCuadrado.Name = "btnElevarCuadrado";
            this.btnElevarCuadrado.Size = new System.Drawing.Size(75, 75);
            this.btnElevarCuadrado.TabIndex = 1;
            this.btnElevarCuadrado.Tag = "²";
            this.btnElevarCuadrado.Text = "X²";
            this.btnElevarCuadrado.UseVisualStyleBackColor = true;
            this.btnElevarCuadrado.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(427, 199);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(75, 75);
            this.btnMultiplicar.TabIndex = 1;
            this.btnMultiplicar.Tag = "*";
            this.btnMultiplicar.Text = "X";
            this.btnMultiplicar.UseVisualStyleBackColor = true;
            this.btnMultiplicar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(427, 291);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 75);
            this.btnResta.TabIndex = 1;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(337, 385);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(165, 75);
            this.btnResultado.TabIndex = 1;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnSigno
            // 
            this.btnSigno.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSigno.Location = new System.Drawing.Point(27, 480);
            this.btnSigno.Name = "btnSigno";
            this.btnSigno.Size = new System.Drawing.Size(75, 75);
            this.btnSigno.TabIndex = 1;
            this.btnSigno.Text = "+/-";
            this.btnSigno.UseVisualStyleBackColor = true;
            this.btnSigno.Click += new System.EventHandler(this.btnSigno_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(120, 480);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(75, 75);
            this.btnCero.TabIndex = 1;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.agregarNumero);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(215, 480);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 75);
            this.btnPunto.TabIndex = 1;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 588);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.btnSigno);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnElevarCuadrado);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnElevarCuadrado;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnSigno;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnPunto;
    }
}

