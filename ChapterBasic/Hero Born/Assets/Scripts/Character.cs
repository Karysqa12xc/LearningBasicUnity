using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character
{
    public string Name;

    public int Exp = 0;
    public Character()
    {
        Name = "No name";
    }
    public Character(string Name)
    {
        this.Name = Name;
    }
    public virtual void PrintStatsInfo()
    {
        Debug.LogFormat("Name: {0} - Exp: {1}",
        Name, Exp);
    }
    private void Reset( )
    {
        Name = "Not assign";
        Exp = 0;
    }
}
