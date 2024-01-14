using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon
{
    public string Name;
    public int Damage;
    public Weapon(string name, int dmg){
        Name = name;
        Damage = dmg;
    }
    public void PrintWeaponStats()
    {
        Debug.LogFormat("Weapon: Name: {0} - Damage: {1}",
        Name, Damage);
    }
}
