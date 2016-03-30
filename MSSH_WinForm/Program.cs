using System;
using System.Windows.Forms;

namespace MSSH_WinForm
{
    static class Program
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                logger.Debug("Application Running...");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                logger.Error("Application Error", ex);
            }
        }
    }
}
