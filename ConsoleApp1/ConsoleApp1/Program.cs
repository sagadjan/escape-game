using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вы просыпаетесь в комнате...");
        Console.Write("Введите имя персонажа: ");
        string name = Console.ReadLine();

        bool artifact1 = false;
        bool artifact2 = false;
        bool artifact3 = false;
        bool statueActivated = false;
        bool hasKey = false;
        bool hasLockpick = false;
        int ventAttempts = 0;
        bool doorOpened = false;

        while (!doorOpened)
        {
            Console.WriteLine("\nЧто вы хотите сделать?");
            Console.WriteLine("1 - Открыть дверь");
            Console.WriteLine("2 - Заглянуть под кровать");
            Console.WriteLine("3 - Открыть ящик в углу комнаты");
            Console.WriteLine("4 - Открыть вентиляцию");
            Console.WriteLine("5 - Взглянуть на тумбочку");
            Console.WriteLine("6 - Взглянуть на статую рядом с дверью");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (hasLockpick)
                {
                    Console.WriteLine($"{name}, вы открыли дверь и сбежали! Победа!");
                    doorOpened = true;
                }
                else
                {
                    Console.WriteLine("Дверь закрыта. Нужно что-то, чтобы её открыть.");
                }
            }
            else if (choice == "2")
            {
                if (!artifact1)
                {
                    Console.WriteLine($"{name}, вы нашли первый артефакт под кроватью!");
                    artifact1 = true;
                }
                else
                {
                    Console.WriteLine("Под кроватью больше ничего нет.");
                }
            }
            else if (choice == "3")
            {
                if (hasKey && !hasLockpick)
                {
                    Console.WriteLine($"{name}, вы открыли ящик и нашли отмычку!");
                    hasLockpick = true;
                }
                else if (!hasKey)
                {
                    Console.WriteLine("Ящик заперт. Нужен ключ.");
                }
                else
                {
                    Console.WriteLine("Ящик пуст.");
                }
            }
            else if (choice == "4")
            {
                ventAttempts++;
                if (ventAttempts >= 3 && !artifact2)
                {
                    Console.WriteLine($"{name}, вы наконец открыли вентиляцию и нашли второй артефакт!");
                    artifact2 = true;
                }
                else if (artifact2)
                {
                    Console.WriteLine("Вентиляция уже открыта.");
                }
                else
                {
                    Console.WriteLine("Вы пытаетесь открыть вентиляцию... Пока безуспешно.");
                }
            }
            else if (choice == "5")
            {
                if (!artifact3)
                {
                    Console.WriteLine($"{name}, вы нашли третий артефакт на тумбочке!");
                    artifact3 = true;
                }
                else
                {
                    Console.WriteLine("На тумбочке больше ничего нет.");
                }
            }
            else if (choice == "6")
            {
                if (artifact1 && artifact2 && artifact3 && !statueActivated)
                {
                    Console.WriteLine($"{name}, вы активировали статую и получили ключ от ящика!");
                    statueActivated = true;
                    hasKey = true;
                }
                else if (statueActivated)
                {
                    Console.WriteLine("Статуя уже активирована.");
                }
                else
                {
                    Console.WriteLine("Статуя не реагирует. Видимо, чего-то не хватает...");
                }
            }
            else
            {
                Console.WriteLine("Неверный выбор, попробуйте ещё раз.");
            }
        }
    }
}