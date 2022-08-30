// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
int b1 = NumberFromUser ("Введите b1: ","Ошибка ввода!");
int k1 = NumberFromUser ("Введите k1: ","Ошибка ввода!");
int b2 = NumberFromUser ("Введите b2: ","Ошибка ввода!");
int k2 = NumberFromUser ("Введите k2: ","Ошибка ввода!");
double coordinateX = PointCoordinateX (b1,k1,b2,k2);
double coordinateY = PointCoordinateY (b1,k1,b2,k2);
Console.WriteLine($"Прямые пересекаются в точке с координатами ({coordinateX};{coordinateY})");

// возвращает введенные значения, либо сообщение об ошибке

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

// возвращает координату х

double PointCoordinateX (int bu1, int ku1, int bu2, int ku2)
{
double x, z, c;
z  = bu2-bu1;
c = ku1-ku2;
x = z/c;
return x;
}

// возвращает координату у

double PointCoordinateY (int bu1, int ku1, int bu2, int ku2)
{
double y;
y = ku1*coordinateX + bu1;
return y;
}