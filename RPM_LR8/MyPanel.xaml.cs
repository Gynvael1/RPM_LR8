using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace RPM_LR8
{
    public partial class MyPanel : UserControl
    {
        public double StartX { get; set; }
        public double StartY { get; set; }
        public double StartSkew { get; set; }
        public double StartScaleX { get; set; }
        public double StartScaleY { get; set; }
        public double StartOpacity { get; set; }

        public MyPanel()
        {
            InitializeComponent();
            Loaded += (s, e) =>
            {
                ((TranslateTransform)((TransformGroup)Panel.RenderTransform).Children[0]).X = StartX;
                ((TranslateTransform)((TransformGroup)Panel.RenderTransform).Children[0]).Y = StartY;
                ((SkewTransform)((TransformGroup)Panel.RenderTransform).Children[1]).AngleY = StartSkew;
                ((ScaleTransform)((TransformGroup)Panel.RenderTransform).Children[2]).ScaleX = StartScaleX;
                ((ScaleTransform)((TransformGroup)Panel.RenderTransform).Children[2]).ScaleY = StartScaleY;
                Panel.Opacity = StartOpacity;
            };
        }
    }
}
