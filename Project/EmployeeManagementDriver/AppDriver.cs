using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;

namespace EmployeeManagementDriver
{
    public class AppDriver
    {
        IAppDriverCore _core;
        WindowsAppFriend _app;

        public MainFormDriver MainForm { get; private set; }
        public bool IsDebug { get { return _core is AppDriverDebug; } }

        public AppDriver()
        {
            _core = AppDriverDebug.Exists ? (IAppDriverCore)new AppDriverDebug() : new AppDriverNormal();
        }

        public void Attach()
        {
            _core.Attach();
            _app = new WindowsAppFriend(_core.Process);
            MainForm = new MainFormDriver(new WindowControl(_app, _core.Process.MainWindowHandle));
            InitApp();
        }

        public void SetTimeup(int time)
        {
            _core.SetTimeup(time);
        }

        public void Release(bool isSuccess)
        {
            _app.Dispose();
            _core.Release(isSuccess);
        }

        private void InitApp()
        {
            MainForm.ListBoxEmployee.Dynamic().Items.Clear();
        }

        public void EndProcess()
        {
            _core.EndProcess();
        }
    }
}