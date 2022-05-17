using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Character, IElementList<Item>
    {
        private int health = 100;

        public List<Item> elementList = new List<Item>();

        public List<Item> ElementList
        {
            get
            {
                return this.elementList;
            }
        
        }
        
        public Archer(string name) : base(name)
        {
            this.AddElement(new Bow());
            this.AddElement(new Helmet());
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

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public void AddElement(Item item)
        {
            this.elementList.Add(item);
        }

        public void RemoveElement(Item item)
        {
            this.elementList.Remove(item);
        }
    }
}