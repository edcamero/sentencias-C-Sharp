namespace Calculadora
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.textNumero3 = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(38, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(51, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "numero 1";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(38, 68);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(51, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "numero 2";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(38, 107);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "numero 3";
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(154, 17);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(100, 20);
            this.textNumero1.TabIndex = 3;
            this.textNumero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(154, 61);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(100, 20);
            this.textNumero2.TabIndex = 4;
            // 
            // textNumero3
            // 
            this.textNumero3.Location = new System.Drawing.Point(154, 107);
            this.textNumero3.Name = "textNumero3";
            this.textNumero3.Size = new System.Drawing.Size(100, 20);
            this.textNumero3.TabIndex = 5;
            // 
            // Suma
            // 
            this.Suma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Suma.Location = new System.Drawing.Point(154, 151);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 6;
            this.Suma.Text = "Sumar";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Resta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Multiplicar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Dividir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Potencia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Factorial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(349, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Raiz";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.textNumero3);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.TextBox textNumero3;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

