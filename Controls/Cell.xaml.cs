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

namespace ArcadeChess.Controls
{
    /// <summary>
    /// Логика взаимодействия для Cell.xaml
    /// </summary>
    public partial class Cell : UserControl
    {
        private Color defaultColor;
        private Color activeColor;

        public Cell(Color color, int row, int col)
        {
            InitializeComponent();

            shape = new Rectangle();
            defaultColor = color;
            activeColor = Color.FromArgb(90, 33, 245, 5);

            shape.SetValue(Grid.RowProperty, row);
            shape.SetValue(Grid.ColumnProperty, col);
            shape.Fill = new SolidColorBrush(defaultColor);
        }
    }
}
