using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Hero, IElementList<Item>
    {
        private int health = 100;

        private List<Item> elementsList = new List<Item>();
        public List<Item> ElementList
        {
            get
            {
                return elementsList;
            }
        }

        public Knight(string name) : base(name)
        {
            
            this.AddElement(new Sword());
            this.AddElement(new Armor());
            this.AddElement(new Shield());
            totalVP = 0;
        }


        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.elementsList)
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
                foreach (Item item in this.elementsList)
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
            set //discutir
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
            this.elementsList.Add(item);
        }

        public void RemoveElement(Item item)
        {
            this.elementsList.Remove(item);
        }
        public override int totalVictoryPoints(int vp)
        {
            return totalVP;
        }
    }
}