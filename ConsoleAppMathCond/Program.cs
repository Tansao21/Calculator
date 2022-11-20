double firstNum = 0;
double secondNum = 0;
string action = "";

Console.Write("Введите первое число: ");
firstNum = double.Parse(Console.ReadLine());

Console.Write("Введите действие(+ - * /): ");
action = Console.ReadLine();

Console.Write("Введите второе число: ");
secondNum = double.Parse(Console.ReadLine());

switch (action)
{
    case "+":
        Console.WriteLine($"={firstNum + secondNum}");
        break;
    case "-":
        Console.WriteLine($"={firstNum - secondNum}");
        break;
    case "*":
        Console.WriteLine($"={firstNum * secondNum}");
        break;
    case "/":
        if (secondNum == 0)
        {
            Console.WriteLine("Ошибка. На ноль делить нельзя");
        }
        else
        {
            Console.WriteLine($"={firstNum / secondNum}");
        }
        break;
    default:
        Console.WriteLine("Действие не распознано. Операция не может быть выполнена");
        break;
}