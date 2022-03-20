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

		}
	}
}
