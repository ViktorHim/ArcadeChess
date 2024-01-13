using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ArcadeChess.Controls
{
    /// <summary>
    /// Логика взаимодействия для ChessBoard.xaml
    /// </summary>
    public partial class ChessBoard : UserControl
    {
        private Cell[,] cells = new Cell[8, 8];

        public ChessBoard()
        {
            InitializeComponent();

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Color color;

                    if ((row + col) % 2 == 0)
                        color = Color.FromArgb(255, 0, 0, 0);
                    else
                        color = Color.FromArgb(255, 255, 255, 255);

                    cells[row, col] = new Cell(color, row, col);

                    chessGrid.Children.Add(cells[row, col].shape);

                }
            }
        }
    }
}