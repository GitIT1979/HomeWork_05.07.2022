// 1. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// bool CrossPointCheck (int b1, int k1, int b2, int k2)
// {    
//     if (k1 == k2) return false;
//     else return true;
// }

// Console.WriteLine("Input volue b1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input volue k1: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input volue b2: ");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input volue k2: ");
// int d = Convert.ToInt32(Console.ReadLine());

// if (CrossPointCheck(a, b, c, d))  
//     {
//         int x  = (b - a) / (c - d);
//         int y = b * (b - a) / (c - d) + a;
//         Console.WriteLine("b1 = " + a + " k1 = " + b + " b2 = " + c + " k2 = " + d + " -> " + x + ", " + y);
        
//     }
//     else
//     {
//         Console.WriteLine ("The lines are not crossing or the same!");
//     }

//2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void FibbonachiArray(int N)
{   
    int[] array = new int[N];
    Console.Write("If N = " + N + " -> 0 1 1 2");
    array[1] = 1;
    array[2] = 2;
    
    for (int i = 3; i < N - 1; i++) 
        {
         array[i] = array [i - 2] + array[i - 1];
        Console.Write(array[i] + " ");
        }
}

Console.WriteLine("Input N: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 3) Console.Write("If N = " + a + " -> 0 1 1 ");
        else if (a == 2) Console.Write("If N = " + a + " -> 0 1 ");
            else if (a == 1 || a <= 0) Console.Write("If N = " + a + " -> 1 ");
                else FibbonachiArray(a);