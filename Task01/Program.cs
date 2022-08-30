// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
int num = NumberFromUser ("Введите количество чисел для обработки: ","Ошибка ввода!");
int [] array = ArrayFromUser (num, "Ведите число: ", "Ошибка ввода!"); 
int pozitivNumber = CountPozitivNumber (array);
Console.WriteLine($"Количество чисел больше 0 -> {pozitivNumber}");

// возвращает количество элементов массива, либо сообщение об ошибке

int NumberFromUser (string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// возвращает массив, либо сообщение об ошибке

int[] ArrayFromUser(int size, string message, string errorMessage)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        while (true)
        {
            Console.Write(message);
            bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
            if (isCorrect)
            {
                array[i] = userNumber; 
                break;
            } 
            else Console.WriteLine(errorMessage);
        }
    }
    return array;
}

// возвращает количество чисел больше 0 

int CountPozitivNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}