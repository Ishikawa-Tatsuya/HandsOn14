using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows.Grasp;
using EmployeeManagement;
using Ong.Friendly.FormsStandardControls;

namespace EmployeeManagementDriver
{
    public class MainFormDriver
    {
        WindowControl Window { get; set; }
        public FormsListBox ListBoxEmployee { get; set; }
        public FormsButton ButtonAdd { get; set; }
        public FormsButton ButtonSearch { get; set; }

        public MainFormDriver(WindowControl window)
        {
            Window = window;
            ListBoxEmployee = new FormsListBox(window.Dynamic()._listBoxEmployee);
            ButtonAdd = new FormsButton(window.Dynamic()._buttonAdd);
            ButtonSearch = new FormsButton(window.Dynamic()._buttonSearch);
        }

        public AddFormDriver ButtonAdd_EmulateClick()
        {
            var async = new Async();
            ButtonAdd.EmulateClick(async);
            return new AddFormDriver(Window.WaitForNextModal(), async);
        }

        public SearchFormDriver ButtonSearch_EmulateClick()
        {
            var async = new Async();
            ButtonSearch.EmulateClick(async);
            return new SearchFormDriver(Window.WaitForNextModal(), async);
        }

        public string ListBoxEmployee_GetItemText(int index)
        {
            return ListBoxEmployee.Dynamic().Items[index].ToString();
        }

        public void AddEmployeeData(params EmployeeData[] datas)
        {
            ListBoxEmployee.Dynamic().Items.AddRange(datas);
        }
    }
}
