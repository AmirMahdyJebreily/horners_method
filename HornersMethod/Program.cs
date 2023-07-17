Console.Write("Enter Coefficients Here : ");
float[] conffs = Console.ReadLine().Split(", ").Select(a => float.Parse(a)).ToArray();
int grd = conffs.Length - 1;
Console.Write("Enter origin of expertion : ");
float org = float.Parse(Console.ReadLine());

float[] xs = new float[conffs.Length];
float[] res = new float[conffs.Length];

for (int i = 0; i < conffs.Length; i++)
{
    res[i] = (conffs[i] + xs[i]);
    if (conffs.Length - i != 1)
    {
        xs[i + 1] = res[i] * org;
    }
}

int lgrd = grd - 1;
foreach (float a in res[0..(res.Length - 1)])
{
    Console.Write($"{((a > 0)? "+" : "-")} {a}{((lgrd > 0)? ((lgrd > 1)? "x^" + lgrd : "x") : "")} ");
    lgrd--;
}