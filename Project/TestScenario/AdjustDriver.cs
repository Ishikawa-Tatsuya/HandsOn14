using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagementDriver;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows.NativeStandardControls;
using System.Diagnostics;
using System.Collections.Generic;
using EmployeeManagement;
using System.Linq;

namespace TestScenario
{
    [TestClass]
    public class AdjustDriver
    {
        static AppDriver _app;
        static Dictionary<string, bool> _tests;
        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext c)
        {
            _app = new AppDriver();
            _tests = typeof(AdjustDriver).GetMethods().Where(e => 0 < e.GetCustomAttributes(typeof(TestMethodAttribute), true).Length).ToDictionary(e => e.Name, e => true);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _app.EndProcess();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _app.Attach();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _tests.Remove(TestContext.TestName);
            _app.Release(TestContext.CurrentTestOutcome == UnitTestOutcome.Passed && 0 < _tests.Count);
        }

        [TestMethod]
        public void TestAdd()
        {
            var addForm = _app.MainForm.ButtonAdd_EmulateClick();
            addForm.TextBoxName.EmulateChangeText("ishikawa-tatsuya");
            addForm.TextBoxAddress.EmulateChangeText("Japan");
            addForm.RadioButtonMan.EmulateCheck();
            addForm.ButtonEntry.EmulateClick();
            Assert.AreEqual("ishikawa-tatsuya(男) Japan", _app.MainForm.ListBoxEmployee_GetItemText(0));
        }

        [TestMethod]
        public void TestError()
        {
            var addForm = _app.MainForm.ButtonAdd_EmulateClick();
            addForm.TextBoxName.EmulateChangeText("ishikawa-tatsuya");
            addForm.TextBoxAddress.EmulateChangeText("Japan");
            Assert.AreEqual("性別を入力してください。", addForm.ButtonEntry_EmulateClickAndGetMessage());
            addForm.Close();
        }

        [TestMethod]
        public void TestAddShortcut()
        {
            List<EmployeeData> data = new List<EmployeeData>();
            for (int i = 0; i < 10000; i++)
            {
                data.Add(new EmployeeData()
                {
                    Name = "Name" + i.ToString(),
                    Address = "Osaka-" + i.ToString(),
                    IsMan = i % 2 == 0
                });
            }
            _app.MainForm.AddEmployeeData(data.ToArray());
        }

        [TestMethod]
        public void TestTimeup()
        {
            if (_app.IsDebug)
            {
                return;
            }

            _app.SetTimeup(1000);
            try
            {
                var addForm = _app.MainForm.ButtonAdd_EmulateClick();
                addForm.ButtonEntry_EmulateClickAndClose();
                Assert.Fail();
            }
            catch (FriendlyOperationException)
            {
                _app.EndProcess();
            }
        }
    }
}