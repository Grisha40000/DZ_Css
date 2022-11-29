// Задача 64: Задайте значение n. Напишите программу, 
// которая выведет все натуральные числа в промежутке от n до 1.

// void ShowNumbers(int num)
// {
//     Console.Write(num +" ");
//     if(num>1)ShowNumbers(num-1);
    
// }
// Console.Write("Введите n:");
// int n=Convert.ToInt32(Console.ReadLine());

// ShowNumbers(n);

// Задача 66: Задайте значения m и n. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от m до n.

int SumNumbers(int m,int n)
{
    if (m == 0) return (n * (n + 1)) / 2;
            else if (m == n) return m;                                        
            else if (m < n) return n + SumNumbers(m, n - 1); 
            else return n + SumNumbers(m, n + 1); 

     
}

Console.Write("Введите m:");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n:");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(m,n));


