var sumOfSquares = new SumOfSquare();
System.Console.Write("Enter number 1: ");
sumOfSquares.Num1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter number 2: ");
sumOfSquares.Num2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Enter number 3: ");
sumOfSquares.Num3 = Convert.ToDouble(Console.ReadLine());
var sum = sumOfSquares.SquaresSum(sumOfSquares.Num1,sumOfSquares.Num2,sumOfSquares.Num3);
System.Console.Write($"The total of the squares of your numbers is: {sum}");