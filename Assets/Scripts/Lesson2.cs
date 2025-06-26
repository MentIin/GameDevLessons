using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Lesson2 : MonoBehaviour
{
    public List<Weapon> Weapons;

    private void Start()
    {
        // SPAWN 2 HUMANS
        // GIVE THEM WEAPONS
        // MAKE THEM ATTACK EACH OTHER
        
        // and - &&
        // or - ||
    }
}
[Serializable]
public struct WeaponData
{
    public SizeType sizeType;
    public DamageType Type;
    public string Name;
    public int Damage;
}

[Serializable]
public class Weapon
{
    public GameObject Prefab;
    public WeaponData Data;
    public void Attack(Human h1)
    {
        // REDUCE HEALTH OF HUMAN BASED ON WEAPON DATA
    }
}


public enum SizeType
{
    Default=0,
    Big,
    Small
} 
public enum DamageType
{
    Melee,
    Arrow,
    Magic,
}

public class Human
{
    
}