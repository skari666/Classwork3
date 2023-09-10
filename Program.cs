string st = Console.ReadLine();
int st1, st2, st3;
bool prov = int.TryParse(st, out st1);
if (prov)
{
    st2 = st1 + 1;
    st3 = st1 - 1;
    Console.WriteLine($"The next number for the number {st1} is {st2}");
    Console.WriteLine($"The previous number for the number {st1} is {st3}");
}
else
{
    Console.WriteLine("Это не число");
}
