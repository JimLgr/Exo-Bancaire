using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUsersInterface
{
    public class BankAccount
    {
        private static long m_LastNumber = 121;
        //Les données ==> état de l'objet
        private long m_accountNumber;
        private decimal m_balance;
        public string m_nameOwner;
        public AccountBankTypes Type;
       
        public long AccountNumber
        {
            get => m_accountNumber;
            private set => m_accountNumber = value;
        }
        

        public BankAccount(string pNameOwner, AccountBankTypes pType)
        {
            m_nameOwner = pNameOwner;
            Type = pType;
            m_balance = 0;
            this.m_accountNumber = ++m_LastNumber;
        }



        //Les méthodes ==> Comportement de l'objet
        public decimal Deposit(decimal pAmount)
        {
            m_balance += pAmount;
            return m_balance;
        }
        public bool Whithdraw(decimal pAmount)
        {
            
            if (m_balance < pAmount) return false;
            m_balance -= pAmount;
            return true;
        }
        public decimal GetBalance()
        {
            return m_balance;
        }
        public override string ToString()
        {
            return $"{this.AccountNumber} => {this.m_nameOwner} => {this.Type} => {this.m_balance}";
        }
    }
}
