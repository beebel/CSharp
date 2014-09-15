// 01. Fruit Market

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FruitMarket
{
    static void Main()
    {
        string dayOfWeek = Console.ReadLine();

        decimal total = 0m;

        for (int i = 0; i < 3; i++)
        {
            decimal tmpQuantity = decimal.Parse(Console.ReadLine());
            string tmpProduct = Console.ReadLine();
            decimal price = 0m;

            switch (tmpProduct)
            {
                case "banana":
                    price = 1.80m;
                    break;
                case "orange":
                    price = 1.60m;
                    break;
                case "apple":
                    price = 0.86m;
                    break;
                case "tomato":
                    price = 3.20m;
                    break;
                case "cucumber":
                    price = 2.75m;
                    break;
                default:
                    break;
            }

            decimal tmpCost = price * tmpQuantity;

            string tmpType = null;

            switch (tmpProduct)
            {
                case "banana":
                case "orange":
                case "apple":
                    tmpType = "fruit";
                    break;

                case "tomato":
                case "cucumber":
                    tmpType = "vegetable";
                    break;

                default:
                    break;
            }

            switch (dayOfWeek)
            {
                case "Monday":
                case "Saturday":
                    {
                        total += tmpCost;
                        break;
                    }
                case "Friday":
                    {
                        tmpCost = tmpCost - (tmpCost * 10) / 100;
                        total += tmpCost;
                        break;
                    }
                case "Sunday":
                    {
                        tmpCost = tmpCost - (tmpCost * 5) / 100;
                        total += tmpCost;
                        break;
                    }
                case "Tuesday":
                    {
                        if (tmpType == "fruit")
                        {
                            tmpCost = tmpCost - (tmpCost * 20) / 100;
                            total += tmpCost;
                        }
                        else
                        {
                            total += tmpCost;
                        }
                        break;
                    }
                case "Wednesday":
                    {
                        if (tmpType == "vegetable")
                        {
                            tmpCost = tmpCost - (tmpCost * 10) / 100;
                            total += tmpCost;
                        }
                        else
                        {
                            total += tmpCost;
                        }
                        break;
                    }
                case "Thursday":
                    {
                        if (tmpProduct == "banana")
                        {
                            tmpCost = tmpCost - (tmpCost * 30) / 100;
                            total += tmpCost;
                        }
                        else
                        {
                            total += tmpCost;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        Console.WriteLine("{0:0.00}", total);

    }
}
