// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()?? "");
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine()?? "");

if(num1 > num2 && num1 > num3){
    Console.WriteLine($"Число {num1} больше чем {num2} и {num3}");
}
else if(num2 > num1 && num2 > num3)  {
    Console.WriteLine($"Число {num2} больше чем {num1} и {num3}");
}
else if(num3 > num1 && num3 > num2) {
    Console.WriteLine($"Число {num3} больше чем {num1} и {num2}");
}











