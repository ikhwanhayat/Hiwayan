using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Hiwayan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;

            Loaded += MainWindow_Loaded;
        }

        HiwayanConfiguration config = (HiwayanConfiguration)ConfigurationManager.GetSection("HiwayanConfiguration");

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            wrapPanel.Margin = new Thickness(15);

            foreach (var media in config.MediaList)
            {
                var btn = new Button
                {
                    Tag = media,
                    Height = 268,
                    Width = 182,
                    Margin = new Thickness(15),
                    Content = new Image
                    {
                    
                        Source = new BitmapImage(new Uri(media.Thumbnail)),
                        Stretch = System.Windows.Media.Stretch.Fill
                    }
                };

                btn.Click += Media_Click;
                
                wrapPanel.Children.Add(btn);
            }

            //MainGrid.Children.Add(new TextBlock { Text = typeof(BlogSettings).AssemblyQualifiedName });
        }

        void Media_Click(object sender, RoutedEventArgs e)
        {
            var btn = (Button)sender;
            var media = (Media)btn.Tag;
            System.Diagnostics.Process.Start(media.Path);
        }
    }
}
