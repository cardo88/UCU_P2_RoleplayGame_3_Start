using System.Collections.Generic;
namespace RoleplayGame
{
    public abstract class Character
    {
        protected string name;

        protected int health = 100; 

        public string Name { get; }

        public int Health { get; }

        protected List<IElements> elementList;

        public List<IElements> ElementList
        {
            get
            {
                return this.elementList;
            }
        
        }

        protected Character(string name)
        {
            this.Name = name;
            elementList = new List<IElements>();

        }

        public void AddElement(IElements element)
        {
            this.elementList.Add(element);
        }

        public void RemoveElement(IElements element)
        {
            this.elementList.Remove(element);
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void ReceiveAttack(int power)
        {
             if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public virtual int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IElement element in this.elementList)
                {
                    if (element is IAttackElement)
                        value += element.AttackValue; 
                }
                return value;
            }
        }

        public virtual int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IElement element in this.elementList)
                {
                    if (element is IDefenseElement)
                        value += element.DefenseValue; 
                }
                return value;
            }
        }     

    }
}