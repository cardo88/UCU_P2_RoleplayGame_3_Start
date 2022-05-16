namespace RoleplayGame
{
    public interface IElementList <T>
    {
        IElementList<T> elementList { get; }

        public void AddElement(T element);
        public void RemoveElement(T element);

    }
}