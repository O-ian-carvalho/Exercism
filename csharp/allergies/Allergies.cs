using System;
using System.Collections.Generic;

public enum Allergen
{
    Eggs,
    Peanuts,
    Shellfish,
    Strawberries,
    Tomatoes,
    Chocolate,
    Pollen,
    Cats
}

public class Allergies
{
    private List<Allergen> allergenList = new List<Allergen>();
    public Allergies(int mask)
    {
        int value = mask;
        for(int i = 7; i >= 0; i--)
        {
            if(value >= 256)
            {
                value = value - 256;
            }
            int potencia = (int)Math.Pow(2,i);
            if(potencia <= value){
                allergenList.Add((Allergen)i);
                value = value - potencia;
            }
        }
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        return allergenList.Contains(allergen);
    }

    public Allergen[] List()
    {
        allergenList.Reverse();
        return allergenList.ToArray();
    }
}