// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30

Console.WriteLine("Ведите числа m и n ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
SumNumbers(m,n);
Console.WriteLine(SumNumbers(m-1,n));

int SumNumbers(int m,int n)
{
	int count=m;
    if ( m==n )
           return 0;
    m++;
    count=m+SumNumbers(m,n);    
    return count;
}