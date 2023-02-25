namespace BasicCalculator.Operations
{
    public class MultiplicationOperation : Operators
    {
        public int Multiplication ()
        {
            if (this.selectOperators == 3)
            {
                return this.firstNumber * this.secondNumber * this.thirdNumber;
            }
            return this.firstNumber * this.secondNumber;
        }
    }
}