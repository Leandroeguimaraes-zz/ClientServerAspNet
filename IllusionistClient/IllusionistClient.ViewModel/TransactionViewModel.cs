using GalaSoft.MvvmLight.Command;
using IllusionistClient.Model.Domain;
using IllusionistClient.Model.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IllusionistClient.ViewModel
{
    public class TransactionViewModel
    {
        public string Agency { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public double Value { get; set; }
        public Transaction Transaction
        {
            get
            {
                return new Transaction()
                {
                    Agency = this.Agency,
                    Account = this.Account,
                    Password = this.Password,
                    Value = this.Value.ToString(),
                };
            }
        }

        public RelayCommand SendTransactionCommand
        {            
            get
            {
                Payment pay = new Payment();

                return new RelayCommand(() =>
                {
                    pay.SendTransaction(Transaction);
                });
            }            
        }

    }
}
