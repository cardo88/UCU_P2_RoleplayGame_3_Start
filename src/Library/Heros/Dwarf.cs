using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Hero, IElementList<Item>
    {
        private int health = 100;

        private List<Item> elementsList = new List<Item>();

        public List<Item> ElementList
        {
            get
            {
                return this.elementsList;
            }
        }

        public Dwarf(string name) : base(name)
        {  
            this.AddElement(new Axe());
            this.AddElement(new Helmet());
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
            set // discutir esto
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

        public override int totalVictoryPoints()
        {
            return totalVP;
        }
    }
}