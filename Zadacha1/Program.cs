Console.WriteLine("Write numbers!");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine("num1 the biggest");
        }
        else if (num2 > num1)
        {
            Console.WriteLine("num2 the biggest!");
        }
        else
        {
            Console.WriteLine("Одинаковые");
        }