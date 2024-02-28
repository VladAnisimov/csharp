using System;
using System.Collections;
using System.Reflection.Metadata;
using System.Security;
using Microsoft.VisualBasic;

namespace project;

class Person
{
    private string? name, type;

    private int age;

    public int Age
    {
        get => age;
        
        set
        {
            if(value > 0 || value < 30)
            age = value;
            else
            System.Console.WriteLine("Возраст больше чем ноль");
        }
    }
        
    

     public string? GetName() => this.name;

     public string? GetTType() => this.type;

     public int GetAge() => this.age;

    public Person(string? name, string? type, int age){
        System.Console.WriteLine("Person is created");
        this.name = name;
        this.type = type;
        this.Age = age;
    }
    public Person () 
    {
        System.Console.WriteLine("Object is created");
    }
    public virtual void GetInfo()
    {
        System.Console.WriteLine($"Player: {this.name}, Type: {this.type}, Age: {Age}");
        
    }
    public void SetData(string name, string type, int age)
    {
        this.name = name;
        this.type = type;
        this.age = age;
    }

    

    

    
    
    

    
}