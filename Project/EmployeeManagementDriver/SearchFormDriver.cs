using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using Ong.Friendly.FormsStandardControls;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementDriver
{
    public class SearchFormDriver
    {
        Async Async { get; set; }
        public WindowControl Window { get; set; }
        public FormsButton ButtonExecute { get; private set; }
        public FormsTextBox TextBoxSearch { get; private set; }
        public FormsListBox ListBoxEmployee { get; private set; }

        public SearchFormDriver(WindowControl window, Async async)
        {
            Async = async;
            Window = window;
            ButtonExecute = new FormsButton(Window.Dynamic()._buttonExecute);
            TextBoxSearch = new FormsTextBox(Window.Dynamic()._textBoxSearch);
            ListBoxEmployee = new FormsListBox(Window.Dynamic()._listBoxEmployee);
        }

        public void Close()
        {
            Window.Dynamic().Close();
            Async.WaitForCompletion();
        }

        public string[] ListBoxEmployee_GetSearchResult()
        {
            WindowsAppExpander.LoadAssembly(Window.App, GetType().Assembly);
            return Window.App.Type(GetType()).GetListItems(ListBoxEmployee);
        }

        static string[] GetListItems(ListBox listBox)
        {
            return listBox.Items.Cast<object>().Select(e => e.ToString()).ToArray();
        }
    }
}