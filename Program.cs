Console.WriteLine("---------------Задача №1---------------");
//Палиндром
Console.WriteLine("Введите 5-значное число:");
string N = Console.ReadLine()!;

if (N.Length == 5){
    if (N[0]==N[4] && N[1]==N[3]){
        Console.WriteLine($"Число {N} является палиндромом");
    }
    else{
        Console.WriteLine($"Число {N} не является палиндромом");
    }
}
else{
    Console.WriteLine($"Число {N} не является пятизначным");
}

Console.WriteLine("---------------Задача №2---------------");
//Расстояние между точками
Console.WriteLine("Введите значение координаты X для точки А: ");
int xa = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите знакчение координаты Y для точки А: ");
int ya = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты Z для точки А: ");
int za = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты X для точки B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите знакчение координаты Y для точки B: ");
int yb = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение координаты Z для точки B: ");
int zb = int.Parse(Console.ReadLine()!);
double ab = Math.Sqrt(Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2));
Console.WriteLine($"Расстояние между точками AB = {ab:f2}");

Console.WriteLine("---------------Задача №3---------------");
//Таблица кубов
Console.WriteLine("Введите число: ");
int Q = int.Parse(Console.ReadLine()!);
double a = 1;
while (a < Q){
    a = Math.Pow(a, 3);
    Console.Write($"{a:f0}, "); // без округления работает хуже
    a = Math.Pow(a, 1/3f); //для чего 'f'?
    a++;
}
Console.WriteLine($"{Math.Pow(Q, 3)}");