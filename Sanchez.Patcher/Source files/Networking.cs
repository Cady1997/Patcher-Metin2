using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace MT2.Patcher.Source
{
    class Networking
    {
        public static void CheckNetwork()
        {
            Common.ChangeStatus("CONNECTING", new string[0]);
            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += Networking.backgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += Networking.backgroundWorker_RunWorkerCompleted;
            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", new object[]
                {   
                    "CheckNetwork isBusy"
                }));
                return;
            }
            backgroundWorker.RunWorkerAsync();
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                client.OpenRead(Globals.ServerURL);

                e.Result = true;
            }
            catch
            {
                e.Result = false;
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListDownloader.DownloadList();
        }
    }
}
