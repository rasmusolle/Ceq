using System;
using System.IO;
using System.Media;
using System.Threading;
namespace Ceq {
	public class Main {
		/// <summary>
		/// Play a .ceq file.
		/// </summary>
		/// <param name="path">Full or relative path of .ceq file.</param>
		public static void Play(string path) {
			Thread myNewThread = new Thread(() => PlayCeq(path));
			myNewThread.Start();
		}

		private static void PlayCeq(string path) {
			int counter = 0;
			string line;
			string[] musicline;

			System.IO.StreamReader file = new System.IO.StreamReader(path);
			while ((line = file.ReadLine()) != null) {
				if (counter == 0) {
					if (line != "ceqfile") {
						throw new Exception("Invalid header.");
					}
				} else {
					musicline = line.Split(',');
					Beep(100, Convert.ToInt32(musicline[0]), Convert.ToInt32(musicline[1]));
				}
				counter++;
			}
			file.Close();
		}

		private static void Beep(int Amplitude, int Frequency, int Duration) {
			double A = ((Amplitude * 32768.0) / 1000.0) - 1.0;
			double DeltaFT = (2 * Math.PI * Frequency) / 44100.0;
			int Samples = (44100 * Duration) / 1000;
			int Bytes = Samples * 4;
			int[] Hdr = new int[] { 0x46464952, 0x24 + Bytes, 0x45564157, 0x20746d66, 0x10, 0x20001, 0xac44, 0x2b110, 0x100004, 0x61746164, Bytes };
			using (MemoryStream MS = new MemoryStream(0x24 + Bytes)) {
				using (BinaryWriter BW = new BinaryWriter(MS)) {
					int length = Hdr.Length - 1;
					for (int I = 0; I <= length; I++) {
						BW.Write(Hdr[I]);
					}
					int sample = Samples - 1;
					for (int T = 0; T <= sample; T++) {
						short Sample = (short)Math.Round((double)(A * Math.Sin(DeltaFT * T)));
						BW.Write(Sample);
						BW.Write(Sample);
					}
					BW.Flush();
					MS.Seek(0L, SeekOrigin.Begin);
					using (SoundPlayer SP = new SoundPlayer(MS)) {
						SP.PlaySync();
					}
				}
			}
		}
	}
}