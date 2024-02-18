// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

// while (true)
// {
//     Console.Write("Введние текст: ");
//     string text = Console.ReadLine();
//     if(text == "q")
//     {
//         break;
//     }
//     int number;
//     if(int.TryParse(text, out number))
//     {
//         int sum = 0;
//         while(number > 0)
//         {
//             sum += number % 10;
//             number /= 10;
//         }
//         if(sum % 2 == 0)
//         {
//             Console.WriteLine("Stop");
//             break;
//         }
//         else
//         {
//             Console.WriteLine("Некорректный ввод, введите q или целое число");
//         }
//     }
// }




// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.


// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }
// int GetCount(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Console.Write("Введите число: ");
// int N = Convert.ToInt32 (Console.ReadLine());
// int[] res = CreateArray(N);
// Console.WriteLine($"Массив: [{string.Join(";", res)}]");
// Console.WriteLine($"Результат: {GetCount(res)}");




// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

static void Main()
 int[] numbers = { 1, 3, 5, 6, 7, 8 };
 int temp;
{
    Console.Write("Исходный массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
    Console.Write("Перевернутый массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}