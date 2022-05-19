using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter: Character
    {
        protected List<IMagicalItem> magicaIItems;

        public MagicCharacter(string name): base(name)
        {
            this.Name = name;
            
            magicaIItems = new List<IMagicalItem>();
        }
        public void AddMagicItem(IMagicalItem item)
        {
            this.magicaIItems.Add(item);
        }

        public void RemoveMagicItem(IMagicalItem item)
        {
            this.magicaIItems.Remove(item);
        }


        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicaIItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicaIItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
    }
}
