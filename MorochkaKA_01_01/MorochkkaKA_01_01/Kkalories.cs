using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorochkkaKA_01_01
{
    //класс - потомок
    public class Kkalories : Product
    {
        public double P { get; set; }
        public int Qp { get; set; }
        //конструктор класса
        public Kkalories (string Name, double Protein, double Carbs,int P) : base (Name, Protein, Carbs)
        {
            this.Name = Name;
            this.Protein = Protein;
            this.Carbs = Carbs;
            this.P = P;
        }
        //функция вычисления качества Qp
        public override int Сalculations ()
        {
            Q = Carbs * 4 + Protein * 4;
            return Qp = (int) (Q * 1.2 + P * 7);
        }
        //функция вывода информации о продукте
        public override string Print ()
        {
            return base.Print() + $"\nQp: {Qp}";
        }


    }
}
