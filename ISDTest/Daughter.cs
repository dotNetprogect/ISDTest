using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISDTest
{
    /// <summary>
    /// Класс реализующий объект дочь
    /// </summary>
    class Daughter : Human, IGoToScool
    {
        public Daughter()
            : base()
        {
            _member = "Дочь";
        }

        public override void Walk()
        {
            GoToScool();
            _name = "Мария";
            _age = 10;
            _sex = "женского";
        }

        public void GoToScool()
        {
        }
    }
}
