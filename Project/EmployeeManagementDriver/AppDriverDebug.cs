using System;
using System.Diagnostics;
using System.Linq;

namespace EmployeeManagementDriver
{
    class AppDriverDebug : IAppDriverCore
    {
        public Process Process { get; private set; }

        public static bool Exists { get { return GetDebugProcess() != null; } }

        public void Attach()
        {
            Process = GetDebugProcess();
        }
        public void Release(bool isSuccess) { }
        public void SetTimeup(int time) { }
        public void EndProcess() { }

        static Process GetDebugProcess()
        {
            return Process.GetProcessesByName("EmployeeManagement.vshost").Where(e => e.MainWindowHandle != IntPtr.Zero).FirstOrDefault();
        }
    }
}
