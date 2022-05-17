using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArcherAddElement()
        {
            Archer archer = new Archer("skeleton");
            Bow bow = new Bow();
            archer.AddElement(bow);
            Assert.Contains(bow, archer.elementList);
        }
    }
}