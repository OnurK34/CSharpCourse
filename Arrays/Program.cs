string[] students = new string[3] { "Onur", "Adem", "Enes" };

string[] students2 = { "Onur", "Adem", "Enes" };
//students2[3] = "Ahmet";

foreach (var student in students2)
{
    Console.WriteLine(student);
}

Console.WriteLine();
Console.WriteLine();

string[,] regions = new string[5, 3]
{
    {"İstanbul","İzmir","Balıkesir"},
    {"Ankara","Konya","Kırıkkale"},
    {"Antalya","Adana","Mersin"},
    {"Rize","Trabzon","Samsun"},
    {"İzmir","Muğla","Manisa"}
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("^^^^^^^^^^^^^^^^");
}


