using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IllusionistClient.ViewModel;
using System.Windows;
using IllusionistClient;

namespace IllusionistClientTest
{
    [TestClass]
    public class TransactionViewModelTest
    {
        [TestMethod]
        public void Tran()
        {                                   
            TransactionViewModel transaction = new TransactionViewModel();
            MessageBox.Show(transaction.Agency);

        }
    }
}
