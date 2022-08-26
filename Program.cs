//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());

int GetNat(int a1, int b1)
{ 
    if (a1 == 0) 
        {
            return b1 + 1;
        } 
    else 
    {
        if (b1 == 0 && a1 > 0) 
        {
            return GetNat(a1 - 1, 1);
        } 
        else 
        {
            return GetNat(a1 - 1, GetNat(a1, b1 - 1));
        }
    }

}
Console.WriteLine(GetNat(n, m));

