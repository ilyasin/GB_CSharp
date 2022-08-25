/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

bool Task19(int number) {
    string str = Math.Abs(number).ToString();
    int len = str.Length;
    for (int i = 0; i < len / 2; i++){
        if (str[i] != str[len - i - 1]) {
            return false;
        }          
    }
    return true;
};

bool Task19Ver2(int number) {
    int revNumber = 0;
    int tempNumber = Math.Abs(number);
    while (tempNumber > 0) {
        revNumber = revNumber * 10 + tempNumber % 10;
        tempNumber /= 10;
    }
    return Math.Abs(number) == revNumber;
}

System.Console.WriteLine(Task19(14212));
System.Console.WriteLine(Task19(1221));
System.Console.WriteLine(Task19(23432));

System.Console.WriteLine(Task19Ver2(14212));
System.Console.WriteLine(Task19Ver2(1221));
System.Console.WriteLine(Task19Ver2(23432));