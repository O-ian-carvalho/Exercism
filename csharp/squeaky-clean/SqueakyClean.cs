using System;
using System.Text; 


public static class Identifier
{
    public static string Clean(string identifier)
    {

        var txt = new StringBuilder(identifier);
        txt.Replace("\0","CTRL");
        for(int i = 0; i < txt.Length; i++)
        {
            if(char.IsWhiteSpace(txt[i]))
            {
                txt[i] = '_';
            }
            if(txt[i] == '-'){
                txt[i+1] = char.ToUpper(txt[i+1]);
                txt.Remove(i,1);
                i--;
            }
           
        }
        for(int i =0; i < txt.Length; i++){
             if(!char.IsLetter(txt[i]) && txt[i] != '_')
            {
                txt.Remove(i,1);
                i--;
                continue;
            }
            if(txt[i] >= 'α' && txt[i] <=  'ω'){
                txt.Remove(i,1);
                i--;
            }
        }
        return txt.ToString();
    }
}
