int range = 250;
int[]? counts = new int[range];
string text = "something";
double totalCount = 0;
double percentPerCount;
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine().ToLower();
    foreach (var character in text ?? string.Empty)
    {
        counts[(int)character]++;
        totalCount++;
    }
    percentPerCount = 100 / totalCount;
    for (int i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            Console.WriteLine(String.Format("{0, -3} {1, -1} {2, 3}", character, "-", Math.Round(counts[i] * percentPerCount, 2) + "%"));
        }
    }
}