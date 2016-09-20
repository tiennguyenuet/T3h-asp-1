using System;

namespace SoLonNhat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double num1, num2, num3;
			Console.Write("Nhap vao so thu nhat: ");
			num1 = double.Parse(Console.ReadLine());
			Console.Write("Nhap vao so thu hai: ");
			num2 = double.Parse(Console.ReadLine());
			Console.Write("Nhap vao so thu ba: ");
			num3 = double.Parse(Console.ReadLine());
			//Console.WriteLine ("So lon nhat trong 2 so la {0}", SoLonNhat2So((int)num1, (int)num2));
			Console.WriteLine ("So lon nhat trong 3 so la {0}", SoLonNhat3So(num1, num2, num3));
			Console.ReadKey();
		}

		public static int SoLonNhat2So(int num1, int num2){
			return num1 > num2 ? num1 : num2;
		}

		public static double SoLonNhat3So(double num1, double num2, double num3){
			double max;
			max = num1 > num2 ? num1 : num2;
			max = max > num3 ? max : num3;
			return max;
		}
	}
}
