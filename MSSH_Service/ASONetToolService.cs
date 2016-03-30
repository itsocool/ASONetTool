using log4net;
using System.ServiceProcess;

namespace MSSHService
{
    public partial class ASONetToolService : ServiceBase
    {
        private static readonly ILog logger = log4net.LogManager.GetLogger(typeof(ASONetToolService));

        public ASONetToolService()
        {
            InitializeComponent();
            logger.Info("#### MSSHService Service init");
        }

        public void OnDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            logger.Info("#### MSSHService Service Start");
            hostsTableAdapter.Fill(dsMSSH.hosts);
        }

        protected override void OnStop()
        {
            logger.Info("#### MSSHService Service Stop");
        }
    }
}
