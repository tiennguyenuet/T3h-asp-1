using System;

namespace TienXang
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double quangDuong;
			double giaXang;
			Console.Write("Nhap vao quang duong: ");
			quangDuong = double.Parse (Console.ReadLine());
			Console.Write("Nhap vao gia xang: ");
			giaXang = double.Parse (Console.ReadLine());
			Console.WriteLine ("So tien can tra: {0} VND", TinhTien(quangDuong, giaXang));
			Console.ReadLine();
		}

		public static double TinhTien(double quangDuong, double giaXang){
			double luongXang = quangDuong / 50;
			double tienXang = luongXang * giaXang;
			return tienXang;
		}
	}
}
