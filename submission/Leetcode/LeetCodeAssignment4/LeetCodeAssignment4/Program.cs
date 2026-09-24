namespace LeetCodeAssignment4;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine(IsAnagram("anagram", "nagaram"));
        Console.WriteLine(GcdOfStrings("sda", "ABC"));
    }
    
    public static bool IsAnagram(string s, string t)
    {
        char[] arrayS = s.ToCharArray();
        char[] arrayt = t.ToCharArray();
        Array.Sort(arrayS);
        Array.Sort(arrayt); 
        
        return arrayS.SequenceEqual(arrayt);
        
    }
    public static string GcdOfStrings(string str1, string str2)
    {

        if (str1 + str2 != str2 + str1)
            return "";
        
        int a = str1.Length , b = str2.Length;
        while (b > 0)
        {
            int temp = b;
            b = a % temp;
            a = temp;
        }

        return str1.Substring(0, a);

    }
}