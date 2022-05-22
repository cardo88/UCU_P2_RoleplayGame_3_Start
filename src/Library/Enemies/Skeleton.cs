using System.Collections.Generic;
namespace RoleplayGame
{
    public class Skeleton : Enemy, IElementList<Item>
    {
        private int health = 100;
        public List<Item> elementList = new List<Item>();

        public Skeleton(string name, int VP) : base(name, VP)
        {
        }


        public List<Item> ElementList
        {
            get
            {
                return this.elementList;
            }
        
        }

        public void AddElement(Item item)
        {
            this.elementList.Add(item);
        }

        public void RemoveElement(Item item)
        {
            this.elementList.Remove(item);
        }

        public override int Health
        {
            get
            {
                return this.health;
            }
            set // discutir
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.elementList)
                {
                   value += item.AttackValue; 
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.elementList)
                {
                    value += item.DefenseValue;
                }
                return value;
            }
        }
    }
}