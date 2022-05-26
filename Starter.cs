using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefPovar
{
    internal class Starter
    {
        public void Run()
        {
            GreenFood greenFood = new GreenFood();
            Initialiser initialiser = new Initialiser();
            Salat[] salats = initialiser.Initialise();
            string[] textToFile = new string[salats.Length];
            FileService fileService = new FileService();

            while (true)
            {
                int i = 0;
                Console.WriteLine($"Write for speed/price do you want a filter list OR write 'all' to see all our AVTOPARK ");
                string choise = Console.ReadLine();
                if (string.IsNullOrEmpty(choise))
                {
                    Console.WriteLine("it isnt a right string !!!");
                    continue;
                }

                switch (choise.ToLower())
                {
                    case "calories":
                        Choise(salats, choise);
                        break;
                    case "price":
                        Choise(salats, choise);
                        break;
                    case "all":
                        Console.Clear();
                        foreach (Salat vivod in salats)
                        {
                            Console.WriteLine(vivod.GetType().Name);
                            Console.WriteLine($" have price: {vivod.Price} \n calories:{vivod.Calories} \n and status:");
                            vivod.Opportunities();
                            Console.WriteLine();
                            string text = $"{vivod.GetType().Name} have price: {vivod.Price} \n calories:{vivod.Calories} \n and status: ";
                            textToFile[i] = text;
                            i++;
                        }

                        fileService.FileWriter(textToFile);

                        break;
                }

                Console.WriteLine("Sum Of Instance  classes is");
                greenFood.SumOfInstance();
            }
        }

        public void Choise(Salat[] array, string choise)
        {
            int max;
            int min;

            while (true)
            {
                Console.WriteLine("write  min value");
                if (!int.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }

                Console.WriteLine("write  max value");
                if (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }

                if (max < min)
                {
                    continue;
                }

                if (choise == "price")
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].Price > min && array[i].Price < max)
                        {
                            sum = sum + array[i].Price;
                            Console.WriteLine($"{array[i].GetType().Name} have price : {array[i].Price} and speed: {array[i].Calories}  \n");
                        }
                    }

                    Console.WriteLine("sum of price is " + sum);
                }
                else
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i].Calories > min && array[i].Calories < max)
                        {
                            sum = sum + array[i].Calories;
                            Console.WriteLine($"{array[i].GetType().Name} have speed : {array[i].Calories} and price: {array[i].Price} \n ");
                        }
                    }

                    Console.WriteLine("sum of Calories is " + sum);
                }

                break;
            }
        }
    }
}