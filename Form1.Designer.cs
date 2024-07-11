namespace Practicas
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
            lb_resultado = new Label();
            btn_sumar = new Button();
            tb_num1 = new TextBox();
            tb_num2 = new TextBox();
            btn_restar = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Location = new Point(125, 54);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(16, 15);
            lb_resultado.TabIndex = 0;
            lb_resultado.Text = "...";
            // 
            // btn_sumar
            // 
            btn_sumar.Location = new Point(28, 79);
            btn_sumar.Name = "btn_sumar";
            btn_sumar.Size = new Size(75, 23);
            btn_sumar.TabIndex = 1;
            btn_sumar.Text = "+";
            btn_sumar.UseVisualStyleBackColor = true;
            btn_sumar.Click += button1_Click;
            // 
            // tb_num1
            // 
            tb_num1.Location = new Point(28, 19);
            tb_num1.Name = "tb_num1";
            tb_num1.Size = new Size(100, 23);
            tb_num1.TabIndex = 2;
            // 
            // tb_num2
            // 
            tb_num2.Location = new Point(149, 19);
            tb_num2.Name = "tb_num2";
            tb_num2.Size = new Size(100, 23);
            tb_num2.TabIndex = 3;
            // 
            // btn_restar
            // 
            btn_restar.Location = new Point(128, 79);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(75, 23);
            btn_restar.TabIndex = 4;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = true;
            btn_restar.Click += btn_restar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(28, 119);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(128, 119);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(224, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "x^y";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(224, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "%";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 170);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btn_restar);
            Controls.Add(tb_num2);
            Controls.Add(tb_num1);
            Controls.Add(btn_sumar);
            Controls.Add(lb_resultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_resultado;
        private Button btn_sumar;
        private TextBox tb_num1;
        private TextBox tb_num2;
        private Button btn_restar;
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button2;
    }
}
