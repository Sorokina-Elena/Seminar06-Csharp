/*
Задача 41
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int [] CreateArray(int size)
{
    int [] myArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        myArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return myArray;
}

void FindQuantity (int [] existingArray)
{
    int count = 0;
    for (int i = 0; i < existingArray.Length; i++)
    {
        
        if (existingArray[i] > 0)
        {
            count = count +1;
            
        }
        
    }
    Console.Write ($"Кол-во чисел больше нуля - {count}");
}
    
    
Console.Write ("Введите кол-во чисел ");
int mySize = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(mySize);
FindQuantity(array);
