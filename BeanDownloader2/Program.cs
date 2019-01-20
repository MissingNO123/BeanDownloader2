using System;
using System.IO;
using System.Windows.Forms;

namespace BeanDownloader2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //setup
            if (!File.Exists(@"ffmpeg.exe"))
            {
                Console.WriteLine("FFMpeg not found, Downloading...");
                using (var client = new System.Net.WebClient())
                {
                    client.DownloadFile("https://github.com/vot/ffbinaries-prebuilt/releases/download/v4.0/ffmpeg-4.0.1-win-64.zip", "ffmpeg.zip");
                }
                Console.WriteLine("Unzipping...");
                System.IO.Compression.ZipFile.ExtractToDirectory("ffmpeg.zip", @".\");
                Console.WriteLine("Cleaning Up...");
                File.Delete(@"ffmpeg.zip");
                Directory.Delete(@"__MACOSX", true);
            }
            
            System.IO.Directory.CreateDirectory(@".\Downloads");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BeanForm());
        }
    }
    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength-1) + "…";
        }
    }
}
