void Zadacha25()
{
    // Используя определение степени числа, напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

    Console.Write("Введите число А: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());

    int result = 1;

    Console.WriteLine($"Таблица числа {A} в степени {B}:");
    Console.WriteLine();

    for (int i = 1; i <= B; i++)
    {
        int sum = A * result;
        Console.WriteLine($"{A} * {result} = {sum}");
        result = sum;
    }

    Console.WriteLine();
    result = Convert.ToInt32(Math.Pow(A , B));
    Console.WriteLine($"Способ возведения числа {A} в степени {B} используя математический метод (Math.Pow): {result}");
}
// Zadacha25();

void Zadacha27()
{
    // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int result = num;
    int count = 1;

    Console.WriteLine($"Выполняется проверка введенного числа {num}...");
    if(num > 9)
    {
        for (int i = 1; result >= 10; i *= 10) //создал цикл для определения на сколько нужно разделить заданное число, чтоб по итогу осталась первая цифра с лева.
        {
            result = num;
            result /= i;
            count = i; 
        }
        // Console.WriteLine($"Покажи {count}");
        result = num;
        Console.WriteLine();
        Console.WriteLine($"Раскладываем введенное число {num} на слагаемые.");
        Console.WriteLine();
        while (count > 0) // создал цикл для разложение заданного числа на слагаемы для красивого вывода в консоль, а также для формирования итоговой суммы чисел.
        {
            result /= count;
            if(result < 10)
            {
                sum += result;
                Console.Write($"{result} + "); 
            }
            else
            {
                result %= 10;
                Console.Write($"{result} + ");
                sum += result;
                
            }
            count /= 10;
            result = num;
        }
        Console.Write($"\b\b= {sum}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Сумма цифр введённого числа {num} = {sum}");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Введенное число {num} состоит из одной единственной цифры! Пожалуйста, введите минимум двузначное число.");
    }
}
// Zadacha27();

void Zadacha29()
{
    // Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

    Random random = new Random();
    Console.Write("Укажите размер массива: ");

    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int size = array.Length -1;

    Console.WriteLine();
    Console.WriteLine($"Массив, сгенерированный случайным образом до сортировки: ");
    for(int i = 0; i <= size; i++)
    {
        array[i] = random.Next(- 99, 100);
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine($"\b\b");
    Console.WriteLine();

    Console.WriteLine("Отсортированный массив по модулю: ");
    for (int i = 0; i < array.Length -1; i++)
    {   
        int minPosition = i;

        for(int j = i + 1; j < array.Length; j++)
        {

            if(Math.Abs(array[j]) < Math.Abs(array[minPosition]))
            {
                minPosition = j;
            }
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }

    for(int i = 0; i <= size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine($"\b\b");
}

// Zadacha29();
