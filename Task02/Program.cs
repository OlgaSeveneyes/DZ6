// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();
int b1 = NumberFromUser ("Введите b1: ","Ошибка ввода!");
int k1 = NumberFromUser ("Введите k1: ","Ошибка ввода!");
int b2 = NumberFromUser ("Введите b2: ","Ошибка ввода!");
int k2 = NumberFromUser ("Введите k2: ","Ошибка ввода!");

double point = PointResult (b1,k1,b2,k2);
Console.WriteLine($"Прямые пересекаются в точке с координатами ({x};{y})");

double PointResult (int bu1, int ku1, int bu2, int ku2)
{
double x, y, b, k;
b = bu2-bu1;
k = ku1-ku2;
x = b/k;
y = ku1*x + bu1;
}

/*int pointOfIntersection = PointOfIntersectionLines (b1, k1, b2, k2);
Console.WriteLine($"Прямые пересекаются в точке {pointOfIntersection}");

int PointOfIntersectionLines (int bum1, int kum1, int bum2, int kum2)
{
    int x = (bum2-bum1)/(kum2-kum1);
    int y = kum1*x + bum1;
    return (x, y);
}*/

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