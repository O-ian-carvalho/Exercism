using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string texto = "";
        for(int i = 0; i < text.Length ; i++)
        {
            if(text[i] == ' '){
                texto += ' ';
                continue;
            }
            char letra = text[i]; 
            if(char.IsLetter(letra)){
                for(int j = 1; j <= shiftKey; j++)
                {
                    letra = (char)(letra + 1);
                    if(Char.IsUpper((char)(letra -1)))
                    {
                        if((int)letra > (int)'Z')
                        {
                            letra = 'A';
                        }
                    }
                    else if(Char.IsLower((char)(letra -1)))
                    {
                       if((int)letra > (int)'z')
                        {
                            letra = 'a';
                        } 
                    }
                }
            }
            
            texto += letra;


        }

        return texto;
    }
}