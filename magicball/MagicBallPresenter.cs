using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magicball
{
    public class MagicBallPresenter
    {
        private readonly IMagicBallView _view;
        private readonly MagicBallModel _model;

        public MagicBallPresenter(IMagicBallView view, MagicBallModel model)
        {
            _view = view;
            _model = model;

            _view.AskQuestion += OnAskQuestion;
        }

        private void OnAskQuestion()
        {
            string response = _model.GetResponse();
            _view.ResponseText = response;
        }
    }
}
