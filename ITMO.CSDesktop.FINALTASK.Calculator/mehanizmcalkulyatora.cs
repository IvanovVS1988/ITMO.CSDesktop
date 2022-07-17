using System;
using System.Windows.Forms;

namespace Calculator
{
	class mehanizmcalkulyatora
	{
		/// <summary>
		///Создаем перечисление Deystvie, для определения одного из четырех действия калькулятора.
		/// </summary>
		public enum Deystvie : int
		{
			NeopredelDeystvie = 0,
			Slojenie = 1,
			Vichitanie = 2,
			Umnojenie = 3,
			Delenie = 4,
			Stepen = 5,
			KvadratnuiKoren = 6,
			ObratnoeChislo = 7,
			KvadratChisla = 8,
			Factorial = 9,
			KubKoren = 10
		}

		/// <summary>
		/// Объявляем и инициализируем переменную, 
		/// которая будет использоваться для смены знака при нажатии клавиши (+/-)
		/// </summary>

		private static double peremennayaMinus = -1;

		/// <summary>
		/// Объвляем переменные, для работы калькулятора:
		/// resultatVichisleniy - переменная для хранения
		///  промежуточного результата в механизме калькулятора
		///  resultatOutput - переменная, значение которой будет сниматься с экрана и  выводиться на него.
		///  tekusheeDeystvieCalculatora - хранение одного из действия калькулятора.
		///  pervoeChislo - переменная, в которую будет записываться число на экране
		///   до нажатия на одну из четырех кнопок с действием.
		///  vtoroeChislo - второе число на экране.
		///  dobavlenierazryada при добавлении следующего  разряда эта переменная примет значение true;
		///  ChislosTochkoy при добавлении десятичного разряда (знака точки) эта переменная примет значение true
		/// </summary>

		private static double resultatVichisleniy;
		private static string resultatOutput;
		private static Deystvie tekusheeDeystvieCalculatora;
		private static double pervoeChislo;
		private static double vtoroeChislo;
		private static bool dobavlenierazryada;
		private static bool ChislosTochkoy;

		/// <summary>
		/// В конструкторе класса mehanizmcalkulyatora инициализируем переменные 
		/// ChislosTochkoy и dobavlenierazryada - при запуске калькулятора на экране 
		/// нет ни разрядности, ни десятичной части.
		/// </summary>

		public mehanizmcalkulyatora()
		{
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}


		/// <summary>
		/// В этом методе переменная resultatOutput изменяется - при вводе числа ее значение перезаписывается.
		/// </summary>


		public static string chislonaEkrane(string najatayaKlavisha)
		{
			resultatOutput = resultatOutput + najatayaKlavisha;
			return (resultatOutput);
		}
		/// <summary>
		/// Метод, в котором определяется peremenDeystviya - одно значение перечисления Deystvie,
		///в зависимости от выбора  клавиши +, -, *,  или /
		/// </summary>

