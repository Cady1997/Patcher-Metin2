using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MT2.Patcher.Source
{
    class FileChecker
    {
        enum State
        {
            REPORT_NAME     = 0,
            REPORT_PROGRESS = 1
        }

        private static BackgroundWorker backgroundWorker = new BackgroundWorker();

        public static void CheckFiles()
        {
            backgroundWorker.WorkerReportsProgress = true;

            backgroundWorker.DoWork             += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged    += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;

            if (backgroundWorker.IsBusy)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", "CheckFiles isBusy"));
                Application.Exit();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private static void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (Globals.File file in Globals.Files)
            {
                Globals.fullSize += file.Size;
                FileChecker.backgroundWorker.ReportProgress(0, Path.GetFileName(file.Name));
                if (!File.Exists(file.Name) || Common.CalculateMD5Hash(file.Name) != file.Hash)
                {
                    Globals.OldFiles.Add(file.Name);
                }
                else
                {
                    Globals.completeSize += file.Size;
                    FileChecker.backgroundWorker.ReportProgress(1);
                }
            }
        }

        private static void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if(e.ProgressPercentage == (int)State.REPORT_NAME)
            {
                Common.ChangeStatus("CHECKFILE", e.UserState.ToString());
            }
            else
            {
                Common.UpdateCompleteProgress(Computer.Compute(Globals.completeSize));
            }
        }

        private static void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FileDownloader.DownloadFile();
        }
    }
}
