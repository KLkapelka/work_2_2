// Заполните массив последовательными нечетными числами, начиная с 1;

using System;
class work_2_2
{
    static void Main()
    {
        int[] array = new int[100]; 
        int number = 1; 
        
        for(int i = 0; i < 100; i++)
        {
            array[i] = number; 
            number += 2; 
        }
        var str = string.Join(" ", array); 
        Console.WriteLine(str);
    }
}
