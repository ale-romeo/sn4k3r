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
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Application;
using sn4k3r.Net;
using sn4k3r.MVVM.ViewModel;

namespace sn4k3r
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string cases = "abcdefghijklmnopqrstuvwxyz0123456789";
        bool logging = false;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
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

            for (double time = 0.0; time <= 10.0; time += 0.03125)
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

                if (a != 's' && time >= 0.5) a = 's';
                if (b != 'n' && time >= 1) b = 'n';
                if (c != '4' && time >= 1.5) c = '4';
                if (d != 'k' && time >= 2.2) d = 'k';
                if (e != '3' && time >= 3) e = '3';
                if (f != 'r' && time >= 4) f = 'r';

                char[] chars = { a, b, c, d, e, f };
                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "sn4k3r")
                    break;
            }

            return animation;
        }

        private StringAnimationUsingKeyFrames thirdline_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, third_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = 'S', b = 'n', c = '_', d = '_', e = 'k', f = '_', g = 'r';

            for (double time = 0.0625; time <= 10.0; time += 0.0625)
            {
                Random rnd = new Random();
                c = cases[rnd.Next(cases.Length)];
                d = cases[rnd.Next(cases.Length)];
                f = cases[rnd.Next(cases.Length)];

                if (time >= 3) c = '3';

                if (time >= 3.5) d = '4';

                if (time >= 4) f = '3';

                char[] chars = { a, b, c, d, e, f, g };
                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "Sn34k3r")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("Sn34k3r", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("Sn34k3r", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(10.0))));
            animation.RepeatBehavior = RepeatBehavior.Forever;

            return animation;
        }

        private StringAnimationUsingKeyFrames logo_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, opening_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_';

            for (double time = 0.03125; time <= 10.0; time += 0.03125)
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

                if (a != 's' && time >= 0.5) a = 's';
                if (b != 'n' && time >= 1) b = 'n';
                if (c != '4' && time >= 1.5) c = '4';
                if (d != 'k' && time >= 2.2) d = 'k';
                if (e != '3' && time >= 3) e = '3';
                if (f != 'r' && time >= 4) f = 'r';

                char[] chars = { a, b, c, d, e, f };
                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "sn4k3r")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("sn4k3r", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames b4ck26uy_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));


            char a = '_', b = '_', c = '_', d = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
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

                if (a != '6' && time >= 1) a = '6';
                if (b != 'u' && time >= 2) b = 'u';
                if (c != 'y' && time >= 3) c = 'y';

                char[] chars = { a, b, c, d };
                char[] nchars = { a, b, c };
                if (time >= 3 || new string(nchars) == "6uy") chars = nchars;

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "6uy")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("64ck", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames buy264ck_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, FirstButton);
            Storyboard.SetTargetProperty(animation, new PropertyPath(Button.ContentProperty));


            char a = '_', b = '_', c = '_', d = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
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

                if (a != '6' && time >= 1) a = '6';
                if (b != '4' && time >= 2) b = '4';
                if (c != 'c' && time >= 3) c = 'c';
                if (d != 'k' && time >= 4) d = 'k';

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

            for (double time = 0.03125; time <= 10; time+=0.03125)
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

                if (a != 'L' && time >= 0.75) a = 'L';
                if (b != '0' && time >= 1.5) b = '0';
                if (c != 'g' && time >= 2.25) c = 'g';
                if (d != '1' && time >= 3) d = '1';
                if (e != 'n' && time >= 3.75) e = 'n';

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

            for (double time = 0.03125; time <= 10; time += 0.03125)
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

                if (a != 'B' && time >= 1) a = 'B';
                if (b != '1' && time >= 2) b = '1';
                if (c != 't' && time >= 3) c = 't';
                if (d != '3' && time >= 4) c = '3';

                char[] chars = { a, b, c, d, e };
                char[] nchars = { a, b, c, d };

                if (time >= 4 || new string(nchars) == "B1t3") chars = nchars;

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "B1t3")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("L0g1n", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames Us3rn4m32Y0ur_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, second_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_', g = '_', h = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 'Y')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'Y' && b != '0')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'Y' && b == '0' && c != 'u')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'Y' && b == '0' && c == 'u' && d != 'r')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }

                char[] four_chars = { a, b, c, d };
                char[] five_chars = { a, b, c, d, e };
                char[] six_chars = { a, b, c, d, e, f };
                char[] seven_chars = { a, b, c, d, e, f, g };
                char[] chars = { a, b, c, d, e, f, g, h };

                if (a != 'Y' && time >= 0.5) a = 'Y';
                if (b != '0' && time >= 1) b = '0';
                if (c != 'u' && time >= 1.5) c = 'u';
                if (d != 'r' && time >= 2) d = 'r';

                if (time >= 0.5) chars = seven_chars;
                if (time >= 1.0) chars = six_chars;
                if (time >= 1.5) chars = five_chars;
                if (time >= 2 && new string(four_chars).Equals("Y0ur")) chars = four_chars;

                string txt = new string(chars);


                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt.Equals("Y0ur"))
                {
                    break;
                }
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("Us3rn4m3", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames Y0ur2Us3rn4m3_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, second_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_', g = '_', h = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 'U')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b != 's')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c != '3')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c == '3' && d != 'r')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c == '3' && d == 'r' && e != 'n')
                {
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c == '3' && d == 'r' && e == 'n' && f != '4')
                {
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c == '3' && d == 'r' && e == 'n' && f == '4' && g != 'm')
                {
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'U' && b == 's' && c == '3' && d == 'r' && e == 'n' && f == '4' && g == 'm' && h != '3')
                    h = cases[rnd.Next(cases.Length)];

                char[] chars = { a, b, c, d };
                char[] five_chars = { a, b, c, d, e };
                char[] six_chars = { a, b, c, d, e, f };
                char[] seven_chars = { a, b, c, d, e, f, g };
                char[] eight_chars = { a, b, c, d, e, f, g, h };

                if (a != 'U' && time >= 0.5) a = 'U';
                if (b != 's' && time >= 1) b = 's';
                if (c != '3' && time >= 1.5) c = '3';
                if (d != 'r' && time >= 2) d = 'r';
                if (e != 'n' && time >= 2.5) e = 'n';
                if (f != '4' && time >= 3) f = '4';
                if (g != 'm' && time >= 3.5) g = 'm';
                if (h != '3' && time >= 4) h = '3';


                if (new string(five_chars) != "Us3rn") chars = five_chars;
                else if (new string(six_chars) != "Us3rn4") chars = six_chars;
                else if (new string(seven_chars) != "Us3rn4m") chars = seven_chars;
                else chars = eight_chars;

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "Us3rn4m3")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame("Y0ur", KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames Sn34k3r2P4ssw0rd_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, third_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_', g = '_', h = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 'P')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b != '4')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c != 's')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c == 's' && d != 's')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c == 's' && d == 's' && e != 'w')
                {
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c == 's' && d == 's' && e == 'w' && f != '0')
                {
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c == 's' && d == 's' && e == 'w' && f == '0' && g != 'r')
                {
                    g = cases[rnd.Next(cases.Length)];
                    h = cases[rnd.Next(cases.Length)];
                }
                if (a == 'P' && b == '4' && c == 's' && d == 's' && e == 'w' && f == '0' && g == 'r' && h != 'd')
                    h = cases[rnd.Next(cases.Length)];

                char[] chars = { a, b, c, d, e, f, g, h };

                if (a != 'P' && time >= 0.5) a = 'P';
                if (b != '4' && time >= 1) b = '4';
                if (c != 's' && time >= 1.5) c = 's';
                if (d != 's' && time >= 2) d = 's';
                if (e != 'w' && time >= 2.5) e = 'w';
                if (f != '0' && time >= 3) f = '0';
                if (g != 'r' && time >= 3.5) g = 'r';
                if (h != 'd' && time >= 4) h = 'd';

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "P4ssw0rd")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame(third_line.Text, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private StringAnimationUsingKeyFrames P4ssw0rd2Sn34k3r_animation()
        {
            StringAnimationUsingKeyFrames animation = new StringAnimationUsingKeyFrames();
            Storyboard.SetTarget(animation, third_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.TextProperty));

            char a = '_', b = '_', c = '_', d = '_', e = '_', f = '_', g = '_';

            for (double time = 0.03125; time <= 10; time += 0.03125)
            {
                Random rnd = new Random();
                if (a != 'S')
                {
                    a = (cases.ToUpper())[rnd.Next(cases.Length)];
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b != 'n')
                {
                    b = cases[rnd.Next(cases.Length)];
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b == 'n' && c != '3')
                {
                    c = cases[rnd.Next(cases.Length)];
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b == 'n' && c == '3' && d != '4')
                {
                    d = cases[rnd.Next(cases.Length)];
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b == 'n' && c == '3' && d == '4' && e != 'k')
                {
                    e = cases[rnd.Next(cases.Length)];
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b == 'n' && c == '3' && d == '4' && e == 'k' && f != '3')
                {
                    f = cases[rnd.Next(cases.Length)];
                    g = cases[rnd.Next(cases.Length)];
                }
                if (a == 'S' && b == 'n' && c == '3' && d == '4' && e == 'k' && f == '3' && g != 'r')
                    g = cases[rnd.Next(cases.Length)];


                char[] chars = { a, b, c, d, e, f, g };

                if (a != 'S' && time >= 0.75) a = 'S';
                if (b != 'n' && time >= 1.5) b = 'n';
                if (c != '3' && time >= 2.25) c = '3';
                if (d != '4' && time >= 3) d = '4';
                if (e != 'k' && time >= 3.75) e = 'k';
                if (f != '3' && time >= 4.5) f = '3';
                if (g != 'r' && time >= 5.25) g = 'r';

                string txt = new string(chars);

                animation.KeyFrames.Add(new DiscreteStringKeyFrame(txt, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(time))));
                if (txt == "Sn34k3r")
                    break;
            }
            animation.KeyFrames.Add(new DiscreteStringKeyFrame(third_line.Text, KeyTime.FromTimeSpan(TimeSpan.FromSeconds(0.0))));

            return animation;
        }

        private DoubleAnimation thirdline_font(int a, int b)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, third_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.FontSizeProperty));
            animation.From = a;
            animation.To = b;
            return animation;
        }
        private DoubleAnimation secondline_font(int a, int b)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, second_line);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBlock.FontSizeProperty));
            animation.From = a;
            animation.To = b;
            return animation;
        }

        private DoubleAnimation userbox_animation(int a, int b)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, UsernameBox);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBox.OpacityProperty));
            animation.Duration = TimeSpan.FromSeconds(3.5);
            animation.From = a;
            animation.To = b;
            return animation;
        }
        private DoubleAnimation passbox_animation(int a, int b)
        {
            DoubleAnimation animation = new DoubleAnimation();
            Storyboard.SetTarget(animation, PasswordBox);
            Storyboard.SetTargetProperty(animation, new PropertyPath(TextBox.OpacityProperty));
            animation.Duration = TimeSpan.FromSeconds(3.5);
            animation.From = a;
            animation.To = b;
            return animation;
        }


        private void MouseOverLogo_Routine(object sender, MouseEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(logo_animation());

            storyboard.Begin(this);
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (!logging)
            {
                second_line.Foreground = Brushes.Gray;
                third_line.Foreground = Brushes.Gray;
                PasswordBox.IsEnabled = true;
                UsernameBox.IsEnabled = true;


                // Create storyboard and add animation
                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(buy264ck_animation());
                storyboard.Children.Add(B1t32L0g1n_animation());
                storyboard.Children.Add(Y0ur2Us3rn4m3_animation());
                storyboard.Children.Add(Sn34k3r2P4ssw0rd_animation());
                storyboard.Children.Add(secondline_font(26, 20));
                storyboard.Children.Add(thirdline_font(26, 20));
                storyboard.Children.Add(userbox_animation(0, 100));
                storyboard.Children.Add(passbox_animation(0, 100));

                // Start the storyboard
                storyboard.Begin(this);
                logging = true;

                MainViewModel vm = (MainViewModel)DataContext;
                login_button.Command = vm.ConnectToServerCommand;
                Binding usernameBinding = new Binding("Username");
                usernameBinding.Source = vm;
                usernameBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                usernameBinding.Mode = BindingMode.TwoWay;
                UsernameBox.SetBinding(TextBox.TextProperty, usernameBinding);

                Binding passwordBinding = new Binding("Password");
                passwordBinding.Source = vm;
                passwordBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
                PasswordBox.SetBinding(TextBox.TextProperty, passwordBinding);

            }
            
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            if ((FirstButton.Content).ToString().Equals("64ck"))
            {
                second_line.Foreground = Brushes.White;
                third_line.Foreground = Brushes.White;
                PasswordBox.IsEnabled = false;
                UsernameBox.IsEnabled = false;

                Storyboard storyboard = new Storyboard();
                storyboard.Children.Add(b4ck26uy_animation());
                storyboard.Children.Add(L0g1n2B1t3_animation());
                storyboard.Children.Add(Us3rn4m32Y0ur_animation());
                storyboard.Children.Add(P4ssw0rd2Sn34k3r_animation());
                storyboard.Children.Add(secondline_font(20, 26));
                storyboard.Children.Add(thirdline_font(20, 26));
                storyboard.Children.Add(userbox_animation(100,0));
                storyboard.Children.Add(passbox_animation(100,0));

                // Start the storyboard
                storyboard.Begin(this);

                PasswordBox.Text = "";
                UsernameBox.Text = "";
                logging = false;

                login_button.Command = null;
            }
        }


        private void StartRoutine(object sender, RoutedEventArgs e)
        {
            Storyboard storyboard = new Storyboard();
            storyboard.Children.Add(title_animation());
            storyboard.Children.Add(thirdline_animation());

            storyboard.Begin(this);
        }
    }
}
