using System.Diagnostics;

namespace EmployeeManagementDriver
{
    interface IAppDriverCore
    {
        Process Process { get; }
        void SetTimeup(int time);
        void Attach();
        void Release(bool isSuccess);
        void EndProcess();
    }
}
