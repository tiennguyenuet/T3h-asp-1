using System;

namespace TinhTuoi
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int ngay, thang, nam;
			Console.Write ("Nhap ngay sinh: ");
			ngay = int.Parse (Console.ReadLine ());
			Console.Write ("Nhap thang sinh: ");
			thang = int.Parse (Console.ReadLine ());
			Console.Write ("Nhap nam sinh: ");
			nam = int.Parse (Console.ReadLine ());
			while (!checkDate(ngay,thang,nam)) {
				Console.WriteLine ("=== Nhap sai ngay thang nam, nhap lai ===");
				Console.Write ("Nhap ngay sinh: ");
				ngay = int.Parse (Console.ReadLine ());
				Console.Write ("Nhap thang sinh: ");
				thang = int.Parse (Console.ReadLine ());
				Console.Write ("Nhap nam sinh: ");
				nam = int.Parse (Console.ReadLine ());
			}
			Console.WriteLine ("Tuoi cua ban la: {0}", TinhTuoi(ngay, thang, nam));
			Console.ReadLine ();
		}

		public static Boolean checkDate(int ngay, int thang, int nam){
			int[] ngayNamNhuan = {0,31,29,31,30,31,30,31,31,30,31,30,31};
			int[] ngayNamThuong = {0,31,28,31,30,31,30,31,31,30,31,30,31};
			Boolean flag;
			if (validate (ngay, thang, nam)) {
				if (checkNamNhuan(nam)) {
					if (ngay>0 && ngay<=ngayNamNhuan[thang]) flag = true;
					else flag = false;
				} else {
					if (ngay>0 && ngay<=ngayNamThuong[thang]) flag = true;
					else flag = false;
				}
			}
			else flag = false;
			return flag;
		}

		public static Boolean checkNamNhuan(int nam){
		if ((nam % 4 == 0 && nam % 100 == 0) || nam % 400 == 0)
			return true;
		else 
			return false;
		}

		public static Boolean validate(int ngay, int thang, int nam){
		if (ngay > 0 && thang > 0 && nam > 0 && ngay < 32 && thang < 13)
			return true;
		else
			return false;
		}

		public static int TinhTuoi(int ngay, int thang, int nam){
			int tuoi;
			DateTime dt = DateTime.Now;
			int day = dt.Day;
			int month = dt.Month;
			int year = dt.Year;
			if (thang == month) {
				if (ngay < day)
					tuoi = year - nam;
				else 
					tuoi = year - nam - 1;
			} else if (thang > month) {
				tuoi = year - nam - 1;
			} else
				tuoi = year - nam;
			return tuoi;
		}
	}
}