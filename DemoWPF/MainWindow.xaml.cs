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

namespace DemoWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _clickCounter = 0;

        public MainWindow()
        {
            InitializeComponent();

            //Loaded += MainWindow_Loaded;
        }
        /*
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            lvTest.ItemsSource = MyItems;
        }
        */

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            _clickCounter++;

            txtTest.Text = "Button Test Click: " + _clickCounter.ToString();
            


            ScaleTransform myScaleTransform = new ScaleTransform();
            myScaleTransform.ScaleY = 1;
            myScaleTransform.ScaleX = 1;

            RotateTransform myRotateTransform = new RotateTransform();
            myRotateTransform.Angle = 15 - _clickCounter;

            TranslateTransform myTranslate = new TranslateTransform();
            myTranslate.X = 0;
            myTranslate.X = 0;

            SkewTransform mySkew = new SkewTransform();
            mySkew.AngleX = -15 + _clickCounter;
            mySkew.AngleY = 0;

            TransformGroup myTransformGroup = new TransformGroup();
            myTransformGroup.Children.Add(myScaleTransform);
            myTransformGroup.Children.Add(myRotateTransform);
            myTransformGroup.Children.Add(myTranslate);
            myTransformGroup.Children.Add(mySkew);

            txtTest.RenderTransform = myTransformGroup;


            

            return;
        }

        private void btnTest_MouseLeave(object sender, MouseEventArgs e)
        {
            recTest.Fill = Brushes.Bisque;
        }

        private void btnTest_MouseEnter(object sender, MouseEventArgs e)
        {
            recTest.Fill = Brushes.BlueViolet;
        }

        private void btnTest_MouseDown(object sender, MouseButtonEventArgs e)
        {
            recTest.Fill = Brushes.Red;
        }

        private void btnTest_MouseUp(object sender, MouseButtonEventArgs e)
        {
            recTest.Fill = Brushes.BlueViolet;
        }

        

        public class MyItem
        {
            private string _fName;
            private string _lName;

            public string FName { get { return _fName; } }
            public string LName { get { return _lName; } }


            public MyItem(string fName, string lName)
            {
                _fName = fName;
                _lName = lName;
            }




            public override string ToString()
            {
                return FName + " " + LName;
            }
        }

        public List<MyItem> MyItems
        {
            get
            {
                List<MyItem> items = new List<MyItem>();

                items.Add(new MyItem("Ivan", "Ivanov"));
                items.Add(new MyItem("Peter", "Petrov"));
                items.Add(new MyItem("Sidor", "Sidorov"));

                items.Add(new MyItem("Ivan", "Ivanov"));
                items.Add(new MyItem("Peter", "Petrov"));
                items.Add(new MyItem("Sidor", "Sidorov"));

                items.Add(new MyItem("Ivan", "Ivanov"));
                items.Add(new MyItem("Peter", "Petrov"));
                items.Add(new MyItem("Sidor", "Sidorov"));

                return items;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            lvTest.ItemsSource = MyItems;
        }
    }
}
