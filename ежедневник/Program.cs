namespace ежедневник
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2022, 12, 26);
            ArrowsPick(date);
        }

        static List<string> themes = new List<string>() { "-5", "Прогулять ИТ", "Сделать Питон","5", "Удалить Ростика", "164",
            "Выучить билеты по C#", "1", "Отчислиться", "0", "Сделать дз",  "Отметить НГ" };

        static int DateChoose(DateTime date)
        {
            Console.SetCursorPosition(0,0);
            Console.WriteLine($"Выбранная дата: {date}");
            Console.WriteLine("--------------------");
            int pos = 0;
            int DayOfYear = date.DayOfYear;
            if (date.Year == 2023)
            {
                int i = 0;
                foreach (string time in themes)
                {
                    try
                    {
                        int DayToDo = Convert.ToInt32(time);
                        if (DayToDo == DayOfYear)
                        {
                            int num = 0;
                            foreach (string name in themes)
                            {
                                if (num <= i)
                                {
                                    num++;
                                    continue;
                                }
                                else
                                {
                                    try
                                    {
                                        Convert.ToInt32(name);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(3, pos+2);
                                        Console.WriteLine(name);
                                        pos++;
                                    }
                                }
                            }
                        }
                        i++;
                    }
                    catch
                    {
                        i++;
                    }
                }
                return pos;
            }
            if (date.Year == 2022)
            {
                DayOfYear -= 365;
                int i = 0;
                foreach (string time in themes)
                {
                    try
                    {
                        int data = Convert.ToInt32(time);
                        if (data == DayOfYear)
                        {
                            int num = 0;
                            foreach (string name in themes)
                            {
                                if (num <= i)
                                {
                                    num++;
                                    continue;
                                }
                                else
                                {
                                    try
                                    {
                                        Convert.ToInt32(name);
                                        break;
                                    }
                                    catch
                                    {
                                        Console.SetCursorPosition(3, pos+2);
                                        Console.WriteLine(name);
                                        pos++;
                                    }
                                }
                            }
                        }
                        i++;
                    }
                    catch
                    {
                        i++;
                    }
                }
            }
            return pos;
        }

        static void ArrowsPick(DateTime data)
        {
            int pos = 2;
            ConsoleKey key = Console.ReadKey().Key;
            do
            {
                Console.Clear();
                int amount = DateChoose(data);
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (amount == 1)
                        {
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine("-->");
                        }
                        else if (amount == 2)
                        {
                            if (pos == 2)
                            {
                                Console.SetCursorPosition(0, pos);
                                Console.WriteLine("-->");
                                pos++;
                            }
                            else if (pos == 3)
                            {
                                Console.SetCursorPosition(0, pos);
                                Console.WriteLine("-->");
                                pos--;
                            }
                        }
                        else {break;}
                        break;

                    case ConsoleKey.DownArrow:
                        if (amount == 1)
                        {
                            Console.SetCursorPosition(0, 2);
                            Console.WriteLine("-->");
                        }
                        else if (amount == 2)
                        {
                            if (pos == 2)
                            {
                                Console.SetCursorPosition(0, pos);
                                Console.WriteLine("-->");
                                pos++;
                            }
                            else if (pos == 3)
                            {
                                Console.SetCursorPosition(0, pos);
                                Console.WriteLine("-->");
                                pos--;
                            }
                        }
                        else { break; }
                        break;
                    case ConsoleKey.LeftArrow:
                        data = ChooseDT(key, data);
                        break;
                    case ConsoleKey.RightArrow:
                        data = ChooseDT(key, data);
                        break;
                    case ConsoleKey.Enter:
                        ShowInfo(data, pos);
                        break;
                    default:break;
                }
                amount = DateChoose(data);
                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.Escape);
        }

        static DateTime ChooseDT(ConsoleKey kluch, DateTime data)
        {
            switch (kluch)
            {
                case ConsoleKey.LeftArrow:    
                    DateTime DN = data.AddDays(-1);
                    return DN;
                default:
                    DN = data.AddDays(1); 
                    return DN;
            }
        }

        static void ShowInfo(DateTime ChDate, int place) 
        {
            Info(ChDate, place);
            ConsoleKey Choose = Console.ReadKey().Key;
            while (Choose != ConsoleKey.Escape)
            { 
                Choose = Console.ReadKey().Key;
            }
            Console.Clear();
            return;
        }

        static void Info(DateTime ChosenDate, int kostil)
        {
            int i = 0;
            foreach (string time in themes)
            {
                try
                {
                    int data = Convert.ToInt32(time);
                    if (ChosenDate.Year == 2022)
                    {
                        data += 365;
                    }
                    if (data == ChosenDate.DayOfYear)
                    {
                        int num = 0;
                        foreach (string name in themes)
                        {
                            if (num <= i)
                            {
                                num++;
                                continue;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine(ChosenDate);
                                Console.WriteLine("------------------");
                                Console.SetCursorPosition(0, 2);
                                Console.WriteLine(name);
                                switch (name)
                                {
                                    case "Прогулять ИТ":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Слишком много пар по ИТ, да и домой хочется");
                                        break;
                                    case "Сделать Питон":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Доделать 7 практическую");
                                        break;
                                    case "Удалить Ростика":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Он не скинул мне 10 практику по шарпам");
                                        break;
                                    case "Выучить билеты по C#":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Скоро зачёт, билеты в группе в тг");
                                        break;
                                    case "Отчислиться":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Не сдал ОАИП и пересдать будет сложно");
                                        break;
                                    case "Сделать дз":
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Попробовать пересдать ОАПИ\nДоделать 7 практических");
                                        break;
                                    default:
                                        Console.SetCursorPosition(0, 3);
                                        Console.WriteLine("Не забываем о праздниках");
                                        break;
                                }
                                if (kostil == 2)
                                {
                                    kostil--;
                                    continue;
                                }
                                else 
                                {
                                    break;
                                }
                            }
                        }
                    }
                    i++;
                }
                catch
                {
                    i++;
                }
            }
            return;
        }
    }
}