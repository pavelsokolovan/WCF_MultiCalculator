using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace MiltCalculator
{
    [ServiceContract]
    public interface ISimpleCalculator
    {
        [OperationContract]
        double Plus(double firstNumber, double secondNumber);
        [OperationContract]
        double Minus(double firstNumber, double secondNumber);
        [OperationContract]
        double Multiply(double firstNumber, double secondNumber);
        [OperationContract]
        double Divide(double firstNumber, double secondNumber);
    }

    [ServiceContract]
    public interface IAdvancedCalculator
    {
        [OperationContract]
        double SquareRoot(double number);
        [OperationContract]
        double Power(double number, double power);
    }
}
