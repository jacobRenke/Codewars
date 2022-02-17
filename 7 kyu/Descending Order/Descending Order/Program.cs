// See https://aka.ms/new-console-template for more information

int num = 12345;
Console.WriteLine(DescendingOrder(num));

static int DescendingOrder(int num)
{
    //var count = num.ToString().Length;
    //string newNumber = num.ToString();
    //char[] newNumberArr = newNumber.ToArray();
    //newNumberArr.Reverse();
    //Console.WriteLine(Convert.ToInt32(newNumberArr));

    string numString = num.ToString();
    char[] ch = numString.ToCharArray();
    Array.Sort(ch);
    Array.Reverse(ch);
    numString = new string(ch);
    int result = Convert.ToInt32(numString );
    return result;
}