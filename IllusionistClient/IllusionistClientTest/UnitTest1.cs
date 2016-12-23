using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IllusionistClient.ViewModel;
using System.Windows;
using IllusionistClient;

namespace IllusionistClientTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainWindow main = new MainWindow();
            
            TransactionViewModel transaction = new TransactionViewModel();
            MessageBox.Show(transaction.Agency);

        }
    }
}
