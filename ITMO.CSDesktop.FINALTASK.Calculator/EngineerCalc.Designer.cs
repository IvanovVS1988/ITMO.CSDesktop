namespace Calculator
{
    partial class EngineerCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineerCalc));
            this.btnStepen = new System.Windows.Forms.Button();
            this.btnKoren = new System.Windows.Forms.Button();
            this.btnObratnoe = new System.Windows.Forms.Button();
            this.btnKvadrat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnQuadraticEquation = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnKubKoren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Size = new System.Drawing.Size(290, 26);
            // 
            // btn_sbros
            // 
            this.btn_sbros.Location = new System.Drawing.Point(244, 90);
            // 
            // btn_ravno
            // 
            this.btn_ravno.Location = new System.Drawing.Point(244, 170);
            this.btn_ravno.Size = new System.Drawing.Size(40, 120);
            // 
            // btnStepen
            // 
            this.btnStepen.BackColor = System.Drawing.SystemColors.Control;
            this.btnStepen.Location = new System.Drawing.Point(204, 90);
            this.btnStepen.Name = "btnStepen";
            this.btnStepen.Size = new System.Drawing.Size(40, 40);
            this.btnStepen.TabIndex = 62;
            this.btnStepen.Text = "x^n";
            this.toolTip1.SetToolTip(this.btnStepen, "Возведение в степень");
            this.btnStepen.UseVisualStyleBackColor = false;
            this.btnStepen.Click += new System.EventHandler(this.btnStepen_Click);
            // 
            // btnKoren
            // 
            this.btnKoren.BackColor = System.Drawing.SystemColors.Control;
            this.btnKoren.Image = ((System.Drawing.Image)(resources.GetObject("btnKoren.Image")));
            this.btnKoren.Location = new System.Drawing.Point(204, 130);
            this.btnKoren.Name = "btnKoren";
            this.btnKoren.Size = new System.Drawing.Size(40, 40);
            this.btnKoren.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnKoren, "Квадратный корень");
            this.btnKoren.UseVisualStyleBackColor = false;
            this.btnKoren.Click += new System.EventHandler(this.btnKoren_Click);
            // 
            // btnObratnoe
            // 
            this.btnObratnoe.BackColor = System.Drawing.SystemColors.Control;
            this.btnObratnoe.Location = new System.Drawing.Point(204, 170);
            this.btnObratnoe.Name = "btnObratnoe";
            this.btnObratnoe.Size = new System.Drawing.Size(40, 40);
            this.btnObratnoe.TabIndex = 64;
            this.btnObratnoe.Text = "1/x";
            this.toolTip1.SetToolTip(this.btnObratnoe, "Обратное число");
            this.btnObratnoe.UseVisualStyleBackColor = false;
            this.btnObratnoe.Click += new System.EventHandler(this.btnObratnoe_Click);
            // 
            // btnKvadrat
            // 
            this.btnKvadrat.BackColor = System.Drawing.SystemColors.Control;
            this.btnKvadrat.Location = new System.Drawing.Point(204, 210);
            this.btnKvadrat.Name = "btnKvadrat";
            this.btnKvadrat.Size = new System.Drawing.Size(40, 40);
            this.btnKvadrat.TabIndex = 65;
            this.btnKvadrat.Text = "x^2";
            this.toolTip1.SetToolTip(this.btnKvadrat, "Квадрат числа");
            this.btnKvadrat.UseVisualStyleBackColor = false;
            this.btnKvadrat.Click += new System.EventHandler(this.btnKvadrat_Click);
            // 
            // btnQuadraticEquation
            // 
            this.btnQuadraticEquation.BackColor = System.Drawing.SystemColors.Control;
            this.btnQuadraticEquation.Location = new System.Drawing.Point(28, 250);
            this.btnQuadraticEquation.Name = "btnQuadraticEquation";
            this.btnQuadraticEquation.Size = new System.Drawing.Size(120, 40);
            this.btnQuadraticEquation.TabIndex = 66;
            this.btnQuadraticEquation.Text = "Квадратное уравнение";
            this.toolTip1.SetToolTip(this.btnQuadraticEquation, "Квадратное уравнение");
            this.btnQuadraticEquation.UseVisualStyleBackColor = false;
            this.btnQuadraticEquation.Click += new System.EventHandler(this.btnQuadraticEquation_Click);
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.SystemColors.Control;
            this.btnFactorial.Location = new System.Drawing.Point(164, 250);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(40, 40);
            this.btnFactorial.TabIndex = 67;
            this.btnFactorial.Text = "x!";
            this.toolTip1.SetToolTip(this.btnFactorial, "Факториал");
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnKubKoren
            // 
            this.btnKubKoren.BackColor = System.Drawing.SystemColors.Control;
            this.btnKubKoren.Image = ((System.Drawing.Image)(resources.GetObject("btnKubKoren.Image")));
            this.btnKubKoren.Location = new System.Drawing.Point(204, 250);
            this.btnKubKoren.Name = "btnKubKoren";
            this.btnKubKoren.Size = new System.Drawing.Size(40, 40);
            this.btnKubKoren.TabIndex = 68;
            this.btnKubKoren.Text = "3";
            this.btnKubKoren.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnKubKoren, "Кубический корень");
            this.btnKubKoren.UseVisualStyleBackColor = false;
            this.btnKubKoren.Click += new System.EventHandler(this.btnKubKoren_Click);
            // 
            // EngineerCalc
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(310, 302);
            this.Controls.Add(this.btnKubKoren);
            this.Controls.Add(this.btnFactorial);
            this.Controls.Add(this.btnQuadraticEquation);
            this.Controls.Add(this.btnKvadrat);
            this.Controls.Add(this.btnObratnoe);
            this.Controls.Add(this.btnKoren);
            this.Controls.Add(this.btnStepen);
            this.Name = "EngineerCalc";
            this.Controls.SetChildIndex(this.btn1, 0);
            this.Controls.SetChildIndex(this.btn2, 0);
            this.Controls.SetChildIndex(this.btn3, 0);
            this.Controls.SetChildIndex(this.btn4, 0);
            this.Controls.SetChildIndex(this.btn5, 0);
            this.Controls.SetChildIndex(this.btn6, 0);
            this.Controls.SetChildIndex(this.btn7, 0);
            this.Controls.SetChildIndex(this.btn8, 0);
            this.Controls.SetChildIndex(this.btn9, 0);
            this.Controls.SetChildIndex(this.btn0, 0);
            this.Controls.SetChildIndex(this.btn_minus, 0);
            this.Controls.SetChildIndex(this.btn_plus, 0);
            this.Controls.SetChildIndex(this.btn_umnojenie, 0);
            this.Controls.SetChildIndex(this.btn_delenie, 0);
            this.Controls.SetChildIndex(this.btn_ravno, 0);
            this.Controls.SetChildIndex(this.btnpoint, 0);
            this.Controls.SetChildIndex(this.btnChangesign, 0);
            this.Controls.SetChildIndex(this.btn_sbros, 0);
            this.Controls.SetChildIndex(this.txtOutput, 0);
            this.Controls.SetChildIndex(this.btnStepen, 0);
            this.Controls.SetChildIndex(this.btnKoren, 0);
            this.Controls.SetChildIndex(this.btnObratnoe, 0);
            this.Controls.SetChildIndex(this.btnKvadrat, 0);
            this.Controls.SetChildIndex(this.btnQuadraticEquation, 0);
            this.Controls.SetChildIndex(this.btnFactorial, 0);
            this.Controls.SetChildIndex(this.btnKubKoren, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStepen;
        private System.Windows.Forms.Button btnKoren;
        private System.Windows.Forms.Button btnObratnoe;
        private System.Windows.Forms.Button btnKvadrat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnQuadraticEquation;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnKubKoren;
    }
}
