namespace LeetCodeAssignment4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine( IsAnagram("anagram", "nagaram"));
      
    }
    
    public static bool IsAnagram(string s, string t)
    {
        char[] arrayS = s.ToCharArray();
        char[] arrayt = t.ToCharArray();
        Array.Sort(arrayS);
        Array.Sort(arrayt); 
        
        return arrayS.SequenceEqual(arrayt);
        
    }
}