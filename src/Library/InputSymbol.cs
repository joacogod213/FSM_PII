namespace Library.Base
{
    public abstract class InputSymbol
    {
        public string Name { get; }

        protected InputSymbol(string name)
        {
            Name = name;
        }

        public override string ToString() => Name;
    }
}