// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void PrintNumber() {
    float nmax;
    Console.WriteLine("1 number");
    float a = float.Parse(Console.ReadLine());
    Console.WriteLine("2 number");
    float b = float.Parse(Console.ReadLine());
    { if (a > b) ;
        nmax = a;
        if (a < b) ;
        nmax = b; }
    Console.WriteLine(nmax);
}

PrintNumber();
