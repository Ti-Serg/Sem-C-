
    void Zadacha2()
    {
        Console.WriteLine("Введите число от 1 до 7");
        int number1 = Convert.ToInt32(Console.ReadLine());
        

        if (1 == number1)
        {
            Console.WriteLine("Понелельник"); 
        }        
        else if (2 == number1) 
           {
            Console.WriteLine("Вторник");
           }
           else if (3 == number1)
           {
            Console.WriteLine("Среда");
           }
           else if (4 == number1)
           {
            Console.WriteLine("Четверг");
           }
           else Console.WriteLine("Нет такого дня");
    }
           

void Zadacha3()
{
    Console.WriteLine("Введите число для возведения в степень 2");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = Power(number);
    Console.WriteLine(result);

    int Power(int currentNumber)
    {
        return currentNumber * currentNumber;

    }

}

//Zadacha2();
//Zadacha3();
Zadacha7();

void Zadacha7()
    {
        Console.WriteLine("Введите число ");
        int number = Convert.ToInt32(Console.ReadLine());
        int start = -number;
        while (start <= number)
        {
            Console.Write(start + "  ");
            start++;
        }
        Console.WriteLine();
    }


