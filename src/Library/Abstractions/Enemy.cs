namespace RoleplayGame
{
    public abstract class Enemy : Character
    {
        protected int VP;
        protected Enemy(string name, int vp ) : base (name)
        {
            this.VP = vp;
        }
        public int VictoryPoints
        {
            get
            {
                return this.VP;
            }
        }
    }

}