namespace RoleplayGame
{
    public abstract class Enemy : Character
    {
        protected int VP { get; set; }

        protected Enemy(string name) : base(name)
        {
        }

        public int VictoryPoints { get { return this.VP;} }



    

    }

}