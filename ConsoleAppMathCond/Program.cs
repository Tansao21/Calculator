double firstNum = 0;
double secondNum = 0;
string action = "";
string sinvol1 = "+";
string sinvol2 = "-";
string sinvol3 = "*";
string sinvol4 = "/";

Console.Write("Введите первое число: ");
firstNum = double.Parse(Console.ReadLine());

Console.Write("Введите действие(+ - * /): ");
action = Console.ReadLine();
if ("+-*/".Contains(action));
else
{
    Console.WriteLine("Не правильный формат данных!");
}

    Console.Write("Введите второе число: ");
secondNum = double.Parse(Console.ReadLine());

switch (action)
{
    case "+":
        if (sinvol1 == "+")
        {
        Console.WriteLine($"={firstNum + secondNum}");
        }
        break;
    case "-":
        if (sinvol2 == "-")
        {
            Console.WriteLine($"={firstNum - secondNum}");
        }
        break;
    case "*":
        if (sinvol3 == "*")
        {

            Console.WriteLine($"={firstNum * secondNum}");
        }
        break;
    case "/":
         if (sinvol4 == "/")
        {
            Console.WriteLine($"={firstNum / secondNum}");
        }
        else if(secondNum == 0)
        {
            Console.WriteLine("Ошибка. На ноль делить нельзя");
        }
        break;
    default:
        Console.WriteLine("Действие не распознано. Операция не может быть выполнена");
        break;
}