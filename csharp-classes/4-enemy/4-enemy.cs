using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        private string name;

        public Zombie()
        {
            health = 0;
            name = "No name";
        }

        public Zombie(int health, string name)
        {
            if (health < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            this.health = health;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int GetHealth()
        {
            return health;
        }
    }
}
