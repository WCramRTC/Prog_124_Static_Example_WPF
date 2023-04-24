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
using System.Windows.Shapes;

namespace Prog_124_Static_Example_WPF
{
    /// <summary>
    /// Interaction logic for AddPlayerWindow.xaml
    /// </summary>
    public partial class AddPlayerWindow : Window
    {
        public AddPlayerWindow()
        {
            InitializeComponent();
            lvPlayers.ItemsSource = DataClass._players;
        } // AddPlayerWindow()

        private void btnAddPlayer_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int hp = int.Parse(txtHp.Text);
            DataClass.AddPlayer(new Player(name, hp));
        } // Button_Click

    } // class

} // namespace
