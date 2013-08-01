using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace XML_Viewer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ExpandMenu(Ellipse item, int distance)
		{
			DoubleAnimation animation = new DoubleAnimation(0, distance, TimeSpan.FromSeconds(.5));
			TranslateTransform move = new TranslateTransform();
			item.RenderTransform = move;
			move.BeginAnimation(TranslateTransform.XProperty, animation);
			move.BeginAnimation(TranslateTransform.YProperty, animation);
		}

		private void XML_Viewer_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void ellipse1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

		}

		private void ellipse1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{

		}
	}
}
