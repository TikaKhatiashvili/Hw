using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwNine.Level2.Task4;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
