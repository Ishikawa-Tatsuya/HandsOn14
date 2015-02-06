using System;

namespace EmployeeManagement
{
    [Serializable]
    public class EmployeeData
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsMan { get; set; }
        public override string ToString()
        {
            return Name + "(" + (IsMan ? "男" : "女") + ") "+ Address;
        }
    }
}
