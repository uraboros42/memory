using System;

namespace MemoryRPG
{
    public class Unit
    {
        private float health;
        private Interval damage;

        public string Name { get; }
        public float Health => health;
        public Interval Damage => damage;
        public float Armor { get; } = 0.6f;

        public Unit() : this("Unknown Unit") { }

        public Unit(string name)
        {
            Name = name;
            health = 100f; // Assuming default health
            damage = new Interval(0, 5); // Default damage
        }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            health = 100f;
            damage = new Interval(0, maxDamage); // Minimal 0
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage(float value)
        {
            health -= value * Armor;
            return health <= 0f;
        }
    }
}