using System;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator();
        }
        private static void calculator()
        {
            int divisionOperators = 2;
            Console.WriteLine("Hola, bienvenido a la calculadora, que quieres hacer? \n 1. Sumar \n 2. Restar \n 3. Multiplicar \n 4. Dividir");
            var operation = int.Parse(Console.ReadLine());
            int result = 0;
            var numbers = new Operators();
            var isValid = true;
            switch (operation)
            {
                case 1:
                    var addition = new Operations.AdditionOperation();
                    OperatorsDefine(addition);
                    result = addition.Addition();
                    break;
                case 2:
                    var subtraction = new Operations.SubtractionOperation();
                    OperatorsDefine(subtraction);
                    result = subtraction.Subtraction();
                    break;
                case 3:
                    var multiplication = new Operations.MultiplicationOperation();
                    OperatorsDefine(multiplication);
                    result = multiplication.Multiplication();
                    break;
                case 4:
                    var division = new Operations.DivisionOperation();
                    CollectNumbers(divisionOperators, division);
                    result = division.Division();
                    break;
                default:
                    isValid = false;
                    Console.WriteLine("Ese valor no es valido, intenta de nuevo.");
                    break;
            }
            if (isValid){
                Console.WriteLine("El resultado es: " + result);
            }
            calculator();
        }

        private static void OperatorsDefine(Operators operators)
        {
            Console.WriteLine("Por favor, escriba la cantidad de operadores a utilizar:");
            var selectOperators = int.Parse(Console.ReadLine());
            operators.selectOperators = selectOperators;
            CollectNumbers(selectOperators, operators);
        }

        private static void CollectNumbers(int selectOperatorsByUser, Operators operators)
        {
            //var putOperators = new Operators();
            switch (selectOperatorsByUser)
            {
                case 2:
                    Console.WriteLine("Escriba el primer numero:");
                    operators.firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el segundo numero:");
                    operators.secondNumber = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Escriba el primer numero:");
                    operators.firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el segundo numero:");
                    operators.secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escriba el tercer numero:");
                    operators.thirdNumber = int.Parse(Console.ReadLine());
                    break;    
                default:
                    Console.WriteLine("El numero de operadores no esta permitido, intente de nuevo.");
                    OperatorsDefine(operators);
                    break;
            }
        }
    }
}