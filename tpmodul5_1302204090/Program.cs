using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204090
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// membuat instance class
			SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Ahmad Fathan Hanif");
			video.IncreasePlayCount(15);
			video.PrintVideoDetails();

			// test set title dengan null
			video.SetTitle(null);
			video.IncreasePlayCount(11235);
			video.PrintVideoDetails();

			// test menambahkan play count melebihi 10.000.000
			video.IncreasePlayCount(120000000);
			video.PrintVideoDetails();

			// test play count jika kapasitas variabel melebihi batas akan melakukan try-catch
			for (int i = 0; i < 218; i++)
			{
				video.IncreasePlayCount(10000000);
			}
			video.PrintVideoDetails();
		}
	}
}
