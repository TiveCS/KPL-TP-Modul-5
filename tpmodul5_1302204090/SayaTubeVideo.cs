using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302204090
{
	internal class SayaTubeVideo
	{

		private int id;
		private string title;
		private int playCount;

		public SayaTubeVideo(string title)
		{
			this.title = title;
			this.playCount = 0;
			this.id = new Random().Next(10000, 99999);
		}

		public void IncreasePlayCount(int count)
		{
			this.playCount += count;
		}

		public void PrintVideoDetails()
		{
			Console.WriteLine(this.title + " (ID: " + this.id + ")" + " has " + this.playCount + " play(s)");
		}

	}
}
