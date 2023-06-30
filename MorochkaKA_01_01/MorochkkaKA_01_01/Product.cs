using System;

namespace MorochkkaKA_01_01
{
    public class Product// базовый класс
    {
        public string Name { get; set; }//название продукта
        public double Protein { get; set; }//белки
        public double Carbs { get; set; }//углеводы
        public double Q;
        //конструктор класса
        public Product (string Name, double Protein, double Carbs)
        {
            this.Name = Name;
            this.Protein = Protein;
            this.Carbs = Carbs;
        }
        //функция вычисления "качества" Q
        public virtual int Сalculations()
        {
            return (int) (Q = Carbs * 4 + Protein * 4);
        }
        //функция вывода информации о продукте
        public virtual string Print()
        {
            return $"Название: {Name}\nБелки: {Protein}\nУглеводы: {Carbs}\nQ: {Q}";
        }
    }
}
