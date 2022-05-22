using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicCharacter: Character
    {
        protected List<IMagicalItem> magicaIItems;

        public MagicCharacter(string name): base(name)
        {            
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
    }
}
