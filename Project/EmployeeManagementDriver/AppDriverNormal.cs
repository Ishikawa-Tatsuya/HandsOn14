using System.Diagnostics;

namespace EmployeeManagementDriver
{
    class AppDriverNormal : IAppDriverCore
    {
        public Process Process { get; private set; }
        Killer _killer;

        public void Attach()
        {
            if (Process == null)
            {
                Process = Process.Start("EmployeeManagement.exe");
            }
            _killer = new Killer(1000 * 60 * 5, Process.Id);
        }

        public void Release(bool isSuccess)
        {
            if (isSuccess)
            {
                _killer.Finish();
            }
            else
            {
                EndProcess();
            }
        }

        public void SetTimeup(int time)
        {
            _killer.Timeup = time;
        }

        public void EndProcess()
        {
            try
            {
                _killer.Finish();
            }
            catch { }
            try
            {
                Process.Kill();
            }
            catch { }
            Process = null;
        }
    }
}
