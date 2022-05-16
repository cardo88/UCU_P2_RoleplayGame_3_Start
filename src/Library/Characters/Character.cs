namespace RoleplayGame
{
    public abstract class Character
    {
        protected string Name { get; set; }

        protected int Health { get; set; }

        protected int AttackValue { get; }

        protected int DefenseValue { get; }

        protected Character(string name)
        {
            this.Name = name;
            
        }

        // void AddItem(IItem item);

        // void RemoveItem(IItem item);

        // public virtual void Cure()
        // {
        //     this.Health = 100;
        // }

        // public virtual void ReceiveAttack(int power)
        // {
            
        // }
    }
}