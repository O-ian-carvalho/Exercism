using System;
using System.Collections.Generic;

public class GradeSchool
{
    private HashSet<string> names = new HashSet<string>();
    public Dictionary<int, SortedSet<string>> grades = new Dictionary<int, SortedSet<string>>();

    public GradeSchool(){
        for(int i = 0; i < 5; i++)
        {
            grades[i] = new SortedSet<string>();
        }
    }
    public bool Add(string student, int grade)
    {

        if(!grades.ContainsKey(grade - 1))
        {
            grades[grade -1] = new SortedSet<string>();
        }
        if(names.Add(student))
        {
            return grades[grade -1].Add(student);
        }

        return false;
        
    }

    public IEnumerable<string> Roster()
    {
        HashSet<string> listatotal = new HashSet<string>();
        foreach(var item in grades)
        {
            foreach(var nome in item.Value){
                listatotal.Add(nome);
            }
        }
        return listatotal;
    }

    public IEnumerable<string> Grade(int grade)
    {
        return grades[grade -1];
    }
}


