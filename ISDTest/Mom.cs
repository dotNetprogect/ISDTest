using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDTest
{
    /// <summary>
    /// Класс реализующий объект мать
    /// </summary>
    class Mom : Human, IWork
    {
        public Mom()
            : base()
        {
            _member = "Мать";
        }

        public override void Walk()
        {
            Work();
            _name = "Анна";
            _age = 30;
            _sex = "Женского";
        }

        public void Work() 
        {
        }
    }
}
