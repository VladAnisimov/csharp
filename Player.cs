using System;
using System.Collections;
using System.Security;

namespace project;

class Player : Person
{
    private string? MagicPower;
    public string? MagicPow
    {
        get => this.MagicPower;
        set 
        {
            this.MagicPower = value;
        }
    }
    public Player(string name, string type, int age, string MP) : base(name, type, age)
    {
        this.MagicPow = MP;
    }
    public override void GetInfo()
    {
        base.GetInfo();
        System.Console.WriteLine($"Magic Power: {MagicPow}");
        
    }
}