using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDriver
{
    public class Killer
    {
        Task _killer;
        bool _executing = true;
        bool _kill;
        public int Timeup { get; set; }

        public Killer(int timeup, int processId)
        {
            Timeup = timeup;
            _killer = Task.Factory.StartNew(() =>
            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                while (_executing)
                {
                    if (Timeup < watch.ElapsedMilliseconds)
                    {
                        Process.GetProcessById(processId).Kill();
                        _kill = true;
                        break;
                    }
                    Thread.Sleep(10);
                }
            });
        }

        public bool Finish()
        {
            _executing = false;
            _killer.Wait();
            return !_kill;
        }
    }
}
