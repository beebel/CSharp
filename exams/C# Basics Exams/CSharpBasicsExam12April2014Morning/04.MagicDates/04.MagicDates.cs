using System;
using System.Collections.Generic;

class MagicDates
{
    static void Main()
    {
        int startYear = Convert.ToInt32(Console.ReadLine());
        int endYear = Convert.ToInt32(Console.ReadLine());
        int weight = Convert.ToInt32(Console.ReadLine());

        DateTime startDate = new DateTime(startYear, 01, 01);
        DateTime endDate = new DateTime(endYear, 12, 31);

        //Console.WriteLine(startDate.ToString("dd-MM-yyyy"));
        //Console.WriteLine(endDate.ToString("dd-MM-yyyy"));

        int[] day1 = { 0, 1, 2, 3 };
        int[] day2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int[] month1 = { 0, 1 };
        int[] month2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        int[] year1 = { 1, 2 };
        int[] year2 = { 0, 1, 9 };
        int[] year3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] year4 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        List<int> dates = new List<int>();
        List<int> datesChecked = new List<int>();
        
        string concat = null;
        int check = 0;
        int sum = 0;

        foreach (var pos1 in day1)
        {
            dates.Add(pos1);
            foreach (var pos2 in day2)
            {
                concat = pos1.ToString() + pos2.ToString();
                check = Convert.ToInt32(concat);

                if (check <= 31)
                {
                    dates.Add(pos2);
                }
                
                concat = null;

                foreach (var pos3 in month1)
                {
                    dates.Add(pos3);
                    foreach (var pos4 in month2)
                    {
                        concat = pos3.ToString() + pos4.ToString();
                        check = Convert.ToInt32(concat);

                        if (check <= 12)
                        {
                            dates.Add(pos4);
                        }

                        concat = null;

                        foreach (var pos5 in year1)
                        {
                            dates.Add(pos5);
                            foreach (var pos6 in year2)
                            {
                                concat = pos5.ToString() + pos6.ToString();
                                check = Convert.ToInt32(concat);

                                if ((check == 19) || (check == 20) || (check == 21))
                                {
                                    dates.Add(pos6);
                                }

                                concat = null;

                                foreach (var pos7 in year3)
                                {
                                    dates.Add(pos7);
                                    foreach (var pos8 in year4)
                                    {
                                        concat = pos5.ToString() + pos6.ToString() + pos7.ToString() + pos8.ToString();
                                        check = Convert.ToInt32(concat);

                                        if ((check >= 1900) || (check <= 2100))
                                        {
                                            dates.Add(pos8);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }   
        }

        concat = null;
        check = 0;

        foreach (var date in dates)
        {
            concat = date.ToString();
            foreach (var digit in concat)
            {
                check++;
            }
            concat = null;
            if (check == 8)
            {
                datesChecked.Add(Convert.ToInt32(date));
            }
        }

        dates.Clear();

        if (datesChecked.Count == 0)
        {
            Console.WriteLine("No");
        }

        foreach (var number in datesChecked)
        {
            concat = number.ToString();
            foreach (var digit in concat)
            {
                check = Convert.ToInt32(digit);
                dates.Add(check);
            }
            foreach (var digit in dates)
            {
                foreach (var element in dates)
                {
                    sum += digit * element;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

// :(