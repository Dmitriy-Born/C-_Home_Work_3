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