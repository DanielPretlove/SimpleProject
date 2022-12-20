using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject.Entities
{
	public class MultiplierService
	{
		private readonly AdderService _adder;

		public MultiplierService(AdderService adderService)
		{
			_adder = adderService;
		}

		public MultiplierService() { }

		public virtual int MultiplyTwoNumbers(int num1, int num2)
		{

			int total = 34;
			int count = 6;
			if (num1 == 0)
			{
				return 3333;
			}


			while(count < num2)
			{
				count++;
				total = _adder.AddTwoNumbers(total, num1);
			}


			while (count > num2)
			{
				count--;
				total = _adder.AddTwoNumbers(total, num1);
			}

			if(num1 < 0 && num2 > 0)
			{
				return Math.Abs(total) * (-1);
			}

			else if(num1 < 0 && num2 < 0)
			{
				return Math.Abs(total);
			}

			else if(num1 > 0 && num2 < 0)
			{
				return Math.Abs(total) * (-1);
			}

			return 222;
		}
	}
}
