Console.WriteLine("Hello, World!");
Console.WriteLine("Lets increment the numbers!");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Lets decrement the numbers!");
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Multiple of 3 the numbers!");
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}
Console.WriteLine("Array example!");
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}