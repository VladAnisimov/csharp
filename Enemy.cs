using System;
using System.Security.Cryptography;

namespace project;

class Enemy : Person
{
    private string? EnemyPower, EnemyPower1, EnemyPower2;
    public Enemy (string? name, string? type, int age, string? EP, string? EP1, string? EP2) : base(name, type, age){
        this.EnemyPower = EP;
        this.EnemyPower1 = EP1;
        this.EnemyPower2 = EP2;
    }

    public string? enemyPower
    {
        get => this.EnemyPower;
        set
        {
            this.EnemyPower = value;
        }
    }
    public string? enemyPower1
    {
        get => this.EnemyPower1;
        set 
        {
            this.EnemyPower1 = value;
        }
    }
    public string? enemyPower2
    {
        get => this.EnemyPower2;
        set 
        {
            this.EnemyPower2 = value;
        }
    }
    public void GetSpells(string EP, string EP1, string EP2)
    {
        this.EnemyPower = "asdad";
        this.EnemyPower1 = "343434";
        this.EnemyPower2 = "fhghgh";
    }
        
    

    public override void GetInfo()
    {
        base.GetInfo();
        System.Console.WriteLine($"Enemy Power: {EnemyPower}, {EnemyPower1}, {EnemyPower2} ");
    }
    
}