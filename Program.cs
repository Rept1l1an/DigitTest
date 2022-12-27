
// ANY
string TestAny = Console.ReadLine();
bool message = false;

for (int i = 0; i < TestAny.Length; i++)
{
    if (char.IsDigit(TestAny[i]))
    {
        message = true;
        break;
    }
}
Console.WriteLine(message);

//ALL
string TestAll = Console.ReadLine();
bool message = true;

for(int i =0; i < TestAll.Length; i++)
{
    if (char.IsDigit(TestAll[i]) != true)
    {
        message = false;
        break;
    }
}

Console.WriteLine(message);
