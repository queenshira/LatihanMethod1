static void tambah(int a, int b)
{
    int c = 0;

    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}");
}

static void kurang(int a, int b)
{
    int c = 0;

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}");
}

static void kali(int a, int b)
{
    int c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}");
}

static void bagi(int a, int b)
{
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}");
}

tambah (4, 7);
kurang (10, 6);
kali (5, 5);
bagi (6, 3);
