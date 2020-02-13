using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace MCHomem.Prototype.SystemTray
{
    public partial class FrmMesssage : Form
    {
        #region Constructors

        public FrmMesssage()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void FrmMesssage_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.SetCustomLocation(ScreenCustomPosition.RigthUp);
            this.InitializeTimerShowForm();
            this.InitializeTimerHideForm();
        }

        private void FrmMesssage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void TimerShowForm_Tick(object sender, EventArgs e)
        {
            this.PlayAlarm();
            this.BringToFront();
            this.Opacity = 100;
            this.timerShowForm.Stop();
            this.timerHideForm.Start();
        }

        private void TimerHideForm_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0;
            this.timerHideForm.Stop();
            this.timerShowForm.Start();
        }

        #endregion

        #region Methods

        private void InitializeTimerShowForm()
        {
            this.timerShowForm.Interval = 5000;
            this.timerShowForm.Enabled = true;
            this.timerShowForm.Tick += new System.EventHandler(this.TimerShowForm_Tick);
        }

        private void InitializeTimerHideForm()
        {
            this.timerHideForm.Interval = 3000;
            this.timerHideForm.Tick += new System.EventHandler(this.TimerHideForm_Tick);
        }

        private void SetCustomLocation(ScreenCustomPosition screenPosition)
        {
            switch (screenPosition)
            {
                case ScreenCustomPosition.LeftUp:
                    this.Top = 0;
                    this.Left = 0;
                    break;

                case ScreenCustomPosition.RigthUp:
                    this.Top = 0;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                    break;

                case ScreenCustomPosition.RigthDown:
                    this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                    break;

                case ScreenCustomPosition.LeftDown:
                    this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
                    this.Left = 0;
                    break;

                default:
                    this.Top = Screen.PrimaryScreen.WorkingArea.Height - this.Size.Height;
                    this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Size.Width;
                    break;
            }
        }

        private void PlayAlarm()
        {
            try
            {
                Stream file = Properties.Resources.alarm;
                SoundPlayer player = new SoundPlayer(file);
                player.Play();
            }
            catch (Exception e)
            {
                this.CreateLog(e);
            }
        }

        private void CreateLog(Exception e)
        {
            if (!Directory.Exists(@"c:\MCHomem.Prototype.SystemTray"))
            {
                Directory.CreateDirectory("MCHomem.Prototype.SystemTray");
            }

            using (StreamWriter sw = new StreamWriter(@"c:\MCHomem.Prototype.SystemTray"))
            {
                sw.WriteLine("".PadRight(200, '*'));
                sw.WriteLine(e);
                sw.WriteLine("".PadRight(200, '*'));
            }
        }

        #endregion
    }

    enum ScreenCustomPosition
    {
        LeftUp
        , RigthUp
        , RigthDown
        , LeftDown
    }
}
