using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        private static string cases = "abcdefghijklmnopqrstuvwxyz0123456789";

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

        private StringAnimationUsingKeyFrames title_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, title);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_';

            for (double time = 0.0; time <= 40; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 's')
                {
                    a = cases[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }
                if (a == 's' && b != 'n')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }
                if (a == 's' && b == 'n' && c != '4')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }
                if (a == 's' && b == 'n' && c == '4' && d != 'k')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }
                if (a == 's' && b == 'n' && c == '4' && d == 'k' && e != '3')
                {
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }
                if (a == 's' && b == 'n' && c == '4' && d == 'k' && e == '3' && f != 'r')
                {
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                }

                char[] chars = { a, b, c, d, e, f };

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "sn4k3r")
                    break;
            }

            return animation;
        }

        private StringAnimationUsingKeyFrames b4ck26uy_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));


            char a = '_', b = '_', c = '_', d = '_';

            for (double time = 0.03125; time <= 40; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != '6')
                {
                    a = cases[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                if (a == '6' && b != 'u')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                if (a == '6' && b == 'u' && c != 'y')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                char[] chars = { a, b, c, d };

                //togliere un carattere

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "6uy")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("6uy", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));

            return animation;
        }


        private StringAnimationUsingKeyFrames buy264ck_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));


            char a = '_', b = '_', c = '_', d = '_';

            for (double time = 0.03125; time <= 40; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != '6')
                {
                    a = cases[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                if (a == '6' && b != '4')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                if (a == '6' && b == '4' && c != 'c')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                }
                if (a == '6' && b == '4' && c == 'c' && d != 'k')
                {
                    d = cases[rnd.Next(cases.Length)];
                }

                char[] chars = { a, b, c, d };

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "64ck")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("6uy", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames B1t32L0g1n_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, first_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_';

            for (double time = 0.03125; time <= 40; time+=0.03125)
            {
                Random rnd = new Random();
                if (a != 'L')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'L' && b != '0')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'L' && b == '0' && c != 'g')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'L' && b == '0' && c == 'g' && d != '1')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];

                }
                if (a == 'L' && b == '0' && c == 'g' && d == '1' && e != 'n')
                {
                    e = cases[rnd.Next(cases.Length)];
                }

                char[] chars = { a, b, c, d, e };

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "L0g1n")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("B1t3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames L0g1n2B1t3_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, first_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_';

            for (double time = 0.03125; time <= 40; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 'B')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'B' && b != '1')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'B' && b == '1' && c != 't')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                }
                if (a == 'B' && b == '1' && c == 't' && d != '3')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];

                }

                char[] chars = { a, b, c, d, e };

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "B1t3")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("L0g1n", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Create storyboard and add animation
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(buy264ck_animation());
            storyboard.Children.Add(B1t32L0g1n_animation());

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
                storyboard.Children.Add(L0g1n2B1t3_animation());

                // Start the storyboard
                storyboard.Begin(this);
            }
        }


        private void StartRoutine(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(title_animation());

            storyboard.Begin(this);
        }
    }
}
