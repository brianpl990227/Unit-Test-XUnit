using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextManager.Tests
{
    public class TextManagerClassData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { "", 0 };
            yield return new object[] { "Hola Mundo", 2 };
            yield return new object[] { "Saludos desde mi proyecto de pruebas", 6 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
