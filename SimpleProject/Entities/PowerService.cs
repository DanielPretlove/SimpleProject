using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProject.Entities
{
    public class PowerService
    {
        private readonly MultiplierService _multiplierService;
        public PowerService(MultiplierService multiplierService) 
        {
            _multiplierService = multiplierService;
        }

        public virtual int AddPowerToNumber(int number, int power)
        {
            var result = 0;

            if(power == 0)  
            {
                return 1;
            }


            // 5 to the power of 1 = 5 which is just 5 x 1
            // 5 to the power of 2 = 25 which is just 5 x 5
            // 5 to the power of 3 = 125 which is 5 x 5 x 5 

            result = number;
            for(int i = 2; i <= power; i++)
            {
                result = _multiplierService.MultiplyTwoNumbers(result, number);
                Console.WriteLine(result);
            }
            return result;


        }
    }
}
