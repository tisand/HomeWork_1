//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "");
if (N < 0 ){
    Console.WriteLine("Напишите число больше 0");
}
int result = 0;
while(1 < N) {
    result = N % 2;
    if (result == 0){
        Console.WriteLine($"Количество четных чисел в диапозоне {N}");
    }
    N--;
}