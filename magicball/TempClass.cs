using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicball
{
    public interface IMagicBallView
    {
        event Action AskQuestion;
        string QuestionText { get; }
        string ResponseText { set; }
    }
}
