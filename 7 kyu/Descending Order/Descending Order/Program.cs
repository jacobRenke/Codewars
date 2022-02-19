// See https://aka.ms/new-console-template for more information

int num = 12345;
Console.WriteLine(DescendingOrder(num));

static int DescendingOrder(int num)
{
    string numString = num.ToString();
    char[] ch = numString.ToCharArray();
    Array.Sort(ch);
    ch.OrderByDescending(x => x);
    Array.Reverse(ch);
    numString = new string(ch);
    int result = Convert.ToInt32(numString);
    return result;
}