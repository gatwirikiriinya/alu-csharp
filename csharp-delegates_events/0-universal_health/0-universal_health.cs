using System;



public class Player {

    private string? name;
    private float maxHp ;
    private float hp ;


    public Player(string? name = "Player", float maxHp = 100f){

        if(maxHp <= 0){
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }else{
               this.maxHp = maxHp;
        }

        this.name = name;
        hp = this.maxHp;
    }


/// <summary>
/// Log current health state
/// </summary>
    public void PrintHealth(){
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}