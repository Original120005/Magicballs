using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace magicball
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMagicBallView
    {
        public event Action AskQuestion;
        private MagicBallPresenter _presenter;

        public MainWindow()
        {
            InitializeComponent();
            _presenter = new MagicBallPresenter(this, new MagicBallModel());
        }

        public string QuestionText => QuestionTextBox.Text;

        public string ResponseText
        {
            set => ResponseTextBox.Text = value;
        }

        private void AskButton_Click(object sender, RoutedEventArgs e)
        {
            AskQuestion?.Invoke();
        }
    }
}
