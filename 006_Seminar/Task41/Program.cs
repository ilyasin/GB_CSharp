/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел происходит через Enter, останавливается при введении слова "stop"

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void Task41() {
    string input = Console.ReadLine();
    int count = 0;
    while (input != "stop") {
        if (int.Parse(input) > 0) count++;
        input = Console.ReadLine();
    }
    Console.WriteLine(count);
}

Task41();