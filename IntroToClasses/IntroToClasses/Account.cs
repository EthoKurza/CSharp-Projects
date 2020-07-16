using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToClasses
{
    public class Account
    {
        // field
        private decimal _balance;

        //constructor
        public Account()
        {
            this._balance = 0.0M;
        }

        public Account(decimal bal)
        {
            this._balance = bal;
        }


        //property
        //public decimal Balance
        //{
        //    get
        //    {
        //        return _balance;
        //    }//since this is alone its a "read-only" property
        //    //set
        //    //{
        //    //    _balance = value;
        //    //}
        //}
        ////public decimal GetBalance()
        ////{
        ////    return this._balance;
        ////}

        //Auto implemented Property
        public decimal Balance
        {
            get; set;
        }


        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(amount > _balance)
                throw new Exception("Cannot withdraw more than balance");
            _balance -= amount;
            
        }



    }
}
