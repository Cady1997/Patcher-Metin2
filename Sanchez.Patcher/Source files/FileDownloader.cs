using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using OctaneEngine;

namespace MT2.Patcher.Source
{
    class FileDownloader
    {
        private static int      curFile;
        private static long     lastBytes;
        private static long     currentBytes;

        private static Stopwatch stopWatch = new Stopwatch();

        public static void DownloadFile()
        {
            if(Globals.OldFiles.Count <= 0)
            {
                Common.ChangeStatus("CHECKCOMPLETE");
                Common.EnableStart();

                return;
            }

            if (curFile >= Globals.OldFiles.Count)
            {
                Common.ChangeStatus("DOWNLOADCOMPLETE");
                Common.EnableStart();

                return;
            }
            if (Path.GetDirectoryName(Globals.OldFiles[FileDownloader.curFile]) != "")
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Globals.OldFiles[FileDownloader.curFile]));
                //MessageBox.Show(Path.GetDirectoryName(Globals.OldFiles[FileDownloader.curFile]));
            }

            WebClient webClient = new WebClient();

            webClient.DownloadProgressChanged   += new DownloadProgressChangedEventHandler(webClient_DownloadProgressChanged);

            webClient.DownloadFileCompleted     += new AsyncCompletedEventHandler(webClient_DownloadFileCompleted);

            stopWatch.Start();

            webClient.DownloadFileAsync(new Uri(Globals.ServerURL + Globals.OldFiles[curFile]), Globals.OldFiles[curFile]);
        }

        private static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            currentBytes = lastBytes + e.BytesReceived;

            Common.ChangeStatus("DOWNLOADFILE", Globals.OldFiles[curFile], Computer.ComputeDownloadSize(e.BytesReceived).ToString("0.00") + " MB ", Computer.ComputeDownloadSize(e.TotalBytesToReceive).ToString("0.00") + " MB");

            Common.UpdateCompleteProgress(Computer.Compute(Globals.completeSize + currentBytes));

            Common.UpdateCurrentProgress(e.ProgressPercentage, Computer.ComputeDownloadSpeed(e.BytesReceived, stopWatch));
        }

        public static async Task getVersionAsync() {
            var request = (HttpWebRequest)WebRequest.Create("http://5.254.26.123/version.json");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader responseReader = new StreamReader(responseStream))
                    {
                        string json = responseReader.ReadToEnd();
                        string data = JObject.Parse(json)["version"].ToString();
                        var ver = Int32.Parse(data);
                      //  MessageBox.Show(String.Format(CultureInfo.InvariantCulture,"{0:0.00}", data));
                        Globals.pForm.version.Text = String.Format("ver. {0:00,#}", ver);


                    }
                }
            }

        }

        private static void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lastBytes = currentBytes;

            Common.UpdateCurrentProgress(100L, 0.0);

            curFile++;

            stopWatch.Reset();

            DownloadFile();
        }
    }
}
