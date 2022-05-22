using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : Character
    {

        public Archer(string name) : base(name)
        {
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
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
                return value;
            }
        }
    }
}