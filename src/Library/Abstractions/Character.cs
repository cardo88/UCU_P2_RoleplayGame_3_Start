using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Character
    {
        protected string Name { get; }

        public abstract int Health { get; set; }

        public abstract int AttackValue { get; }

        public abstract int DefenseValue { get; }

        public List<Item> elementList = new List<Item>();

        public List<Item> ElementList
        {
            get
            {
                return this.elementList;
            }
        
        }

        protected Character(string name)
        {
            this.Name = name;

        }

         public void AddElement(Item item)
        {
            this.elementList.Add(item);
        }

        public void RemoveElement(Item item)
        {
            this.elementList.Remove(item);
        }

        public virtual void Cure()
        {
            this.Health = 100;
        }

        public virtual void ReceiveAttack(int power)
        {
             if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

    }
}