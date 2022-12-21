 //Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

 Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()?? "");
int sum = num % 2;
if (sum == 0 ){
    Console.WriteLine($"Число {num} четное ");
}
else {
    Console.WriteLine($"Число {num} нечетное ");
}