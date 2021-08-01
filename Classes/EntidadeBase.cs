namespace vendas
{
    public abstract class EntidadeBase
    {
        public int Id
        {
            get
            {
                return Id;
            }

            protected set
            {
                Id = value;
            }
        }
    }
}