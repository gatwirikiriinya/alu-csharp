using System;

/// <summary>
/// Represents the event arguments for current HP.
/// </summary>
public class CurrentHPArgs : EventArgs{
    
    /// <summary>
    /// Current HP value.
    /// </summary>
    public float currentHp;

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentHPArgs"/> class with specified current HP.
    /// </summary>
    /// <param name="newHp">The new HP value.</param>
    public CurrentHPArgs(float newHp){
        currentHp = newHp;
    }
}

/// <summary>
/// Represents the possible modifiers for a player's action.
/// </summary>
public enum Modifier {
    Weak,
    Base,
    Strong
}

/// <summary>
/// Represents a delegate that calculates a modifier based on a base value and a modifier type.
/// </summary>
/// <param name="baseValue">The base value to apply the modifier to.</param>
/// <param name="modifier">The type of modifier to apply.</param>
/// <returns>The modified value.</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Represents a player in the game.
/// </summary>
public class Player {

    private string name = "Player"; // Name of the player.
    private float maxHp = 100f; // Maximum health points of the player.
    private float hp; // Current health points of the player.

    private EventHandler<CurrentHPArgs> HPCheck; // Event handler for checking health.
    private string status; // Current status of the player.

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
        status = $"{name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary>
    /// Inflicts damage on the player.
    /// </summary>
    /// <param name="damage">The amount of damage to be inflicted.</param>
    public void TakeDamage(float damage){
        
        if(damage < 0){
            Console.WriteLine($"{name} takes 0 damage!");
        }else{
            hp -= damage;
            Console.WriteLine($"{name} takes {damage} damage!");
        }
        ValidateHP(hp);
    }

    /// <summary>
    /// Heals the player.
    /// </summary>
    /// <param name="heal">The amount of healing to be applied.</param>
    public void HealDamage(float heal){
        
        if(heal < 0){
            Console.WriteLine($"{name} heals 0 HP!");
        }else{
            hp += heal;
            Console.WriteLine($"{name} heals {Math.Round(heal, 1)} HP!");
           // Console.WriteLine(name + " heals " +  + " HP!");
        }
        ValidateHP(hp);
    }

    /// <summary>
    /// Validates the player's health points to ensure it falls within the permissible range.
    /// </summary>
    /// <param name="newHp">The new health points to validate.</param>
    private void ValidateHP(float newHp){
        if(newHp < 0 ){
            hp  = 0;
        }else if(newHp > maxHp){
            hp = maxHp;
        }else{
            hp = newHp;
        }


        OnCheckStatus(new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Applies a modifier to the base value.
    /// </summary>
    /// <param name="baseValue">The base value to apply the modifier to.</param>
    /// <param name="modifier">The type of modifier to apply.</param>
    /// <returns>The modified value.</returns>
    public float ApplyModifier(float baseValue, Modifier modifier){

        if(modifier == Modifier.Weak){
            return baseValue/2;
        } 
        
        if(modifier == Modifier.Base){
            return baseValue;
        }
        
        if(modifier == Modifier.Strong){
            return baseValue * 1.5f;
        }

        return default(float);
    }

    /// <summary>
    /// Checks the current status of the player based on their current health.
    /// </summary>
    /// <param name="Sender">The event sender.</param>
    /// <param name="e">The event arguments containing the current HP.</param>
    private void CheckStatus(object? Sender, CurrentHPArgs e){
        if(e.currentHp == maxHp){
            Console.WriteLine($"{name} is in perfect health!");
        }

        else if(e.currentHp >= (maxHp * 0.5) && e.currentHp < maxHp){
            Console.WriteLine($"{name} is doing well!");
        }

        else if(e.currentHp >= (maxHp * 0.25) && e.currentHp < maxHp){
             Console.WriteLine($"{name} isn't doing too great...");
        }

        else if(e.currentHp > 0 && e.currentHp <= (0.25 * maxHp)){
            Console.WriteLine($"{name} needs help!");
        }

        else if(e.currentHp == 0){
            Console.WriteLine($"{name} is knocked out!");
        }
    }

    /// <summary>
    /// Notifies subscribers about the player's health status.
    /// </summary>
    /// <param name="e">The event arguments containing the current HP.</param>
    public void OnCheckStatus(CurrentHPArgs e){
        if(e.currentHp <= (0.25 * maxHp)){
            HPCheck += HPValueWarning;
        }

        HPCheck.Invoke(this, e);
    }

    /// <summary>
    /// Provides a warning message when the player's health is low or zero.
    /// </summary>
    /// <param name="sender">The event sender.</param>
    /// <param name="e">The event arguments containing the current HP.</param>
    private void HPValueWarning(object? sender, CurrentHPArgs e){
        if(e.currentHp == 0){
            Console.WriteLine("Health has reached zero!");
        }else{
            Console.WriteLine("Health is low!");
        }
    }

    /// <summary>
    /// Prints the current health of the player.
    /// </summary>
    public void PrintHealth(){
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}
