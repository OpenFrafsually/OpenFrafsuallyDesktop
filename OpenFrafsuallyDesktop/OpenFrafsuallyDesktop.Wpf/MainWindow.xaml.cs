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

namespace OpenFrafsuallyDesktop.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*
             * Disable features that aren't ready yet.
             */
            newHeader.Visibility = Visibility.Hidden;
            newOpenFrafsuallyProjectButton.Visibility = Visibility.Hidden;

            importOpenFrafsuallyProject.Visibility = Visibility.Hidden;

            exportAsJPEG.Visibility = Visibility.Hidden;
            exportAsPNG.Visibility = Visibility.Hidden;
            exportAsPDF.Visibility = Visibility.Hidden;

            exportHeader.Visibility = Visibility.Hidden;
            exportDataHeader.Visibility = Visibility.Hidden;
        }

        private void fileOpenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void filePreferencesButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void importDataButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void importOpenFrafsuallyProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exportAsJPEG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exportAsPNG_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exportAsPDF_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
