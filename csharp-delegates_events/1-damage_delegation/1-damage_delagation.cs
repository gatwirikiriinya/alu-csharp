using System;

/// <summary>
/// Represents a player in the game.
/// </summary>
public class Player {

    private string name = "Player"; // Name of the player.
    private float maxHp = 100f; // Maximum health points of the player.
    private float hp; // Current health points of the player.

    // Delegate for calculating health.
    private delegate void CalculateHealth(float amount);

    /// <summary>
    /// Initializes a new instance of the <see cref="Player"/> class with specified name and maximum health points.
    /// </summary>
    /// <param name="name">The name of the player.</param>
    /// <param name="maxHp">The maximum health points of the player.</param>
    public Player(string name = "Player", float maxHp = 100f){

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
    /// Inflicts damage on the player.
    /// </summary>
    /// <param name="damage">The amount of damage to be inflicted.</param>
    public void TakeDamage(float damage){
        
        if(damage < 0){
            Console.WriteLine($"{name} takes 0 damage!");
        }else{
            Console.WriteLine($"{name} takes {damage} damage!");
        }
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The amount of healing to be applied.</param>
    public void HealDamage(float heal){
        
        if(heal < 0){
            Console.WriteLine($"{name} heals 0 HP!");
        }else{
            Console.WriteLine($"{name} heals {heal} HP!");
        }
    }

    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth(){
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

}
