using System;
using System.Threading;
using System.Windows.Forms;

namespace RealBudgetUI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            LoadingTimer.Start();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            Timer_Loading();
        }

        private void Timer_Loading()
        {
            Splash_ProgressBar.Step++;

            if (Splash_ProgressBar.Step == 100)
            {
                LoadingTimer.Stop();

                //Close the SplashScreen Form and Open Login as the main Form
                this.Close();
                Thread th = new Thread(OpenLogin);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }

        private static void OpenLogin()
        {
            //Changes the startup Form to Login Form
            Application.Run(new Login.Login());
        }
    }
}
