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
                        value += (element as IAttackElement).AttackValue; 
                }
                foreach (IMagicalElement element in this.magicalElements)
                {
                    if (element is IMagicElementAttack)
                        value += (element as IMagicElementAttack).AttackValue; 
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
                        value += (element as IDefenseElement).DefenseValue; 
                }
                foreach (IMagicalElement element in this.magicalElements)
                {
                    if (element is IMagicElementDefense)
                        value += (element as IMagicElementDefense).DefenseValue; 
                }
                return value;
            }
        }  
    }
}
