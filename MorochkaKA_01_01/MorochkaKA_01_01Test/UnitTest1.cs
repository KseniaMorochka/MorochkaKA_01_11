using MorochkkaKA_01_01;
using NUnit.Framework;

namespace MorochkaKA_01_01Test
{
    public class Tests
    {
        [SetUp]
        public void Setup ()
        {

        }

        [Test] 
        public void TestСalculationsProductQAndQp ()
        {
            Product product1 = new Product("Яблоко", 10, 12);
            Assert.AreEqual(product1.Сalculations(), 88);
        }
        [Test]
        public void TestСalculationsKkaloriesQAndQp () 
        {
            Product product = new Kkalories("Банан", 21, 10, 90);
            Assert.AreEqual(product.Сalculations(), 778);
        }
        [Test]
        public void TestPrintKkalories ()
        {
            Product product = new Kkalories("Апельсин", 21, 10, 90);
            product.Сalculations();
            Assert.AreEqual(product.Print(), "Название: Апельсин\nБелки: 21\nУглеводы: 10\nQ: 124" + "\nQp: 778");
        }
        [Test]
        public void TestPrintProduct ()
        {
            Product product = new Product("Молоко", 45, 85);
            product.Сalculations();
            Assert.AreEqual(product.Print(), "Название: Молоко\nБелки: 45\nУглеводы: 85\nQ: 520");
        }
        [Test]
        public void TestPrintProductQAndQpBigValue ()
        {
            Product product = new Product("Мандарин", 456154985, 1564967498);
            product.Сalculations();
            Assert.AreEqual(product.Print(), "Название: Мандарин\nБелки: 456154985\nУглеводы: 1564967498\nQ: 8084489932");
        }
        [Test]
        public void TestPrintKkaloriesQAndQpBigValue ()   
        {
            Product product = new Kkalories("Бургер", 272, 99542999, 1348);
            product.Сalculations();
            Assert.AreEqual(product.Print(), "Название: Бургер\nБелки: 272\nУглеводы: 99542999\nQ: 398173084" + "\nQp: 477817136");
        }
        [Test]
        public void TestСalculationsProductQAndQpBig ()
        {
            Product product1 = new Product("Яблоко", 543304, 9999999);
            Assert.AreEqual(product1.Сalculations(), 42173212);
        }

    }
}