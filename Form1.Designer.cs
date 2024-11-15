namespace Practica_7_U3
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
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            valor=new TextBox();
            Resultado=new TextBox();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(61, 24);
            label1.Name="label1";
            label1.Size=new Size(37, 15);
            label1.TabIndex=0;
            label1.Text="Datos";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(89, 56);
            label2.Name="label2";
            label2.Size=new Size(77, 15);
            label2.TabIndex=1;
            label2.Text="Ingresa valor:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(61, 93);
            label3.Name="label3";
            label3.Size=new Size(134, 15);
            label3.TabIndex=2;
            label3.Text="Opciones de conversión";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(61, 218);
            label4.Name="label4";
            label4.Size=new Size(114, 15);
            label4.TabIndex=3;
            label4.Text="Resultado en grados";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(100, 245);
            label5.Name="label5";
            label5.Size=new Size(131, 15);
            label5.TabIndex=4;
            label5.Text="Equivalencia en grados:";
            // 
            // valor
            // 
            valor.Location=new Point(174, 56);
            valor.Name="valor";
            valor.Size=new Size(100, 23);
            valor.TabIndex=5;
            // 
            // Resultado
            // 
            Resultado.Location=new Point(174, 280);
            Resultado.Name="Resultado";
            Resultado.Size=new Size(100, 23);
            Resultado.TabIndex=6;
            // 
            // button1
            // 
            button1.Location=new Point(99, 130);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=7;
            button1.Text="Fahrenheit";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(213, 130);
            button2.Name="button2";
            button2.Size=new Size(83, 23);
            button2.TabIndex=8;
            button2.Text="Centigrados";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Location=new Point(156, 159);
            button3.Name="button3";
            button3.Size=new Size(75, 23);
            button3.TabIndex=9;
            button3.Text="Borrar";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Resultado);
            Controls.Add(valor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox valor;
        private TextBox Resultado;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}