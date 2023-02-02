//Console.Clear();
//Console.SetCursorPosition(10?, 4);
//Console.WriteLine("+");

int xa = 30, ya = 1, xb = 1, yb = 10,
xc = 1, yc = 30, xd = 60, yd = 30, xe = 60, ye = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

Console.SetCursorPosition(xe, ye);
Console.WriteLine("+");

int x = xa, y = ya, count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 5);

    if (what == 0)
    {
        x = (xa + x)/2;
        y = (ya + y)/2;
    }

    if (what == 1)
    {
        x = (xb + x)/2;
        y = (yb + y)/2;
    }

    if (what == 2)
    {
        x = (xc + x)/2;
        y = (yc + y)/2;
    }

    if (what == 3)
    {
        x = (xd + x)/2;
        y = (yd + y)/2;
    }

    if (what == 4)
    {
        x = (xe + x)/2;
        y = (ye + y)/2;
    }
    
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}