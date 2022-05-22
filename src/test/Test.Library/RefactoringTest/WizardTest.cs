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
            Wizard harry = new Wizard("Harry Potter"); //100a 100d por el staff
            SpellsBook spellsBook = new SpellsBook();
            SpellOne spell = new SpellOne(); //70a 70d

            spellsBook.AddSpell(spell);
            harry.AddMagicItem(spellsBook);

           // Assert.AreEqual(170, harry.AttackValue);
            // Assert.AreEqual(170, wizard.DefenseValue);
        }

        [Test]
        public void AttacktTest()
        {
            Wizard harry = new Wizard("Harry Potter"); //100a 100d por el staff
            SpellsBook spellsBook = new SpellsBook();
            SpellOne spell = new SpellOne(); //70a 70d

            spellsBook.AddSpell(spell);
            harry.AddMagicItem(spellsBook);

            Archer archer = new Archer("Jose"); // 15a 18d
            archer.AddItem(new Helmet()); //+18d
            archer.AddItem(new Armor()); //+25d
            archer.AddItem(new Shield()); //+14
            //archer 75d

           // archer.ReceiveAttack(harry.AttackValue);
           // Assert.AreEqual(5 ,archer.Health);
        }

        [Test]
        public void CureTest()
        {
            Wizard harry = new Wizard("Harry Potter"); //100a 100d por el staff

            Archer archer = new Archer("Jose"); // 15a 18d
            archer.AddItem(new Sword()); //+20a
            archer.AddItem(new Axe()); //+25a
            archer.AddItem(new Axe()); //+25a
            archer.AddItem(new Sword()); //+20a

            harry.ReceiveAttack(archer.AttackValue);
            harry.Cure();
            Assert.AreEqual(100, harry.Health);

            //total 105a archer
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