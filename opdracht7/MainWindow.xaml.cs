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

namespace opdracht7 {
	public partial class MainWindow : Window {

		public MainWindow() {
			InitializeComponent();
			btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
		}

		private void BtnMoveMe_MouseMove(object sender, MouseEventArgs e) {
			// Maak object button van het binnenkomende object sender
			Button btn = (Button)sender;
			// Maak een nieuwe instance van een Thickness object
			Thickness th = new Thickness();
			// Maak een randomizer object
			Random r = new Random();

			int t = r.Next(0, (int)opdracht7.ActualHeight - (int)btn.ActualHeight);
			int w = r.Next(0, (int)opdracht7.ActualWidth - (int)btn.ActualWidth);

			btnMoveMe.MouseMove -= BtnMoveMe_MouseMove;

			th.Left = t;
			th.Top = w;
			btn.Margin = th;

			_ = MoveButton(th);

			btnMoveMe.Click += BtnMoveMe_Click1;
		}

		private void BtnMoveMe_Click1(object sender, RoutedEventArgs e) {
			MessageBox.Show("Je hebt me te pakken");
		}

		private async Task MoveButton(Thickness th) {
			await Task.Delay(500);
			btnMoveMe.Margin = th;
			btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
		}
	}
}
