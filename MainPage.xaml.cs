using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.Storage;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HiLowProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
		
		int cardCount = 0, currentCardValue = 0, previousCardValue = 0, min = 2, max = 12, streak = 0;
		Boolean chooseHigher, chooseLower;
		public MainPage()
		{
			this.InitializeComponent();
		}

		private void higher_Click(object sender, RoutedEventArgs e)
		{
			chooseHigher = true;
			cardReveal();
			checkHigherOrLower();
		}

		private void play_Click(object sender, RoutedEventArgs e)
		{
			play.Visibility = Visibility.Collapsed;
			higher.Visibility = Visibility.Visible;
			lower.Visibility = Visibility.Visible;
			chooseHigher = true;
			cardReveal();
			checkHigherOrLower();
		}

		private void lower_Click(object sender, RoutedEventArgs e)
		{
			chooseLower = true;
			cardReveal();
			checkHigherOrLower();
		}

		public void cardReveal()
		{
			do
			{
				Random rnd = new Random();
				currentCardValue = rnd.Next(min, max);
			} while (currentCardValue == previousCardValue);

			if (cardCount == 0)
			{
				if (currentCardValue == 2)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}

			else if (cardCount == 1)
			{
				if (currentCardValue == 2)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}

			else if (cardCount == 2)
			{
				if (currentCardValue == 2)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}

			else if (cardCount == 3)
			{
				if (currentCardValue == 2)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}

			else if (cardCount == 4)
			{
				if (currentCardValue == 2)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}

			else if (cardCount == 5)
			{
				if (currentCardValue == 2)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/2.png"));
				}
				else if (currentCardValue == 3)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/3.png"));
				}
				else if (currentCardValue == 4)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/4.png"));
				}
				else if (currentCardValue == 5)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/5.png"));
				}
				else if (currentCardValue == 6)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/6.png"));
				}
				else if (currentCardValue == 7)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/7.png"));
				}
				else if (currentCardValue == 8)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/8.png"));
				}
				else if (currentCardValue == 9)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/9.png"));
				}
				else if (currentCardValue == 10)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/10.png"));
				}
				else if (currentCardValue == 11)
				{
					cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/11.png"));
				}
			}
		}

		public void checkHigherOrLower()
		{
			if (chooseHigher == true && currentCardValue > previousCardValue)
			{
				cardCount++;
				if (cardCount == 6)
				{
					win();
				}
				else
				{
					nextRound();
				}
			}
			else if (chooseLower == true && currentCardValue < previousCardValue)
			{
				cardCount++;
				if (cardCount == 6)
				{
					win();
				}
				else
				{
					nextRound();
				}
			}
			else
			{
				lose();
			}
		}

		public void nextRound()
		{
			previousCardValue = currentCardValue;
			chooseLower = false;
			chooseHigher = false;
		}

		public async Task lose()
		{
			streak = 0;
			higher.Visibility = Visibility.Collapsed;
			lower.Visibility = Visibility.Collapsed;
			await Task.Delay(TimeSpan.FromSeconds(2));
			restart();

		}

		public async Task win()
		{
			streak++;
			higher.Visibility = Visibility.Collapsed;
			lower.Visibility = Visibility.Collapsed;
			await Task.Delay(TimeSpan.FromSeconds(1));
			restart();
		}

		public void restart()
		{
			play.Visibility = Visibility.Visible;

			cardImage0_1.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));
			cardImage0_2.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));
			cardImage0_3.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));
			cardImage0_4.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));
			cardImage0_5.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));
			cardImage0_6.Source = new BitmapImage(new Uri(base.BaseUri, "assets/cardBack.png"));

			currentStreak.Text = "Your current winning streak is " + streak;

			cardCount = 0;
			currentCardValue = 0;
			previousCardValue = 0;
		}
	
	}


    
}
