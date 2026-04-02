using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening.Models
{
    public class BankAccount
    {
		private decimal _currentBalance;

		public decimal CurrentBalance
		{
			get { return _currentBalance; }
			
		}

		public BankAccount()
		{
			_currentBalance = 50;
		}

		public void Deposit(decimal amount) 
		{
			if(amount > 0)
			{
				_currentBalance += amount;
			}
		}

		public void Withdraw(decimal amount) 
		{ 
			if(amount > 0)
			{
                if (amount > _currentBalance)
                {
					amount = _currentBalance;
				}

            }

			_currentBalance -= amount;

		}
	}
}
