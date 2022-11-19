// See https://aka.ms/new-console-template for more information
Console.WriteLine("Write numbers!");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        int max = num1;
        if (max < num2)  max = num2;
        if (max < num3)  max = num3;
       
         Console.WriteLine($"Самое большое {max}");
        
