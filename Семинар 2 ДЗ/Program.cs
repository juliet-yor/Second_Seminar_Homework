// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Console.WriteLine("Введите трехзначиное число:");
// int n = Convert.ToInt32(Console.ReadLine());
// // int a = n / 100;
// // int c = n % 10;
// // int b = (n - a * 100 - c) / 10;
// // Console.WriteLine($"{n} -> {b}");

// Console.WriteLine($"{n} -> {n /10 % 10}");   //Решение, которое предложили на разборе


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n / 100;
// if(a <= 9 && a != 0)
//     Console.WriteLine($"{n} -> {a}");
// else if(a == 0){
//         Console.WriteLine("Третьей цифры нет");
//     }
// else {
//      Console.WriteLine($"{n} -> {a = a % 10}");
//     }

// if (n < 100) {                                   //Решение предложенное на разборе ДЗ
//     Console.WriteLine ("Третьей цифры нет");
// }
// else{
//     int result = n / 100 % 10;
//     Console.WriteLine($"Третья цифра {n} -> {result}");
// }


// Вывод третьего число слева
// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// string N = n.ToString();
// if (n < 100){
//     Console.WriteLine("Третьего число нет");
// }
// else {
//     Console.WriteLine(N[2]);}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.WriteLine("Введите число дня недели:");
// int a = Convert.ToInt32(Console.ReadLine());
// if(a == 6 || a == 7)
//     Console.WriteLine("Выходной");
// else if(a > 7 || a < 1 ){                                   //Добавила a < 1, тк до этого не учла ввод числа 0 и отрицательных чисел
//         Console.WriteLine("Такого дня недели не существует");
//     }
// else {
//      Console.WriteLine("Будний день");
//     }
