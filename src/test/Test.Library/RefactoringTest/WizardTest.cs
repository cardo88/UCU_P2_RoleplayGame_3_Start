using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    [TestFixture]
    public class WizardTest
    {
        [Test]
        public void AddMagicElementTest()
        {
            Wizard harry = new Wizard("Harry Potter"); 
            SpellsBook spellsBook = new SpellsBook();
            SpellOne spell = new SpellOne(); 

            spellsBook.AddSpell(spell);
            harry.AddMagicalElement(spellsBook);

           // Assert.AreEqual(170, harry.AttackValue);
            // Assert.AreEqual(170, wizard.DefenseValue);
        }

        [Test]
        public void AttacktTest()
        {
            Wizard harry = new Wizard("Harry Potter");
            SpellsBook spellsBook = new SpellsBook();
            SpellOne spell = new SpellOne(); 

            spellsBook.AddSpell(spell);
            harry.AddMagicalElement(spellsBook);

            Archer archer = new Archer("Jose"); 
            archer.AddElement(new Helmet()); 
            archer.AddElement(new Armor()); 
            archer.AddElement(new Shield()); 
            //archer 75d

           // archer.ReceiveAttack(harry.AttackValue);
           // Assert.AreEqual(5 ,archer.Health);
        }

        [Test]
        public void CureTest()
        {
            Wizard harry = new Wizard("Harry Potter"); 

            Archer archer = new Archer("Jose"); 
            archer.AddElement(new Sword()); 
            archer.AddElement(new Axe()); 
            archer.AddElement(new Axe()); 
            archer.AddElement(new Sword()); 

            harry.ReceiveAttack(archer.AttackValue);
            harry.Cure();
            Assert.AreEqual(100, harry.Health);

            
        }

        [Test]
        public void RemoveAttackItemsTest()
        {
            
        }

        [Test]
        public void RemoveDefensiveItemsTest()
        {
            
        }

        [Test]
        public void ReceiveAttackTest()
        {
        
        }
    }
}