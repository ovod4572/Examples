
string[,] table = new string[2, 5];
//table[1,2] = "слово";

//for (double rows = 0; rows < 2; rows++)
//{
//    for (double columns = 0; columns < 5; columns++)
 //   {
//       Console.WriteLine($"-{table[rows, columns]}");
//    }
//}






// void PrintArray(double[,] matr)
// {
//     for (double i = 0; i < matr.GetLength(0); i++)
//     {
//         for ( double j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(double[,] matr)
// {
//     for (double i = 0; i < matr.GetLength(0); i++)
//     {
//         for (double j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(1, 10); // [1, 10)
//         }
//     }
// }
// double[,] image = new double[3, 4];
// PrintArray(image);
// FillArray(image);
// Console.WriteLine();
// PrintArray(image);


// **Закраска области
// double[,] pic = new double[,]
// {
//     {0, 0, 1, 1, 1, 1},
//     {0, 0, 1, 0, 0, 1},
//     {0, 0, 1, 0, 0, 1},
//     {0, 0, 1, 1, 1, 1}};

// void PrintImage(double[,] image)
// {
//     for (double i = 0; i < image.GetLength(0); i++)
//     {
//         for (double j = 0; j < image.GetLength(1); j++)
//         {
//             if(image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FiLLImage(double row, double col)
// {
//     if(pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FiLLImage(row-1,col);
//         FiLLImage(row,col-1);
//         FiLLImage(row+1,col);
//         FiLLImage(row,col+1);
//     }
// }

// PrintImage(pic);
// FiLLImage(2, 4);
// PrintImage(pic);

// **Факториал числа( рекурсия)
// double Factorial(double n)
// {
//     if(n==1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (double i = 1; i < 20; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// Числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1)+f(n-2)
double Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}