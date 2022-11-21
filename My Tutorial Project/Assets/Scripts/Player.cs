using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
    int _health;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }

    int _power;

    public int Power
    {
        get { return _power; }
        set { _power = value; }
    }

    string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public Player() { }
    public Player(int health, int power, string name)
    {
        Health = health;
        Power = power;
        Name = name;
    }

    public virtual void Attack()
    {
        Debug.Log(Name + " is attacking");
    }

    public void Info()
    {
        Debug.Log("Health is: " + Health);
        Debug.Log("Power is: " + Power);
        Debug.Log("Name is: " + Name);
    }

    //public void setHealth(int health)
    //{
    //    this.health = health;
    //}

    //public int GetHealth()
    //{
    //    return health;
    //}

}
