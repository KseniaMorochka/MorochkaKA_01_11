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
        public void Test�alculationsProductQAndQp ()
        {
            Product product1 = new Product("������", 10, 12);
            Assert.AreEqual(product1.�alculations(), 88);
        }
        [Test]
        public void Test�alculationsKkaloriesQAndQp () 
        {
            Product product = new Kkalories("�����", 21, 10, 90);
            Assert.AreEqual(product.�alculations(), 778);
        }
        [Test]
        public void TestPrintKkalories ()
        {
            Product product = new Kkalories("��������", 21, 10, 90);
            product.�alculations();
            Assert.AreEqual(product.Print(), "��������: ��������\n�����: 21\n��������: 10\nQ: 124" + "\nQp: 778");
        }
        [Test]
        public void TestPrintProduct ()
        {
            Product product = new Product("������", 45, 85);
            product.�alculations();
            Assert.AreEqual(product.Print(), "��������: ������\n�����: 45\n��������: 85\nQ: 520");
        }
        [Test]
        public void TestPrintProductQAndQpBigValue ()
        {
            Product product = new Product("��������", 456154985, 1564967498);
            product.�alculations();
            Assert.AreEqual(product.Print(), "��������: ��������\n�����: 456154985\n��������: 1564967498\nQ: 8084489932");
        }
        [Test]
        public void TestPrintKkaloriesQAndQpBigValue ()   
        {
            Product product = new Kkalories("������", 272, 99542999, 1348);
            product.�alculations();
            Assert.AreEqual(product.Print(), "��������: ������\n�����: 272\n��������: 99542999\nQ: 398173084" + "\nQp: 477817136");
        }
        [Test]
        public void Test�alculationsProductQAndQpBig ()
        {
            Product product1 = new Product("������", 543304, 9999999);
            Assert.AreEqual(product1.�alculations(), 42173212);
        }

    }
}