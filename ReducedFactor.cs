class ReducedFactor
{

    /*
     * Complete the 'superReducedString' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static bool IsFound(int letter,int nextLetter)
    {
        bool _found = false;
        
         
        for(int i=97 ; i <= 122 ; i++)
        {
            if(i==letter && i == nextLetter)
            {
                _found = true;
                break;
            }
            
        }
        
        
        return _found;
        
    }
    // i guess i have to convert and group by integers and if consecutive count found 
    // remove them
    public static string superReducedString(string s)
    {
        int counter = s.Length;
        int index = 0;
        
        for(int i=index ; i < counter ; i++)
        {

            if((i+1) < counter)
            {
                              
                
                if(s[i] == s[i+1])
                {
                    Console.WriteLine($"Match Found {s[i]} == {s[i+1]}");
                    s = s.Remove(i,2); 
                    counter = s.Length    ;
                    i=0; 
                }
              
            }
            
            
            
            
        }
        if(String.IsNullOrEmpty(s))
        {
            s = "Empty String";
        }
        else if( s.Length > 1 &&  IsFound((int) s[0],(int) s[1]))
        {
            s = "Empty String";
        }
        
        
        return s;

    }

}