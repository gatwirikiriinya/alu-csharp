using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name = "(No name)";

        // Parameterless constructor to set the initial value of health to 0
        public Zombie()
        {
            health = 0;
        }

        // Constructor that sets health based on the provided value
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }

        // Public property for getting and setting the name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public method to retrieve the health of the Zombie
        public int GetHealth()
        {
            return health;
        }

        // Override the ToString method to provide a custom string representation
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
