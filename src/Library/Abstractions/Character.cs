namespace RoleplayGame
{
    public abstract class Character
    {
        protected string Name { get; }

        public abstract int Health { get; set; }

        public abstract int AttackValue { get; }

        public abstract int DefenseValue { get; }

        protected Character(string name)
        {
            this.Name = name;

        }


        public virtual void Cure()
        {
            this.Health = 100;
        }

        public virtual void ReceiveAttack(int power)
        {

        }
    }
}