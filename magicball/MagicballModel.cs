using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicball
{
    public class MagicBallModel
    {
        private readonly List<string> _responses = new List<string>
    {
        "Да", "Нет", "Возможно", "Лучше не говорить вам сейчас", "Спросите позже"
        // ... добавьте другие ответы по желанию
    };

        public string GetResponse()
        {
            Random random = new Random();
            int index = random.Next(_responses.Count);
            return _responses[index];
        }
    }
}
