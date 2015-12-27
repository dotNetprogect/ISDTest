using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDTest
{
    /// <summary>
    /// Класс реализующий объект отец
    /// </summary>
    class Dad : Human, IWork
    {
        public Dad()
            : base()
        {
            _member = "Отец";
        }

        public override void Walk()
        {
            Work();
            _name = "Александр";
            _age = 30;
            _sex = "Мужского";
        }

        public void Work()
        {
        }
    }   
}
