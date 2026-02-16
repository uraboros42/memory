using System;

namespace MemoryRPG
{
    public class Weapon
    {
        public string Name { get; }
        public Interval DamageParams { get; private set; }
        public float Durability { get; } = 1f;

        public Weapon(string name)
        {
            Name = name;
            DamageParams = new Interval(1, 10); // Default
        }

        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }

        public void SetDamageParams(int minDamage, int maxDamage)
        {
            DamageParams = new Interval(minDamage, maxDamage);
        }

        public int GetDamage()
        {
            return DamageParams.Get();
        }
    }
}