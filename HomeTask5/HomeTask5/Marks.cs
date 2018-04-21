using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    public class Marks
    {
        public void CreateCollection()
        {
            IDictionary<int, string> MarksCollection = new Dictionary<int, string>(4);

            MarksCollection.Add(2, "Не удовлетворительно");
            MarksCollection.Add(3, "Удовлетворительно");
            MarksCollection.Add(4, "Хорошо");
            MarksCollection.Add(5, "Отлично");
        }
    }
}
