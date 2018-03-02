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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1 ()
        {
            int length = 5;
            InitializeComponent ();
            for (int i = 0; i < length; i++)
            {
               
                CreateARectangle (i);
            }
            


        }


        public void CreateARectangle (int i)

        {
            List<int> listofNumber = new List<int> (100);
            listofNumber.Add (-80);
            listofNumber.Add (-50);
            listofNumber.Add (-20);
            listofNumber.Add (0);
            listofNumber.Add (100);
            listofNumber.Add (60);

            Rectangle RedRectangle = new Rectangle ();


            RedRectangle.Height = Math.Abs(listofNumber[i]);

            RedRectangle.Width = 40;


            SolidColorBrush RedBrush = new SolidColorBrush ();
            if (i <= 2)
            {
                RedBrush.Color = Colors.Green;
            }
            else
            {
                RedBrush.Color = Colors.Red;
               
            }
            

            RedRectangle.Fill = RedBrush;

            Grid.SetColumn (RedRectangle, i);   
            Grid.SetRow (RedRectangle, i);
            if (listofNumber[i] > 0)
            {
                RotateTransform rotateTransform1 = new RotateTransform (180);
                RedRectangle.RenderTransform = rotateTransform1;
            }

            grid1.Children.Add (RedRectangle);



        }
    }
}
