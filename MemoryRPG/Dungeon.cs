using System;

namespace MemoryRPG
{
    public class Dungeon
    {
        private Room[] rooms;

        public Dungeon()
        {
            rooms = new Room[]
            {
                new Room(new Unit("Warrior"), new Weapon("Sword", 5, 10)),
                new Room(new Unit("Mage"), new Weapon("Staff", 3, 8)),
                new Room(new Unit("Archer"), new Weapon("Bow", 4, 9)),
                new Room(new Unit("Knight"), new Weapon("Lance", 6, 12))
            };
        }

        public void ShowRooms()
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                var room = rooms[i];
                Console.WriteLine("Unit of room " + room.Unit.Name);
                Console.WriteLine("Weapon of room " + room.Weapon.Name);
                Console.WriteLine("—");
            }
        }
    }
}