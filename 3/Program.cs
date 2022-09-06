Console.WriteLine ("Введите цифру обозначающую день недели");
int number = Convert.ToInt32(Console.ReadLine());

void week  (int number)
{
    if(number==6 || number==7)
    {
        Console.WriteLine("Выходной день");
    }
    else if(number<1 || number>7)
    {
        Console.WriteLine("Это не день");
    }
    else
    {
        Console.WriteLine("Это не выходной");
    }
}
week(number);