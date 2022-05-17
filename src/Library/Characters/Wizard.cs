using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: Character, IElementList<Element>
    {
        private int health = 100;

        private List<Element> elementsList = new List<Element>();

        public List<Element> ElementList
        {
            get
            {
                return this.elementsList;
            }
        }

        public Wizard(string name): base(name)
        {
           
            this.AddElement(new Staff());
        }
        
        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Element item in this.elementsList)
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
                foreach (Element item in this.elementsList)
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
            set //aca y en todos los personajes era private set pero me tiraba error y no se que hacer. ddiscutir luego.
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

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddElement(Element item)
        {
            this.elementsList.Add(item);
        }

        public void RemoveElement(Element item)
        {
            this.elementsList.Remove(item);
        }
    }
}