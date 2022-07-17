using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace Calculator
{
	public class Calc : Form
    {
        protected TextBox txtOutput;
        protected Button btn_sbros;
        protected Button btnChangesign;
        protected Button btnpoint;
        protected Button btn_ravno;
        protected Button btn_delenie;
        protected Button btn_umnojenie;
        protected Button btn_plus;
        protected Button btn_minus;
        protected Button btn0;
        protected Button btn9;
        protected Button btn8;
        protected Button btn7;
        protected Button btn6;
        protected Button btn5;
        protected Button btn4;
        protected Button btn3;
        protected Button btn2;
        protected Button btn1;
        private IContainer components;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem CalculatorType;
        private ToolStripMenuItem AboutProgramm;
        private ToolStripMenuItem CommonCalculator;
        private ToolStripMenuItem EngineerCalculator;
        private ToolTip toolTip1;
        /// <summary>
        /// Объявляем и инициализируем переменные, которые будут
        ///  возникать на экране при нажатии соответствующих кнопок.
        /// </summary>
        private const string odin = "1";
		private const string dva = "2";
		private const string tri = "3";
		private const string chetire = "4";
		private const string pyat = "5";
		private const string shest = "6";
		private const string sem = "7";
		private const string vosem = "8";
		private const string devyat = "9";
        private const string nul = "0";  

		public Calc()
		{
			InitializeComponent();
			txtOutput.Text = "0";             // При запуске приложения на экране будет нуль
			this.Cursor = Cursors.Hand;       // Курсор рука
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calc));
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btn_sbros = new System.Windows.Forms.Button();
            this.btnChangesign = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btn_ravno = new System.Windows.Forms.Button();
            this.btn_delenie = new System.Windows.Forms.Button();
            this.btn_umnojenie = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CalculatorType = new System.Windows.Forms.ToolStripMenuItem();
            this.CommonCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineerCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.AccessibleName = "Display";
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOutput.Location = new System.Drawing.Point(10, 42);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(250, 26);
            this.txtOutput.TabIndex = 60;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_sbros
            // 
            this.btn_sbros.AccessibleName = "reset";
            this.btn_sbros.BackColor = System.Drawing.SystemColors.Control;
            this.btn_sbros.Location = new System.Drawing.Point(204, 90);
            this.btn_sbros.Name = "btn_sbros";
            this.btn_sbros.Size = new System.Drawing.Size(40, 80);
            this.btn_sbros.TabIndex = 0;
            this.btn_sbros.Text = "C";
            this.toolTip1.SetToolTip(this.btn_sbros, "Сброс");
            this.btn_sbros.UseVisualStyleBackColor = false;
            this.btn_sbros.Click += new System.EventHandler(this.btn_sbros_Click);
            // 
            // btnChangesign
            // 
            this.btnChangesign.AccessibleName = "change sign";
            this.btnChangesign.BackColor = System.Drawing.SystemColors.Control;
            this.btnChangesign.Location = new System.Drawing.Point(68, 210);
            this.btnChangesign.Name = "btnChangesign";
            this.btnChangesign.Size = new System.Drawing.Size(40, 40);
            this.btnChangesign.TabIndex = 58;
            this.btnChangesign.Text = "+/-";
            this.toolTip1.SetToolTip(this.btnChangesign, "Сменить знак");
            this.btnChangesign.UseVisualStyleBackColor = false;
            this.btnChangesign.Click += new System.EventHandler(this.btnChangesign_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.AccessibleName = "point ";
            this.btnpoint.BackColor = System.Drawing.SystemColors.Control;
            this.btnpoint.Location = new System.Drawing.Point(108, 210);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(40, 40);
            this.btnpoint.TabIndex = 57;
            this.btnpoint.Text = ",";
            this.toolTip1.SetToolTip(this.btnpoint, "Точка");
            this.btnpoint.UseVisualStyleBackColor = false;
            this.btnpoint.Click += new System.EventHandler(this.btnpoint_Click);
            // 
            // btn_ravno
            // 
            this.btn_ravno.AccessibleDescription = "ravno";
            this.btn_ravno.AccessibleName = "equal";
            this.btn_ravno.BackColor = System.Drawing.SystemColors.Control;
            this.btn_ravno.Location = new System.Drawing.Point(204, 170);
            this.btn_ravno.Name = "btn_ravno";
            this.btn_ravno.Size = new System.Drawing.Size(40, 80);
            this.btn_ravno.TabIndex = 56;
            this.btn_ravno.Text = "=";
            this.toolTip1.SetToolTip(this.btn_ravno, "Равно");
            this.btn_ravno.UseVisualStyleBackColor = false;
            this.btn_ravno.Click += new System.EventHandler(this.btn_ravno_Click);
            // 
            // btn_delenie
            // 
            this.btn_delenie.AccessibleName = "divide ";
            this.btn_delenie.BackColor = System.Drawing.SystemColors.Control;
            this.btn_delenie.Location = new System.Drawing.Point(164, 90);
            this.btn_delenie.Name = "btn_delenie";
            this.btn_delenie.Size = new System.Drawing.Size(40, 40);
            this.btn_delenie.TabIndex = 55;
            this.btn_delenie.Text = "/";
            this.toolTip1.SetToolTip(this.btn_delenie, "Деление");
            this.btn_delenie.UseVisualStyleBackColor = false;
            this.btn_delenie.Click += new System.EventHandler(this.btn_delenie_Click);
            // 
            // btn_umnojenie
            // 
            this.btn_umnojenie.AccessibleName = "multiply ";
            this.btn_umnojenie.BackColor = System.Drawing.SystemColors.Control;
            this.btn_umnojenie.Location = new System.Drawing.Point(164, 130);
            this.btn_umnojenie.Name = "btn_umnojenie";
            this.btn_umnojenie.Size = new System.Drawing.Size(40, 40);
            this.btn_umnojenie.TabIndex = 54;
            this.btn_umnojenie.Text = "*";
            this.toolTip1.SetToolTip(this.btn_umnojenie, "Умножение");
            this.btn_umnojenie.UseVisualStyleBackColor = false;
            this.btn_umnojenie.Click += new System.EventHandler(this.btn_umnojenie_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.AccessibleName = "plus ";
            this.btn_plus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_plus.Location = new System.Drawing.Point(164, 210);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(40, 40);
            this.btn_plus.TabIndex = 53;
            this.btn_plus.Text = "+";
            this.toolTip1.SetToolTip(this.btn_plus, "Сложение");
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.AccessibleName = "minus ";
            this.btn_minus.BackColor = System.Drawing.SystemColors.Control;
            this.btn_minus.Location = new System.Drawing.Point(164, 170);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(40, 40);
            this.btn_minus.TabIndex = 52;
            this.btn_minus.Text = "-";
            this.toolTip1.SetToolTip(this.btn_minus, "Вычитание");
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn0
            // 
            this.btn0.AccessibleName = "zero";
            this.btn0.BackColor = System.Drawing.SystemColors.Control;
            this.btn0.Location = new System.Drawing.Point(28, 210);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(40, 40);
            this.btn0.TabIndex = 51;
            this.btn0.Text = "0";
            this.toolTip1.SetToolTip(this.btn0, "Ноль");
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.AccessibleName = "nine ";
            this.btn9.BackColor = System.Drawing.SystemColors.Control;
            this.btn9.Location = new System.Drawing.Point(108, 90);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(40, 40);
            this.btn9.TabIndex = 50;
            this.btn9.Text = "9";
            this.toolTip1.SetToolTip(this.btn9, "Девять");
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.AccessibleName = "eight ";
            this.btn8.BackColor = System.Drawing.SystemColors.Control;
            this.btn8.Location = new System.Drawing.Point(68, 90);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(40, 40);
            this.btn8.TabIndex = 49;
            this.btn8.Text = "8";
            this.toolTip1.SetToolTip(this.btn8, "Восемь");
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.AccessibleName = "seven ";
            this.btn7.BackColor = System.Drawing.SystemColors.Control;
            this.btn7.Location = new System.Drawing.Point(28, 90);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(40, 40);
            this.btn7.TabIndex = 48;
            this.btn7.Text = "7";
            this.toolTip1.SetToolTip(this.btn7, "Семь");
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.AccessibleName = "six ";
            this.btn6.BackColor = System.Drawing.SystemColors.Control;
            this.btn6.Location = new System.Drawing.Point(108, 130);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(40, 40);
            this.btn6.TabIndex = 47;
            this.btn6.Text = "6";
            this.toolTip1.SetToolTip(this.btn6, "Шесть");
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.AccessibleName = "five ";
            this.btn5.BackColor = System.Drawing.SystemColors.Control;
            this.btn5.Location = new System.Drawing.Point(68, 130);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(40, 40);
            this.btn5.TabIndex = 46;
            this.btn5.Text = "5";
            this.toolTip1.SetToolTip(this.btn5, "Пять");
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.AccessibleName = "four ";
            this.btn4.BackColor = System.Drawing.SystemColors.Control;
            this.btn4.Location = new System.Drawing.Point(28, 130);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(40, 40);
            this.btn4.TabIndex = 45;
            this.btn4.Text = "4";
            this.toolTip1.SetToolTip(this.btn4, "Четыре");
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.AccessibleName = "three ";
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(108, 170);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(40, 40);
            this.btn3.TabIndex = 44;
            this.btn3.Text = "3";
            this.toolTip1.SetToolTip(this.btn3, "Три");
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.AccessibleName = "two ";
            this.btn2.BackColor = System.Drawing.SystemColors.Control;
            this.btn2.Location = new System.Drawing.Point(68, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(40, 40);
            this.btn2.TabIndex = 43;
            this.btn2.Text = "2";
            this.toolTip1.SetToolTip(this.btn2, "Два");
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.AccessibleName = "one ";
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Location = new System.Drawing.Point(28, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(40, 40);
            this.btn1.TabIndex = 42;
            this.btn1.Text = "1";
            this.toolTip1.SetToolTip(this.btn1, "Один");
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CalculatorType,
            this.AboutProgramm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(270, 24);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CalculatorType
            // 
            this.CalculatorType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CommonCalculator,
            this.EngineerCalculator});
            this.CalculatorType.Name = "CalculatorType";
            this.CalculatorType.Size = new System.Drawing.Size(117, 20);
            this.CalculatorType.Text = "Тип калькулятора";
            // 
            // CommonCalculator
            // 
            this.CommonCalculator.Name = "CommonCalculator";
            this.CommonCalculator.Size = new System.Drawing.Size(148, 22);
            this.CommonCalculator.Text = "Обычный";
            this.CommonCalculator.Click += new System.EventHandler(this.CommonCalculator_Click);
            // 
            // EngineerCalculator
            // 
            this.EngineerCalculator.Name = "EngineerCalculator";
            this.EngineerCalculator.Size = new System.Drawing.Size(148, 22);
            this.EngineerCalculator.Text = "Инженерный";
            this.EngineerCalculator.Click += new System.EventHandler(this.EngineerCalculator_Click);
            // 
            // AboutProgramm
            // 
            this.AboutProgramm.Name = "AboutProgramm";
            this.AboutProgramm.Size = new System.Drawing.Size(94, 20);
            this.AboutProgramm.Text = "О программе";
            this.AboutProgramm.Click += new System.EventHandler(this.AboutProgramm_Click);
            // 
            // Calc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_sbros);
            this.Controls.Add(this.btnChangesign);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn_ravno);
            this.Controls.Add(this.btn_delenie);
            this.Controls.Add(this.btn_umnojenie);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор 1.0";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Calc());
		}
		/// <summary>
		/// Обработчики для кнопок  обращаются к методу chislonaEkrane класса mehanizmcalkulyatora
		/// и передают ему одну из постоянных (odin, dva, tri  и т.д.). Результат, возвращаемый методом,
		/// присваивается  свойству Text текстового поля txtOutput.
		/// </summary>

		private void btn1_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (odin);
		}

		private void btn2_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (dva);
		}

		private void btn3_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (tri);
		}

		private void btn4_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (chetire);
		}

		private void btn5_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (pyat);
		}

		private void btn6_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (shest);
		}

		private void btn7_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (sem);
		}

		private void btn8_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (vosem);
		}

		private void btn9_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (devyat);
		}

		private void btn0_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.chislonaEkrane (nul);
		}

		private void btnChangesign_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakChisla();
		}

		private void btnpoint_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakTochki();
		}
			/// <summary>
			/// Обработчики кнопок действия калькулятора передают 
			/// методу DeystvieCalculatora класса mehanizmcalkulyatora переменную перечисления Deystvie.
			/// </summary>
		
		private void btn_delenie_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Delenie);
		}

		private void btn_umnojenie_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Umnojenie);
		}

		private void btn_minus_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Vichitanie);
		}

		private void btn_plus_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.DeystvieCalculatora (mehanizmcalkulyatora.Deystvie.Slojenie);
		}

		private void btn_ravno_Click(object sender, System.EventArgs e)
		{
			txtOutput.Text = mehanizmcalkulyatora.ZnakRavno();
			mehanizmcalkulyatora.Sbros();
		}

		private void btn_sbros_Click(object sender, System.EventArgs e)
		{
			mehanizmcalkulyatora.Sbros();
			txtOutput.Text = "0";
		}
        private void AboutProgramm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Калькулятор - выпускное задание в рамках курса ИТМО \"Разработка Windows-приложений на C#\"" +
                "\n\n2) Выполнен комплекс заданий на оценку - отлично\n\n3) Студент: Иванов Владимир Сергеевич, группа: 124/16");
        }

        private void CommonCalculator_Click(object sender, EventArgs e)             
        {
            this.Close();                                                                   
            Thread th = new Thread(OpenCommonCalc);                                             //Создаем новый поток для нового окна
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenCommonCalc()
        {
            Application.Run(new Calc());                                                        //Открываем новое окно
        }
        private void EngineerCalculator_Click(object sender, EventArgs e)
        {
            this.Close();                                                                       //Создаем новый поток для нового окна
            Thread th = new Thread(OpenEngineerCalc);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenEngineerCalc()
        {
            Application.Run(new EngineerCalc());                                                //Открываем новое окно
        }
    }
}