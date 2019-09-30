using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//------------------------------------------------------------------------------------------------------------------------------------ Т И П Ы
			bool True = true;
			Console.WriteLine("bool: " + True);

			string name1 = "Adri";
			Console.WriteLine("string: " + name1);

			byte bit1 = 1;
			Console.WriteLine("byte: " + bit1);

			char cymbol = 'i';
			Console.WriteLine("char: " + cymbol);

			int num = 201;
			Console.WriteLine("int: " + num);

			double key = 9.9999;
			Console.WriteLine("double: " + key);

			int a = 4;
			int b = 6;
			double x = 1234.7;
			byte c = (byte)(a + b); //явное преобразование
			int ic = (int)x; //явное преобразование
			double d = a; //неявное преобразование
			long l = b; //неявное преобразование

			int number = 10;
			//boxing
			object obj = number;
			//unboxing
			int ju = (int)obj;

			//неявно типизированные переменные
			var myname = "Kirill";
			var age = 18;
			Console.WriteLine("Тип name: " + myname.GetType());
			Console.WriteLine("Тип age: " + age.GetType());

			//nullable
			int? a1 = null;
			int? b2 = 5;
			Console.WriteLine("Хранит ли a1 нект-е значение? -" + a1.HasValue);
			Console.WriteLine("Хранит ли b2 нект-е значение? -" + b2.HasValue);
			Console.WriteLine("Значение z2: " + b2.Value);
			//------------------------------------------------------------------------------------------------------------------------- C T P O K N
			string s1 = "Kva", s2 = "Kra";
			if (s1 == s2)
				Console.WriteLine("Строки s1 И s2 равны");
			else Console.WriteLine("Строки s1 И s2 неравны");

			//сцепление, копирование, выделение подстроки, 
			//разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
			string str1 = "R + ";
			string str2 = "E";
			Console.WriteLine(String.Concat(str1, str2)); // объединение строк

			string text = "KVA i KRA";
			string str4 = text.Substring(6); //выделение подстроки
			Console.WriteLine(str4);

			String s = "СЧА КАК РАЗДИЛЮ";
			String[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			for (int ind = 0; ind < words.Length; ind++)
				Console.WriteLine(words[ind]);

			string text2 = "КВА КРЯ";
			string subString = "+ ";
			text2 = text2.Insert(4, subString); //вставка подстроки в заданную позицию
			Console.WriteLine(text2);
			text2 = text2.Remove(4, 5); //удаление заданной подстроки
			Console.WriteLine(text2);


			//Создайте пустую и null строку. Продемонстрируйте что можно выполнить с такими строками
			string pusto = "";
			string nullstr = null;
			Console.WriteLine(pusto.Length); //метод Length для пустой строки
												//сравнение строк
			if (pusto == nullstr)
				Console.WriteLine("Строки равны");
			else Console.WriteLine("Строки pusto & nullstr неравны");
			string resStr = pusto + nullstr;
			Console.WriteLine(resStr);


			//Создайте строку на основе StringBuilder. Удалите определенные позиции и добавьте новые символы в начало и конец строки.
			StringBuilder sb = new StringBuilder("СЧА ЧУТОК УДОЛЮ StringBuilder");
			Console.WriteLine(sb);
			sb.Remove(0, 15); //удаление позиций
			Console.WriteLine(sb);
			sb.Insert(0, "СЧА "); //в начало
			Console.WriteLine(sb);
			sb.Insert(sb.Length, " ДОБАВЛЮ"); //в конец
			Console.WriteLine(sb);
			//--------------------------------------------------------------------------------------------------------------------- М А С С И В Ы
			Console.Write("Двумерный массив:");
			Console.WriteLine();
			int[,] array  = { { 2, 8, 3 }, {1, 4, 7 } };
			for (int i = 0; i < 2; i++)
			{
				for(int j=0; j<3; j++)
				Console.Write(array[i,j] + " ");
				Console.WriteLine();
			}
			Console.Write("Одноменый массив строк:");
			Console.WriteLine();
			int p = 0;
			Console.Write("Введите размер массива:");
			int k = int.Parse(Console.ReadLine());
			string[] name = new string[k];
			for (int i = 0; i < k; i++)
			{
				Console.Write("Введите элемент " +  i + ":  ");
				name[i] = Console.ReadLine();
			}
			Console.WriteLine("Массив: ");
			for (int i = 0; i < k; i++)
			{
				Console.Write(name[i] + "  ");
				p++;
			}
			Console.WriteLine();
			Console.WriteLine("Длина массива: " + p);
			Console.WriteLine();
			Console.Write("Введите номер имени, которого хотите поменять: ");
			int e = int.Parse(Console.ReadLine());
			for (int i = 0; i < k; i++)
			{
				if (i == e)
				{
					Console.Write("Введите новое имя:  ");
					name[i] = Console.ReadLine();
				}
			}
			for (int i = 0; i < k; i++)
			{
				Console.Write(name[i] + "  ");
			}

			Console.Write("Ступенчатый массив:");
			Console.WriteLine();
			int[][] arr = new int[3][];
			arr[0] = new int[1];
			arr[1] = new int[2];
			arr[2] = new int[3];
			for (int i = 0; i < 1; i++)
			{
				Console.Write("Введите " + "[" + 0 + "]" + "[" + i + "]" + " число массива: ");
				arr[0][i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 2; i++)
			{
				Console.Write("Введите " + "[" + 1 + "]" + "[" + i + "]" + " число массива: ");
				arr[1][i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 3; i++)
			{
				Console.Write("Введите " + "[" + 2 + "]" + "[" + i + "]" + " число массива: ");
				arr[2][i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < 3; i++)
			{
				if (i == 0)
				{
					for (int j = 0; j < 1; j++)
						Console.Write(arr[i][j] + "  ");
				}
				if (i == 1)
				{
					Console.WriteLine();
					for (int j = 0; j < 2; j++)
						Console.Write(arr[i][j] + "  ");
				}

				if (i == 2)
				{
					Console.WriteLine();
					for (int j = 0; j < 3; j++)
						Console.Write(arr[i][j] + "  ");
				}

			}
			//Неявно типизированные
			var A = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var str = "Stroka";
			Console.ReadKey();
			//-------------------------------------------------------------------------------------------------------------------- К О Р Т Е Ж И
			//a.	Задайте кортеж из 5 элементов с типами int, string, char, string, ulong. 
			(int, string, char, string, ulong) I_am = (18, "Kirill", 'm', "Vaishnis", 2001);

			//b.	Выведите кортеж на консоль целиком и выборочно ( например 1, 3, 4  элементы)
			Console.WriteLine(I_am);
			Console.WriteLine(I_am.Item1); Console.WriteLine(I_am.Item3); Console.WriteLine(I_am.Item4);

			//c.	Выполните распаковку кортежа в переменные.
			(var number1, var number2) = ("123", 456);

			//d.	Сравните два кортежа.
			(int, string, char, string, ulong) Not = (17, "Andrew", 'm', "Norris", 2002);
			if (I_am.Item1 == Not.Item1 && I_am.Item2 == Not.Item2 && I_am.Item3 == Not.Item3 && I_am.Item4 == Not.Item4 && I_am.Item5 == Not.Item5)
				Console.WriteLine("Кортежи равны");
			else Console.WriteLine("Кортежи неравны");
			Console.WriteLine(myFunction(A, str));
			Console.Read();

			//5)	Создайте локальную функцию в main и вызовите ее. 
			//Формальные параметры функции – массив целых и строка. 
			//Функция должна вернуть кортеж, содержащий: максимальный 
			//и минимальный элементы массива, сумму элементов массива и первую букву строки.
			(int, int, int, char) myFunction(int[] Arr, string sst)
			{
				int max = 0, min = 99, summ = 0;
				for (int ik = 0; ik < Arr.Length; ik++)
				{
					if (Arr[ik] > max)
						max = Arr[ik];
					if (Arr[ik] < min)
						min = Arr[ik];
					summ += Arr[ik];
				}
				(int, int, int, char) result = (min, max, summ, sst[0]);
				return result;
			}
		}
	}
}
