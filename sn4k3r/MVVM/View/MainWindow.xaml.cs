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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace sn4k3r
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void WindowStateButton_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private StringAnimationUsingKeyFrames b4ck26uy_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));

            StringKeyFrame keyFrame0 = new DiscreteStringKeyFrame("64ck", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0)));
            StringKeyFrame keyFrame1 = new DiscreteStringKeyFrame("6f92", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0625)));
            StringKeyFrame keyFrame2 = new DiscreteStringKeyFrame("6gq8", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.125)));
            StringKeyFrame keyFrame3 = new DiscreteStringKeyFrame("6o2y", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.1875)));
            StringKeyFrame keyFrame4 = new DiscreteStringKeyFrame("60ei", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            StringKeyFrame keyFrame5 = new DiscreteStringKeyFrame("6orb", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3125)));
            StringKeyFrame keyFrame6 = new DiscreteStringKeyFrame("6g15", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.375)));
            StringKeyFrame keyFrame7 = new DiscreteStringKeyFrame("61ex", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.4375)));
            StringKeyFrame keyFrame8 = new DiscreteStringKeyFrame("6928", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5)));
            StringKeyFrame keyFrame9 = new DiscreteStringKeyFrame("6tma", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5625)));
            StringKeyFrame keyFrame10 = new DiscreteStringKeyFrame("6hfm", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.625)));
            StringKeyFrame keyFrame11 = new DiscreteStringKeyFrame("6jo4", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.6875)));
            StringKeyFrame keyFrame12 = new DiscreteStringKeyFrame("6r1m", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.75)));
            StringKeyFrame keyFrame13 = new DiscreteStringKeyFrame("6fwz", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.8125)));
            StringKeyFrame keyFrame14 = new DiscreteStringKeyFrame("6yb2", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.875)));
            StringKeyFrame keyFrame15 = new DiscreteStringKeyFrame("67b3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.9375)));
            StringKeyFrame keyFrame16 = new DiscreteStringKeyFrame("6801", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0)));
            StringKeyFrame keyFrame17 = new DiscreteStringKeyFrame("6cau", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0625)));
            StringKeyFrame keyFrame18 = new DiscreteStringKeyFrame("6ugt", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.125)));
            StringKeyFrame keyFrame19 = new DiscreteStringKeyFrame("6ung", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.1875)));
            StringKeyFrame keyFrame20 = new DiscreteStringKeyFrame("6u55", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.25)));
            StringKeyFrame keyFrame21 = new DiscreteStringKeyFrame("6u3o", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.3125)));
            StringKeyFrame keyFrame22 = new DiscreteStringKeyFrame("6udh", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.375)));
            StringKeyFrame keyFrame23 = new DiscreteStringKeyFrame("6uss", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.4375)));
            StringKeyFrame keyFrame24 = new DiscreteStringKeyFrame("6u8t", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5)));
            StringKeyFrame keyFrame25 = new DiscreteStringKeyFrame("6uyi", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5625)));
            StringKeyFrame keyFrame26 = new DiscreteStringKeyFrame("6uye", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.625)));
            StringKeyFrame keyFrame27 = new DiscreteStringKeyFrame("6uyc", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.6875)));
            StringKeyFrame keyFrame28 = new DiscreteStringKeyFrame("6uyl", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.75)));
            StringKeyFrame keyFrame29 = new DiscreteStringKeyFrame("6uy3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.8125)));
            StringKeyFrame keyFrame30 = new DiscreteStringKeyFrame("6uy7", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.875)));
            StringKeyFrame keyFrame31 = new DiscreteStringKeyFrame("6uyp", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.9375)));
            StringKeyFrame keyFrame32 = new DiscreteStringKeyFrame("6uy", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.0)));


            animation.KeyFrames.Add(keyFrame0);
            animation.KeyFrames.Add(keyFrame1);
            animation.KeyFrames.Add(keyFrame2);
            animation.KeyFrames.Add(keyFrame3);
            animation.KeyFrames.Add(keyFrame4);
            animation.KeyFrames.Add(keyFrame5);
            animation.KeyFrames.Add(keyFrame6);
            animation.KeyFrames.Add(keyFrame7);
            animation.KeyFrames.Add(keyFrame8);
            animation.KeyFrames.Add(keyFrame9);
            animation.KeyFrames.Add(keyFrame10);
            animation.KeyFrames.Add(keyFrame11);
            animation.KeyFrames.Add(keyFrame12);
            animation.KeyFrames.Add(keyFrame13);
            animation.KeyFrames.Add(keyFrame14);
            animation.KeyFrames.Add(keyFrame15);
            animation.KeyFrames.Add(keyFrame16);
            animation.KeyFrames.Add(keyFrame17);
            animation.KeyFrames.Add(keyFrame18);
            animation.KeyFrames.Add(keyFrame19);
            animation.KeyFrames.Add(keyFrame20);
            animation.KeyFrames.Add(keyFrame21);
            animation.KeyFrames.Add(keyFrame22);
            animation.KeyFrames.Add(keyFrame23);
            animation.KeyFrames.Add(keyFrame24);
            animation.KeyFrames.Add(keyFrame25);
            animation.KeyFrames.Add(keyFrame26);
            animation.KeyFrames.Add(keyFrame27);
            animation.KeyFrames.Add(keyFrame28);
            animation.KeyFrames.Add(keyFrame29);
            animation.KeyFrames.Add(keyFrame30);
            animation.KeyFrames.Add(keyFrame31);
            animation.KeyFrames.Add(keyFrame32);

            return animation;
        }


        private StringAnimationUsingKeyFrames buy264ck_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));

            // Create key frames
            StringKeyFrame keyFrame0 = new DiscreteStringKeyFrame("6uy", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0)));
            StringKeyFrame keyFrame1 = new DiscreteStringKeyFrame("6hkr", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0625)));
            StringKeyFrame keyFrame2 = new DiscreteStringKeyFrame("66b5", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.125)));
            StringKeyFrame keyFrame3 = new DiscreteStringKeyFrame("6vli", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.1875)));
            StringKeyFrame keyFrame4 = new DiscreteStringKeyFrame("67qs", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.25)));
            StringKeyFrame keyFrame5 = new DiscreteStringKeyFrame("6p5a", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.3125)));
            StringKeyFrame keyFrame6 = new DiscreteStringKeyFrame("6h4i", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.375)));
            StringKeyFrame keyFrame7 = new DiscreteStringKeyFrame("6tf9", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.4375)));
            StringKeyFrame keyFrame8 = new DiscreteStringKeyFrame("6fv8", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5)));
            StringKeyFrame keyFrame9 = new DiscreteStringKeyFrame("6eq1", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.5625)));
            StringKeyFrame keyFrame10 = new DiscreteStringKeyFrame("6hf2", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.625)));
            StringKeyFrame keyFrame11 = new DiscreteStringKeyFrame("6ia3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.6875)));
            StringKeyFrame keyFrame12 = new DiscreteStringKeyFrame("661n", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.75)));
            StringKeyFrame keyFrame13 = new DiscreteStringKeyFrame("6oqw", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.8125)));
            StringKeyFrame keyFrame14 = new DiscreteStringKeyFrame("6jqi", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.875)));
            StringKeyFrame keyFrame15 = new DiscreteStringKeyFrame("6dor", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.9375)));
            StringKeyFrame keyFrame16 = new DiscreteStringKeyFrame("6am8", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0)));
            StringKeyFrame keyFrame17 = new DiscreteStringKeyFrame("6jkl", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.0625)));
            StringKeyFrame keyFrame18 = new DiscreteStringKeyFrame("641n", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.125)));
            StringKeyFrame keyFrame19 = new DiscreteStringKeyFrame("64h0", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.1875)));
            StringKeyFrame keyFrame20 = new DiscreteStringKeyFrame("641g", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.25)));
            StringKeyFrame keyFrame21 = new DiscreteStringKeyFrame("64eh", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.3125)));
            StringKeyFrame keyFrame22 = new DiscreteStringKeyFrame("64ig", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.375)));
            StringKeyFrame keyFrame23 = new DiscreteStringKeyFrame("64x4", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.4375)));
            StringKeyFrame keyFrame24 = new DiscreteStringKeyFrame("64c5", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5)));
            StringKeyFrame keyFrame25 = new DiscreteStringKeyFrame("64c3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.5625)));
            StringKeyFrame keyFrame26 = new DiscreteStringKeyFrame("64cd", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.625)));
            StringKeyFrame keyFrame27 = new DiscreteStringKeyFrame("64cn", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.6875)));
            StringKeyFrame keyFrame28 = new DiscreteStringKeyFrame("64c5", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.75)));
            StringKeyFrame keyFrame29 = new DiscreteStringKeyFrame("64cf", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.8125)));
            StringKeyFrame keyFrame30 = new DiscreteStringKeyFrame("64cx", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.875)));
            StringKeyFrame keyFrame31 = new DiscreteStringKeyFrame("64c5", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(1.9375)));
            StringKeyFrame keyFrame32 = new DiscreteStringKeyFrame("64ck", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(2.0)));

            // Add key frames to animation
            animation.KeyFrames.Add(keyFrame0);
            animation.KeyFrames.Add(keyFrame1);
            animation.KeyFrames.Add(keyFrame2);
            animation.KeyFrames.Add(keyFrame3);
            animation.KeyFrames.Add(keyFrame4);
            animation.KeyFrames.Add(keyFrame5);
            animation.KeyFrames.Add(keyFrame6);
            animation.KeyFrames.Add(keyFrame7);
            animation.KeyFrames.Add(keyFrame8);
            animation.KeyFrames.Add(keyFrame9);
            animation.KeyFrames.Add(keyFrame10);
            animation.KeyFrames.Add(keyFrame11);
            animation.KeyFrames.Add(keyFrame12);
            animation.KeyFrames.Add(keyFrame13);
            animation.KeyFrames.Add(keyFrame14);
            animation.KeyFrames.Add(keyFrame15);
            animation.KeyFrames.Add(keyFrame16);
            animation.KeyFrames.Add(keyFrame17);
            animation.KeyFrames.Add(keyFrame18);
            animation.KeyFrames.Add(keyFrame19);
            animation.KeyFrames.Add(keyFrame20);
            animation.KeyFrames.Add(keyFrame21);
            animation.KeyFrames.Add(keyFrame22);
            animation.KeyFrames.Add(keyFrame23);
            animation.KeyFrames.Add(keyFrame24);
            animation.KeyFrames.Add(keyFrame25);
            animation.KeyFrames.Add(keyFrame26);
            animation.KeyFrames.Add(keyFrame27);
            animation.KeyFrames.Add(keyFrame28);
            animation.KeyFrames.Add(keyFrame29);
            animation.KeyFrames.Add(keyFrame30);
            animation.KeyFrames.Add(keyFrame31);
            animation.KeyFrames.Add(keyFrame32);

            return animation;
        }

        private StringAnimationUsingKeyFrames B1t32L0g1n_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, first_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));


        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Create storyboard and add animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(buy264ck_animation());

            // Start the storyboard
            storyboard.Begin(this);
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            if (FirstButton.Content == "64ck")
            {
                // Create storyboard and add animation
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(b4ck26uy_animation());

                // Start the storyboard
                storyboard.Begin(this);
            }
        }
    }
}
