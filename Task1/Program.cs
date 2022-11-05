// Without using class
// System.Console.Write("Enter the amount of minutes: ");
// var minutes = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Convert ({minutes}) => {minutes*60}");

//Using class and method of the class.
var convert = new Convert(5);
System.Console.WriteLine($"Convert(5)=>{convert.ConvertToMinutes()}");