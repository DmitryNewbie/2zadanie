
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number>99)
{
    Console.WriteLine("Третья цифра" + ((number%10)/1));
}
else
{
    Console.WriteLine("Третий цифры нет");
}