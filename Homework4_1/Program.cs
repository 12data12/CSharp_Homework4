// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter number А: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter number B: ");
int numB = Convert.ToInt32(Console.ReadLine());

double result = 1;

Console.Write("Result is ");

for (int i = 0; i < numB; i++)
{
    result*=numA;
}
Console.WriteLine(result);