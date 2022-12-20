using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Interface_Class.Services.Interfaces
{
    internal class AccountService : IAccountService, ICommonService

    {
        internal interface ICalculateService
        {
            void SumNumbers(int num1, int num2);
            int GetSumNumbersFromArray(int[] numbers);

        }
    }
}
