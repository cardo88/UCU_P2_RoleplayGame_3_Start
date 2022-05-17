using System.Collections.Generic;
namespace RoleplayGame
{
    public interface IElementList <T>
    {
        public List<T> ElementList { get; }

        public void AddElement(T element);
        public void RemoveElement(T element);

    }
}