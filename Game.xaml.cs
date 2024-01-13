using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace ArcadeChess
{

    public partial class Game : Page
    {
        public Game()
        {
            InitializeComponent();
            //ChessBoard board = new ChessBoard(chessGrid);
        }


        private void Cell_Click(object sender, RoutedEventArgs e)
        {
            // Обработка события при нажатии на клетку
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
