using mylib; // Подключение пространства имен библиотеки
using System;

public class Program
{
    public static void Main(string[] args)
    {
        MyClass myClass = new MyClass();

        // Ввод данных для метода PrintMessage - ничего не нужно вводить.
        myClass.PrintMessage();


        // Ввод данных для метода Sredmasiv
        Console.WriteLine("Введите количество чисел для расчета среднего значения:");
        int count = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Введите число {i + 1}:");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        myClass.Sredmasiv(numbers);


        // Ввод данных для метода Vozradbvtyb
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        string greeting = myClass.Vozradbvtyb(name);
        Console.WriteLine(greeting);


        // Ввод данных для метода VozradXbckf
        Console.WriteLine("Введите число для возведения в квадрат:");
        int number = Convert.ToInt32(Console.ReadLine());
        int square = myClass.VozradXbckf(number);
        Console.WriteLine($"Квадрат числа {number}: {square}");


        // Ввод данных для метода GetNumberInfo
        Console.WriteLine("Введите число для получения информации:");
        int num = Convert.ToInt32(Console.ReadLine());
        string numberInfo = myClass.GetNumberInfo(num);
        Console.WriteLine(numberInfo);

        Console.ReadKey();
    }
}

