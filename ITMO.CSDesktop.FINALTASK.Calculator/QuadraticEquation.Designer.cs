namespace Calculator
{
    partial class QuadraticEquation
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
            this.components = new System.ComponentModel.Container();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSbros = new System.Windows.Forms.Button();
            this.aCofficient = new System.Windows.Forms.TextBox();
            this.bCofficient = new System.Windows.Forms.TextBox();
            this.cCofficient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(27, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 40);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Вычислить корни уровнения";
            this.toolTip1.SetToolTip(this.btnCalculate, "Вычислить корни уравнения");
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSbros
            // 
            this.btnSbros.BackColor = System.Drawing.SystemColors.Control;
            this.btnSbros.Location = new System.Drawing.Point(174, 235);
            this.btnSbros.Name = "btnSbros";
            this.btnSbros.Size = new System.Drawing.Size(120, 40);
            this.btnSbros.TabIndex = 1;
            this.btnSbros.Text = "Сброс";
            this.toolTip1.SetToolTip(this.btnSbros, "Сбросить параметры");
            this.btnSbros.UseVisualStyleBackColor = false;
            this.btnSbros.Click += new System.EventHandler(this.btnSbros_Click);
            // 
            // aCofficient
            // 
            this.aCofficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aCofficient.Location = new System.Drawing.Point(154, 100);
            this.aCofficient.Name = "aCofficient";
            this.aCofficient.Size = new System.Drawing.Size(154, 26);
            this.aCofficient.TabIndex = 2;
            this.toolTip1.SetToolTip(this.aCofficient, "Введите коэффициент а");
            // 
            // bCofficient
            // 
            this.bCofficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCofficient.Location = new System.Drawing.Point(154, 145);
            this.bCofficient.Name = "bCofficient";
            this.bCofficient.Size = new System.Drawing.Size(154, 26);
            this.bCofficient.TabIndex = 3;
            this.toolTip1.SetToolTip(this.bCofficient, "Введите коэффициент b");
            // 
            // cCofficient
            // 
            this.cCofficient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCofficient.Location = new System.Drawing.Point(154, 190);
            this.cCofficient.Name = "cCofficient";
            this.cCofficient.Size = new System.Drawing.Size(154, 26);
            this.cCofficient.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cCofficient, "Введите коэффициент c");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Коэффициент а:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Коэффициент b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Коэффициент c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "Решения квадратного уравнения вида: \r\nax^2+bx+c=0\"";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(7, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(301, 26);
            this.textBox4.TabIndex = 10;
            this.toolTip1.SetToolTip(this.textBox4, "Результат вычисления");
            // 
            // QuadraticEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(320, 292);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cCofficient);
            this.Controls.Add(this.bCofficient);
            this.Controls.Add(this.aCofficient);
            this.Controls.Add(this.btnSbros);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "QuadraticEquation";
            this.Text = "Квадратное уравнение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSbros;
        private System.Windows.Forms.TextBox aCofficient;
        private System.Windows.Forms.TextBox bCofficient;
        private System.Windows.Forms.TextBox cCofficient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}