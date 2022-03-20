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

			SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Ahmad Fathan Hanif");
			video.IncreasePlayCount(15);
			video.PrintVideoDetails();

			video.SetTitle(null);
			video.IncreasePlayCount(11235);
			video.PrintVideoDetails();

			video.IncreasePlayCount(120000000);
			video.PrintVideoDetails();

			for (int i = 0; i < 1000; i++)
			{
				video.IncreasePlayCount(10000000);
			}
			video.PrintVideoDetails();
		}
	}
}
