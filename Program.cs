// See https://aka.ms/new-console-template for more information


string sm = "Yes I am Yes , JelloOne Yes";

int counter = EvalString.FindCalcEnumString("Yes",sm);

sm = "Yes I am Yes , JelloOne YesNo";
// SPace and Time Split takes alot of time
Console.WriteLine($"The number of counter is : {counter}" );
class EvalString 
{

    public static int flatlandSpaceStations(int n, int[] c) {
        Array.Sort(c);
        int result = c[0];
        for (int i = 1; i < c.Length; i++) {
            result = Math.Max(result, (c[i] - c[i - 1]) / 2);
            Console.WriteLine($"Current {result} from 0 station to to median");
        }
        result = Math.Max(result, n - 1 - c[c.Length - 1]);
        return result;

    }

    public static int FindCalcEnumString(string find, string fullText)
    {

        char[] chars = fullText.ToCharArray();  
        int find_length = find.Length;
        string current = String.Empty;
        int index = 0;
        int counter = 0;
        for (int i = index;  i < chars.Length; i++)    
        {
            if(find_length < fullText.Length && ((i+find_length) < fullText.Length + 1))
            {
                current =  fullText.Substring(i,find_length );   
                index = i + find_length;
                Console.WriteLine ($"Starting from Start Index {i} to EndIndex {find_length} Current string is {current}");
                if(current == find)
                {
                 counter = counter + 1;
                }
            }
             
        } 
        return counter;



    }

     
}

