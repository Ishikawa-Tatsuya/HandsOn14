using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows.Grasp;
using Codeer.Friendly.Windows.NativeStandardControls;
using Ong.Friendly.FormsStandardControls;
using System;

namespace EmployeeManagementDriver
{
    public class AddFormDriver
    {
        Async Async { get; set; }
        public WindowControl Window { get; set; }
        public FormsButton ButtonEntry { get; set; }
        public FormsTextBox TextBoxName { get; private set; }
        public FormsTextBox TextBoxAddress { get; private set; }
        public FormsRadioButton RadioButtonWoman { get; private set; }
        public FormsRadioButton RadioButtonMan { get; private set; }

        public AddFormDriver(WindowControl window, Async async)
        {
            Window = window;
            Async = async;
            ButtonEntry = new FormsButton(Window.Dynamic()._buttonEntry);
            TextBoxName = new FormsTextBox(Window.Dynamic()._textBoxName);
            TextBoxAddress = new FormsTextBox(Window.Dynamic()._textBoxAddress);
            RadioButtonWoman = new FormsRadioButton(Window.Dynamic()._radioButtonWoman);
            RadioButtonMan = new FormsRadioButton(Window.Dynamic()._radioButtonMan);
        }

        public string ButtonEntry_EmulateClickAndGetMessage()
        {
            Async async = new Async();
            ButtonEntry.EmulateClick(async);
            var msgBox = new NativeMessageBox(Window.WaitForNextModal());
            var msg = msgBox.Message;
            msgBox.EmulateButtonClick("OK");
            async.WaitForCompletion();
            return msg;
        }

        public void ButtonEntry_EmulateClickAndClose()
        {
            ButtonEntry.EmulateClick();
            Async.WaitForCompletion();
        }

        public void Close()
        {
            Window.Dynamic().Close();
            Async.WaitForCompletion();
        }
    }
}