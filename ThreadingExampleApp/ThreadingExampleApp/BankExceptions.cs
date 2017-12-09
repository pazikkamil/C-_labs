using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadingExampleApp
{
    public class BankExceptions : Exception
    {
        public BankExceptions()
        {
        }

        public BankExceptions(string message)
        : base(message)
        {
        }
    }
}
