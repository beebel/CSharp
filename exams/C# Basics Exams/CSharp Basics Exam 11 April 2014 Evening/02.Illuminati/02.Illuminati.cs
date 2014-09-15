using System;

    class Illuminati
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int sum = 0;
            int counter = 0;
            foreach (char letter in text)
            {
                switch (letter)
                {
                    case 'a': sum += 65; counter++; break;
                    case 'A': sum += 65; counter++; break;
                    case 'e': sum += 69; counter++; break;
                    case 'E': sum += 69; counter++; break;
                    case 'i': sum += 73; counter++; break;
                    case 'I': sum += 73; counter++; break;
                    case 'o': sum += 79; counter++; break;
                    case 'O': sum += 79; counter++; break;
                    case 'U': sum += 85; counter++; break;
                    case 'u': sum += 85; counter++; break;
                }
            }
            Console.WriteLine("{0}\n{1}", counter, sum);
        }
    }