using System;
using System.Collections.Generic;
using System.IO;
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

namespace Poligraphy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> Plays;

        public MainWindow()
        {
            InitializeComponent();

            //Поиск папок-шаблонов
            Plays = new List<string>();
            DirectoryInfo dir = new DirectoryInfo(@"Templates");
            foreach (var item in dir.GetDirectories())
            {
                Plays.Add(item.Name);

                Button B = new Button()
                {
                    Content = item.Name,
                    Margin = new Thickness(0,0,0,10),
                    FontSize = 14
                };
                CorePanel.Children.Add(B);
            }
        }
    }
}
