namespace CalculadoraPrueba
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
            this.Historial = new System.Windows.Forms.Label();
            this.cajaResultado = new System.Windows.Forms.TextBox();
            this.boton1 = new System.Windows.Forms.Button();
            this.boton3 = new System.Windows.Forms.Button();
            this.boton2 = new System.Windows.Forms.Button();
            this.boton5 = new System.Windows.Forms.Button();
            this.boton4 = new System.Windows.Forms.Button();
            this.boton6 = new System.Windows.Forms.Button();
            this.boton8 = new System.Windows.Forms.Button();
            this.boton9 = new System.Windows.Forms.Button();
            this.boton7 = new System.Windows.Forms.Button();
            this.botonComa = new System.Windows.Forms.Button();
            this.boton0 = new System.Windows.Forms.Button();
            this.botonMultiplicar = new System.Windows.Forms.Button();
            this.botonResta = new System.Windows.Forms.Button();
            this.botonSuma = new System.Windows.Forms.Button();
            this.botonResultado = new System.Windows.Forms.Button();
            this.botonModulo = new System.Windows.Forms.Button();
            this.botonDivision = new System.Windows.Forms.Button();
            this.botonReset = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Historial
            // 
            this.Historial.AutoSize = true;
            this.Historial.Location = new System.Drawing.Point(19, 49);
            this.Historial.Name = "Historial";
            this.Historial.Size = new System.Drawing.Size(0, 13);
            this.Historial.TabIndex = 0;
            // 
            // cajaResultado
            // 
            this.cajaResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaResultado.Location = new System.Drawing.Point(22, 84);
            this.cajaResultado.Multiline = true;
            this.cajaResultado.Name = "cajaResultado";
            this.cajaResultado.ReadOnly = true;
            this.cajaResultado.Size = new System.Drawing.Size(246, 46);
            this.cajaResultado.TabIndex = 1;
            this.cajaResultado.Text = "0";
            this.cajaResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boton1
            // 
            this.boton1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton1.Location = new System.Drawing.Point(22, 292);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(54, 46);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "1";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton3
            // 
            this.boton3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton3.Location = new System.Drawing.Point(142, 292);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(55, 46);
            this.boton3.TabIndex = 3;
            this.boton3.Text = "3";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // boton2
            // 
            this.boton2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton2.Location = new System.Drawing.Point(82, 292);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(54, 46);
            this.boton2.TabIndex = 4;
            this.boton2.Text = "2";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton5
            // 
            this.boton5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton5.Location = new System.Drawing.Point(82, 240);
            this.boton5.Name = "boton5";
            this.boton5.Size = new System.Drawing.Size(54, 46);
            this.boton5.TabIndex = 7;
            this.boton5.Text = "5";
            this.boton5.UseVisualStyleBackColor = true;
            this.boton5.Click += new System.EventHandler(this.boton5_Click);
            // 
            // boton4
            // 
            this.boton4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton4.Location = new System.Drawing.Point(22, 240);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(54, 46);
            this.boton4.TabIndex = 6;
            this.boton4.Text = "4";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // boton6
            // 
            this.boton6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton6.Location = new System.Drawing.Point(142, 240);
            this.boton6.Name = "boton6";
            this.boton6.Size = new System.Drawing.Size(55, 46);
            this.boton6.TabIndex = 5;
            this.boton6.Text = "6";
            this.boton6.UseVisualStyleBackColor = true;
            this.boton6.Click += new System.EventHandler(this.boton6_Click);
            // 
            // boton8
            // 
            this.boton8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton8.Location = new System.Drawing.Point(82, 188);
            this.boton8.Name = "boton8";
            this.boton8.Size = new System.Drawing.Size(54, 46);
            this.boton8.TabIndex = 10;
            this.boton8.Text = "8";
            this.boton8.UseVisualStyleBackColor = true;
            this.boton8.Click += new System.EventHandler(this.boton8_Click);
            // 
            // boton9
            // 
            this.boton9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton9.Location = new System.Drawing.Point(142, 188);
            this.boton9.Name = "boton9";
            this.boton9.Size = new System.Drawing.Size(55, 46);
            this.boton9.TabIndex = 9;
            this.boton9.Text = "9";
            this.boton9.UseVisualStyleBackColor = true;
            this.boton9.Click += new System.EventHandler(this.boton9_Click);
            // 
            // boton7
            // 
            this.boton7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton7.Location = new System.Drawing.Point(22, 188);
            this.boton7.Name = "boton7";
            this.boton7.Size = new System.Drawing.Size(54, 46);
            this.boton7.TabIndex = 8;
            this.boton7.Text = "7";
            this.boton7.UseVisualStyleBackColor = true;
            this.boton7.Click += new System.EventHandler(this.boton7_Click);
            // 
            // botonComa
            // 
            this.botonComa.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonComa.Location = new System.Drawing.Point(142, 344);
            this.botonComa.Name = "botonComa";
            this.botonComa.Size = new System.Drawing.Size(55, 46);
            this.botonComa.TabIndex = 11;
            this.botonComa.Text = ".";
            this.botonComa.UseVisualStyleBackColor = true;
            this.botonComa.Click += new System.EventHandler(this.botonComa_Click);
            // 
            // boton0
            // 
            this.boton0.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton0.Location = new System.Drawing.Point(22, 344);
            this.boton0.Name = "boton0";
            this.boton0.Size = new System.Drawing.Size(114, 46);
            this.boton0.TabIndex = 12;
            this.boton0.Text = "0";
            this.boton0.UseVisualStyleBackColor = true;
            this.boton0.Click += new System.EventHandler(this.boton0_Click);
            // 
            // botonMultiplicar
            // 
            this.botonMultiplicar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMultiplicar.Location = new System.Drawing.Point(203, 188);
            this.botonMultiplicar.Name = "botonMultiplicar";
            this.botonMultiplicar.Size = new System.Drawing.Size(58, 46);
            this.botonMultiplicar.TabIndex = 13;
            this.botonMultiplicar.Text = "X";
            this.botonMultiplicar.UseVisualStyleBackColor = true;
            this.botonMultiplicar.Click += new System.EventHandler(this.botonMultiplicar_Click);
            // 
            // botonResta
            // 
            this.botonResta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResta.Location = new System.Drawing.Point(203, 240);
            this.botonResta.Name = "botonResta";
            this.botonResta.Size = new System.Drawing.Size(58, 46);
            this.botonResta.TabIndex = 14;
            this.botonResta.Text = "-";
            this.botonResta.UseVisualStyleBackColor = true;
            this.botonResta.Click += new System.EventHandler(this.botonResta_Click);
            // 
            // botonSuma
            // 
            this.botonSuma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSuma.Location = new System.Drawing.Point(203, 292);
            this.botonSuma.Name = "botonSuma";
            this.botonSuma.Size = new System.Drawing.Size(58, 46);
            this.botonSuma.TabIndex = 15;
            this.botonSuma.Text = "+";
            this.botonSuma.UseVisualStyleBackColor = true;
            this.botonSuma.Click += new System.EventHandler(this.botonSuma_Click);
            // 
            // botonResultado
            // 
            this.botonResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonResultado.Location = new System.Drawing.Point(203, 344);
            this.botonResultado.Name = "botonResultado";
            this.botonResultado.Size = new System.Drawing.Size(58, 46);
            this.botonResultado.TabIndex = 16;
            this.botonResultado.Text = "=";
            this.botonResultado.UseVisualStyleBackColor = true;
            this.botonResultado.Click += new System.EventHandler(this.botonResultado_Click);
            // 
            // botonModulo
            // 
            this.botonModulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModulo.Location = new System.Drawing.Point(22, 136);
            this.botonModulo.Name = "botonModulo";
            this.botonModulo.Size = new System.Drawing.Size(54, 46);
            this.botonModulo.TabIndex = 17;
            this.botonModulo.Text = "%";
            this.botonModulo.UseVisualStyleBackColor = true;
            this.botonModulo.Click += new System.EventHandler(this.botonPorcentaje_Click);
            // 
            // botonDivision
            // 
            this.botonDivision.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonDivision.Location = new System.Drawing.Point(82, 136);
            this.botonDivision.Name = "botonDivision";
            this.botonDivision.Size = new System.Drawing.Size(54, 46);
            this.botonDivision.TabIndex = 18;
            this.botonDivision.Text = "/";
            this.botonDivision.UseVisualStyleBackColor = true;
            this.botonDivision.Click += new System.EventHandler(this.botonDivision_Click);
            // 
            // botonReset
            // 
            this.botonReset.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonReset.Location = new System.Drawing.Point(142, 136);
            this.botonReset.Name = "botonReset";
            this.botonReset.Size = new System.Drawing.Size(55, 46);
            this.botonReset.TabIndex = 19;
            this.botonReset.Text = "C";
            this.botonReset.UseVisualStyleBackColor = true;
            this.botonReset.Click += new System.EventHandler(this.botonReset_Click);
            // 
            // botonBorrar
            // 
            this.botonBorrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBorrar.Location = new System.Drawing.Point(203, 136);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(58, 46);
            this.botonBorrar.TabIndex = 20;
            this.botonBorrar.Text = "<";
            this.botonBorrar.UseVisualStyleBackColor = true;
            this.botonBorrar.Click += new System.EventHandler(this.botonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 410);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonReset);
            this.Controls.Add(this.botonDivision);
            this.Controls.Add(this.botonModulo);
            this.Controls.Add(this.botonResultado);
            this.Controls.Add(this.botonSuma);
            this.Controls.Add(this.botonResta);
            this.Controls.Add(this.botonMultiplicar);
            this.Controls.Add(this.boton0);
            this.Controls.Add(this.botonComa);
            this.Controls.Add(this.boton8);
            this.Controls.Add(this.boton9);
            this.Controls.Add(this.boton7);
            this.Controls.Add(this.boton5);
            this.Controls.Add(this.boton4);
            this.Controls.Add(this.boton6);
            this.Controls.Add(this.boton2);
            this.Controls.Add(this.boton3);
            this.Controls.Add(this.boton1);
            this.Controls.Add(this.cajaResultado);
            this.Controls.Add(this.Historial);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Historial;
        private System.Windows.Forms.TextBox cajaResultado;
        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Button boton3;
        private System.Windows.Forms.Button boton2;
        private System.Windows.Forms.Button boton5;
        private System.Windows.Forms.Button boton4;
        private System.Windows.Forms.Button boton6;
        private System.Windows.Forms.Button boton8;
        private System.Windows.Forms.Button boton9;
        private System.Windows.Forms.Button boton7;
        private System.Windows.Forms.Button botonComa;
        private System.Windows.Forms.Button boton0;
        private System.Windows.Forms.Button botonMultiplicar;
        private System.Windows.Forms.Button botonResta;
        private System.Windows.Forms.Button botonSuma;
        private System.Windows.Forms.Button botonResultado;
        private System.Windows.Forms.Button botonModulo;
        private System.Windows.Forms.Button botonDivision;
        private System.Windows.Forms.Button botonReset;
        private System.Windows.Forms.Button botonBorrar;
    }
}

