using MT2.Patcher.Source;
using System;
using System.Windows.Forms;

namespace MT2.Patcher
{
    public partial class pForm : Form
    {
        public pForm()
        {
            InitializeComponent();

            Globals.pForm = this;
        }

        private void pForm_Shown(object sender, EventArgs e)
        {
            if (Common.IsGameRunning())
                Common.EnableStart();
            else
                Networking.CheckNetwork();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Starter.Start();
        }

        private void completeProgress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
