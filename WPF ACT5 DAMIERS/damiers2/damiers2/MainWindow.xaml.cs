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

namespace damiers2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int tailleGrille = 10;
            Button[,] button = new Button[tailleGrille, tailleGrille];
            ColumnDefinition[] coldef1 = new ColumnDefinition[tailleGrille];
            RowDefinition[] rowDef1 = new RowDefinition[tailleGrille];
            int compteur = 1; 

            for (int i = 0; i < tailleGrille; i++)
            {
                coldef1[i] = new ColumnDefinition();
                grdMain.ColumnDefinitions.Add(coldef1[i]);
                rowDef1[i] = new RowDefinition();
                grdMain.RowDefinitions.Add(rowDef1[i]);
            }
            for (int i = 0; i < tailleGrille; i++)
            {
                for (int y = 0; y < tailleGrille; y++)
                {
                    button[i, y] = new Button();
                    if ((i + y) % 2 == 0)
                    {
                        button[i, y].Background = Brushes.Black;
                    }
                    else
                    {
                        button[i, y].Background = Brushes.White;
                    }
                    if (i  % 2 == 0)
                    {
                        button[i, y].Content = compteur;
                    }
                    else
                    {
                        button[i, y].Content = (tailleGrille * i) + (tailleGrille - 1 - y) + 1;
                    }
                    button[i, y].Foreground = Brushes.Red;
                    button[i, y].Height = 65;
                    button[i, y].Width = 65;
                    button[i, y].FontWeight = FontWeights.Bold;
                    button[i, y].FontSize = 37;
                    compteur++;
                    Grid.SetRow(button[i, y], i);
                    Grid.SetColumn(button[i, y], y);
                    grdMain.Children.Add(button[i, y]);
                }
            }
        }
    }
}
