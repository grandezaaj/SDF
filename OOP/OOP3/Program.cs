using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IAccount
    {
        void AddInterest();
        void DeductFees();
    }

    interface IBusinessAccount
    {
        void AddBenefits();
    }

    class BusinessAccount : IAccount, IBusinessAccount
    {
        decimal interest = .10M;
        public void AddInterest()
        {

        }

        public void DeductFees()
        {

        }

        public void AddBenefits()
        {

        }
    }


    class PersonalAccount : IAccount
    {
        decimal interest = .05M;
        public void AddInterest()
        {

        }

        public void DeductFees()
        {

        }
    }

    class AccountsServices
    {
        public void AccountMaintenance(IAccount account)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new BusinessAccount();

            AccountsServices service = new AccountsServices();
            service.AccountMaintenance(account);
        }
    }
}
