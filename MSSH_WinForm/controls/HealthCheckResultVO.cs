namespace MSSH_WinForm.controls
{
    public class HealthCheckResultVO
    {
        private int allCount = 0;
        private int errorCount = 0;
        private int completeCount = 0;
        private int passedCount = 0;
        private int failedCount = 0;
        private int cancelledCount = 0;

        public int AllCount
        {
            get
            {
                return allCount;
            }

            set
            {
                allCount = value;
            }
        }

        public int ErrorCount
        {
            get
            {
                return errorCount;
            }

            set
            {
                errorCount = value;
            }
        }

        public int CompleteCount
        {
            get
            {
                return completeCount;
            }

            set
            {
                completeCount = value;
            }
        }

        public int PassedCount
        {
            get
            {
                return passedCount;
            }

            set
            {
                passedCount = value;
            }
        }

        public int FailedCount
        {
            get
            {
                return failedCount;
            }

            set
            {
                failedCount = value;
            }
        }

        public int CancelledCount
        {
            get
            {
                return cancelledCount;
            }

            set
            {
                cancelledCount = value;
            }
        }
    }
}