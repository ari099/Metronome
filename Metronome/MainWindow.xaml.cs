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

namespace Metronome {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        #region Event Handlers
        /// <summary>
        /// Bring tempo up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Up_Click(object sender, RoutedEventArgs e) {
            int currentTempo = int.Parse(Tempo.Content.ToString());
            Tempo.Content = (currentTempo < 218) ?
                (currentTempo + 1).ToString() : 218.ToString();
        }

        /// <summary>
        /// Bring tempo down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Down_Click(object sender, RoutedEventArgs e) {
            int currentTempo = int.Parse(Tempo.Content.ToString());
            Tempo.Content = (currentTempo > 0) ?
                (currentTempo - 1).ToString() : 0.ToString();
        }
        #endregion

        #region Beat Generation
        /// <summary>
        /// Play a simple beat
        /// </summary>
        private void PlayBeat() {
            // .....
        }

        /// <summary>
        /// Play metronome according to tempo provided as a function parameter
        /// </summary>
        /// <param name="tempo"></param>
        private void GenerateTempo(int tempo) {
            // .....
        }
        #endregion
    }
}
