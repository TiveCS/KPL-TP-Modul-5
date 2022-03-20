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
			SetTitle(title);
			this.playCount = 0;

			// Generate angka random antara 10.000 dan 99.999
			this.id = new Random().Next(10000, 99999);
		}

		// Set title dan mencegah set title jika null atau karakter lebih dari 100
		public void SetTitle(string title)
		{
			if (title == null) return;
			if (title.Length > 100) return;

			this.title = title;
		}

		// Tambah play count dan cek jika parameter diatas dari 10.000.000
		// jika parameter > 10.000.000, batalkan tambah play count
		public void IncreasePlayCount(int count)
		{
			int temp = this.playCount;
			try
			{
				if (count > 10000000) return;
				temp = checked(temp + count);
				this.playCount = temp;
			}
			catch (OverflowException ex)
			{
				Console.WriteLine("Angka play count telah melebihi batas!");
			}
		}

		// Print detail video (title, id, play count)
		public void PrintVideoDetails()
		{
			Console.WriteLine(this.title + " (ID: " + this.id + ")" + " has " + this.playCount + " play(s)");
		}

	}
}
