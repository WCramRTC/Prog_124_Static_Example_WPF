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

namespace Prog_124_Static_Example_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lbPlayers.ItemsSource = DataClass._players;
        }

  
        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            new AddPlayerWindow().Show();
        } // btnAddPlayer_Click

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = lbPlayers.SelectedIndex;
            int updatedHp = int.Parse(txtUpdateHp.Text);

            DataClass._players[selectedIndex].Hp = updatedHp;

        } // btnUpdate_Click
    } // class

} // namespace