		public static void DeystvieCalculatora(Deystvie peremenDeystviya)
		{
			try
			{
				if (resultatOutput != "" && !dobavlenierazryada)
				{
					pervoeChislo = System.Convert.ToDouble(resultatOutput);
					tekusheeDeystvieCalculatora = peremenDeystviya;
					resultatOutput = "";
					ChislosTochkoy = false;
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{

			}
		}

		/// <summary>
		/// При нажатии  кнопки +/- число на экране - tekusheeChislo умножается на -1,
		///  а затем результат снова присваивается переменной resultatOutput.
		/// </summary>

		public static string ZnakChisla()
		{
			double tekusheeChislo;

			if (resultatOutput != "")
			{
				tekusheeChislo = System.Convert.ToDouble(resultatOutput);
				resultatOutput = System.Convert.ToString(tekusheeChislo * peremennayaMinus);
			}

			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ( , ) переменная resultatOutput приобретает дробную часть.
		/// </summary>

		public static string ZnakTochki()
		{
			if (!ChislosTochkoy && !dobavlenierazryada)
			{
				if (resultatOutput != "")
					resultatOutput = resultatOutput + ",";
				else
					resultatOutput = "0,";

				ChislosTochkoy = true;
			}

			return (resultatOutput);
		}

		/// <summary>
		/// При нажатии кнопки ZnakRavno обрабатываются значения 
		/// переменнных pervoeChislo и vtoroeChislo, результат присваивается переменной resultatVichisleniy 
		/// которая  затем преобразуется в resultatOutput.
		/// </summary>
		
		public static double Factorial (int N)
        {
			int k;
			double f;
			f = 1;
			for (k = 2; k <= N; ++k)
            {
				f = f * k;
			}
			return f;
		}

		public static string ZnakRavno()
		{
			bool proverkaOshibok = false;

			if (resultatOutput != "")
			{
				vtoroeChislo = System.Convert.ToDouble(resultatOutput);
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{
					case Deystvie.NeopredelDeystvie:
						proverkaOshibok = false;
						break;

					case Deystvie.Slojenie:
						resultatVichisleniy = pervoeChislo + vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Vichitanie:
						resultatVichisleniy = pervoeChislo - vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Umnojenie:
						resultatVichisleniy = pervoeChislo * vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Delenie:
						resultatVichisleniy = pervoeChislo / vtoroeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Stepen:
						resultatVichisleniy = Math.Pow(pervoeChislo, vtoroeChislo);
						proverkaOshibok=true;
						break;

					default:
						proverkaOshibok = false;
						break;
				}
				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString(resultatVichisleniy);
			}
			else
            {
				dobavlenierazryada = true;

				switch (tekusheeDeystvieCalculatora)
				{									
					case Deystvie.KvadratnuiKoren:
						if (pervoeChislo >= 0)
						{
							resultatVichisleniy = Math.Sqrt(pervoeChislo);
							proverkaOshibok = true;
						}
						else
							proverkaOshibok = false;
						break;

					case Deystvie.ObratnoeChislo:
						resultatVichisleniy = 1/pervoeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.KvadratChisla:
						resultatVichisleniy = pervoeChislo*pervoeChislo;
						proverkaOshibok = true;
						break;

					case Deystvie.Factorial:
						if (pervoeChislo >= 0)
						{
							resultatVichisleniy = Factorial(Convert.ToInt32(pervoeChislo));
							proverkaOshibok = true;
						}
						else
							proverkaOshibok = false;
						break;

					case Deystvie.KubKoren:
						if (pervoeChislo < 0)
						{
							resultatVichisleniy = -1 * Math.Pow(pervoeChislo * -1, 1.0 / 3.0);
							proverkaOshibok = true;
						}
						else
						{
							resultatVichisleniy = Math.Pow(pervoeChislo, 1.0 / 3.0);
							proverkaOshibok = true;
						}
						break;

					default:
						proverkaOshibok = false;
						break;
				}
				if (proverkaOshibok)
					resultatOutput = System.Convert.ToString(resultatVichisleniy);
				else
					resultatOutput = "Некорректные данные";
			}
			return (resultatOutput);
		}

		/// <summary>
		/// Решение квадратного уравнения.
		/// </summary>
		public static string QuadraticEquationCalculate(string a, string b, string c)
		{
			double aCofficient, bCofficient, cCofficient, Discriminant, x, x1, x2;
			string answer;
			aCofficient = Convert.ToDouble(a);
			bCofficient = Convert.ToDouble(b);
			cCofficient = Convert.ToDouble(c);
			Discriminant = bCofficient * bCofficient - 4 * aCofficient * cCofficient; //Вычисление Дискриминанта
			if (Discriminant > 0)
			{
				x1 = (-bCofficient + Math.Sqrt(Discriminant)) / (2 * aCofficient);
				x2 = (-bCofficient - Math.Sqrt(Discriminant)) / (2 * aCofficient);
				answer = "x1=" + Convert.ToString(Math.Round(x1,4)) + "   x2=" + Convert.ToString(Math.Round(x2,4));
			}
			else if (Discriminant == 0)
			{
				x = (-bCofficient) / (2 * aCofficient);
				answer = "x=" + Convert.ToString(Math.Round(x,4));
			}
			else
			{
				answer = "Уравнение не имеет решения";
			}
			return answer;
		}

		/// <summary>
		/// При нажатии кнопки  С (сброс) значения переменных обнуляются.
		/// </summary>

		public static void Sbros()
		{
			resultatVichisleniy = 0;
			pervoeChislo = 0;
			vtoroeChislo = 0;
			resultatOutput = "";
			tekusheeDeystvieCalculatora = Deystvie.NeopredelDeystvie;
			ChislosTochkoy = false;
			dobavlenierazryada = false;
		}
	}
}