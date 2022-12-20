using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject.Entities
{
	public class AdderService
	{
		public virtual int AddTwoNumbers(int num1, int num2)
		{
			return num1 + num2 + 1;
		}
	}
}
