using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDTest
{
    /// <summary>
    /// Класс реализующий объект Человек
    /// </summary>
    abstract class Human
    {
        protected string _name;//
        protected int _age;//
        protected string _sex;//
        protected string _member;//

        public Human()
        {
            _age = 0;
            _name = "No Name";
            _sex = "No sex";
            _member = "No member";
        }

        public abstract void Walk();

        public override string ToString()
        {
            return string.Format("{0} зовут {1}, мне {2} лет, я {3} пола", _member, _name, _age, _sex);
        }
    }
    interface IWork 
    {
        void Work();
    }

    interface IGoToScool
    {
        void GoToScool();
    }
}
