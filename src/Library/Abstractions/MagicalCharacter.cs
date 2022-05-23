using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicalCharacter : Hero
    {
        protected List<IMagicalElement> magicalElements;

        protected MagicalCharacter(string name) : base (name)
        {
            magicalElements = new List<IMagicalElement>();
        }    

        public void AddMagicalElement (IMagicalElement magicalElement)
        {
            this.magicalElements.Add(magicalElement);
        }

        public void RemoveMagicalElement (IMagicalElement magicalElement)
        {
            this.magicalElements.Remove(magicalElement);
        }


        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IElement element in this.elementList)
                {
                    if (element is IAttackElement)
                        value += element.AttackValue; 
                }
                foreach (IMagicalElement element in this.magicalElement)
                {
                    if (element is IMagicalAttackElement)
                        value += element.AttackValue; 
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IElement element in this.elementList)
                {
                    if (element is IDefenseElement)
                        value += element.DefenseValue; 
                }
                foreach (IMagicalElement element in this.magicalElement)
                {
                    if (element is IMagicalDefenseElement)
                        value += element.DefenseValue; 
                }
                return value;
            }
        }  
    }
}
