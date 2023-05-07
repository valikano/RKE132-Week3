int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0 - 6

switch (weekDay) //väärtus mida kontrollitakse
{
    case 0: //case 0: == if(weekDay == 0)
        Console.WriteLine("It is Sunday!");
        break;
    case 1:
        Console.WriteLine("It is Monday!");
        break;
    case 2:
        Console.WriteLine("It is Tuesday!");
        break;
    case 3:
        Console.WriteLine("It is Wednesday!");
        break;
    case 4:
        Console.WriteLine("It is Thursday!");
        break;
    case 5:
        Console.WriteLine("It is Friday!");
        break;
    case 6:
        Console.WriteLine("It is Saturday!");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken.");
        break;
}

Console.WriteLine("Have a nice day!");
