namespace CON_UNI_SOAP_DOTNET_KGARCIA_CLIENTE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            mostrarNumero = new TextBox();
            centigradosFahrenheit = new Button();
            fahrenheitCentigrados = new Button();
            label1 = new Label();
            numero = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numero).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(255, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 29);
            textBox1.TabIndex = 0;
            textBox1.Text = "TRANSFORMACION DE UNIDADES";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // mostrarNumero
            // 
            mostrarNumero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mostrarNumero.Location = new Point(313, 238);
            mostrarNumero.Name = "mostrarNumero";
            mostrarNumero.ReadOnly = true;
            mostrarNumero.Size = new Size(172, 29);
            mostrarNumero.TabIndex = 1;
            mostrarNumero.TextAlign = HorizontalAlignment.Center;
            mostrarNumero.TextChanged += textBox2_TextChanged;
            // 
            // centigradosFahrenheit
            // 
            centigradosFahrenheit.Location = new Point(163, 326);
            centigradosFahrenheit.Name = "centigradosFahrenheit";
            centigradosFahrenheit.Size = new Size(148, 48);
            centigradosFahrenheit.TabIndex = 3;
            centigradosFahrenheit.Text = "Transformar de centigrados a fahrenheit";
            centigradosFahrenheit.UseVisualStyleBackColor = true;
            centigradosFahrenheit.Click += centigradosFahrenheit_Click;
            // 
            // fahrenheitCentigrados
            // 
            fahrenheitCentigrados.Location = new Point(482, 326);
            fahrenheitCentigrados.Name = "fahrenheitCentigrados";
            fahrenheitCentigrados.Size = new Size(148, 48);
            fahrenheitCentigrados.TabIndex = 4;
            fahrenheitCentigrados.Text = "Transformar de fahrenheit centigrados";
            fahrenheitCentigrados.UseVisualStyleBackColor = true;
            fahrenheitCentigrados.Click += fahrenheitCentigrados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(326, 118);
            label1.Name = "label1";
            label1.Size = new Size(136, 21);
            label1.TabIndex = 5;
            label1.Text = "Ingresa el numero";
            // 
            // numero
            // 
            numero.Location = new Point(342, 188);
            numero.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numero.Name = "numero";
            numero.Size = new Size(120, 23);
            numero.TabIndex = 6;
            numero.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numero);
            Controls.Add(label1);
            Controls.Add(fahrenheitCentigrados);
            Controls.Add(centigradosFahrenheit);
            Controls.Add(mostrarNumero);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numero).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox mostrarNumero;
        private Button centigradosFahrenheit;
        private Button fahrenheitCentigrados;
        private Label label1;
        private NumericUpDown numero;
    }
}