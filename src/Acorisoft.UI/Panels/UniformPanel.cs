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

namespace Acorisoft.UI.Panels
{
    /// <summary>
    /// <see cref="IUniformPanel"/> 表示一个抽象的均分面板接口。
    /// </summary>
    public interface IUniformPanel
    {
        /// <summary>
        /// 获取或设置当前均分面板的布局方向。
        /// </summary>
        Orientation Orientation { get; set; }

        /// <summary>
        /// 获取或设置当前均分面板支持的最小布局大小。
        /// </summary>
        Size MinItemSize { get; set; }
    }

    /// <summary>
    /// <see cref="UniformPanel"/> 均分面板用于实现子级元素均分父级面板的空间大小。
    /// </summary>
    public class UniformPanel : Panel, IUniformPanel
    {
        private static readonly Size DefaultSize = new Size(100,100);

        protected override Size MeasureOverride(Size availableSize)
        {
            //
            // MeasureOverride 处理子元素测量
            return base.MeasureOverride(availableSize);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            //
            // 获得当前均分布局的方向
            Orientation thisDirection = Orientation;

            //
            // 获得最小的项目大小
            Size minItemSize = MinItemSize;

            var count = Children.Count;
            double finalUnitLength;
            double avgUnitLength;
            double xy_unit = 0;

            //if (thisDirection == Orientation.Horizontal)
            //{
            //     var count = Children.Count;
            //    var avgWidth = finalSize.Width / count;
            //    finalUnitLength = avgWidth < minItemSize.Width ? minItemSize.Width : avgWidth;
            //    var x = 0d;
            //    foreach(UIElement item in Children)
            //    {
            //        item.Arrange(new Rect(x, 0, finalUnitLength, finalSize.Height));
            //        x += finalUnitLength;
            //    }
            //}
            //else
            //{
            //     避免用于分配
            //     var count = Children.Count;
            //    var avgHeight = finalSize.Height / count;
            //    finalUnitLength = avgHeight < minItemSize.Height ? minItemSize.Height : avgHeight;
            //    var y = 0d;
            //    foreach (UIElement item in Children)
            //    {
            //        item.Arrange(new Rect(0, y, finalSize.Width, finalUnitLength));
            //        y += finalUnitLength;
            //    }
            //}

            if (thisDirection == Orientation.Horizontal)
            {
                // var count = Children.Count;
                avgUnitLength = finalSize.Width / count;
                finalUnitLength = avgUnitLength < minItemSize.Width ? minItemSize.Width : avgUnitLength;
                foreach (UIElement item in Children)
                {
                    item.Arrange(new Rect(xy_unit, 0, finalUnitLength, finalSize.Height));
                    xy_unit += finalUnitLength;
                }
            }
            else
            {
                // 避免用于分配
                // var count = Children.Count;
                avgUnitLength = finalSize.Height / count;
                finalUnitLength = avgUnitLength < minItemSize.Height ? minItemSize.Height : avgUnitLength;
                foreach (UIElement item in Children)
                {
                    item.Arrange(new Rect(0, xy_unit, finalSize.Width, finalUnitLength));
                    xy_unit += finalUnitLength;
                }
            }

            return base.ArrangeOverride(finalSize);
        }

        public Orientation Orientation
        {
            get => (Orientation)GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }

        /// <summary>
        /// 获取或设置当前应用的最小项目尺寸。
        /// </summary>
        /// <remarks>
        /// 均分面板推荐在有ScrollViewer的场景以及子元素项目数量较少的时候使用。如果
        /// </remarks>
        public Size MinItemSize
        {
            get => (Size)GetValue(MinItemSizeProperty);
            set => SetValue(MinItemSizeProperty, value);
        }

        public static readonly DependencyProperty MinItemSizeProperty = DependencyProperty.Register(
            "MinItemSize",
            typeof(Size),
            typeof(UniformPanel),
            new PropertyMetadata(Boxes.Box<Size>(), OnMinItemSizeChanged));


        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(
            "Orientation",
            typeof(Orientation),
            typeof(UniformPanel),
            new PropertyMetadata(Boxes.Box<Orientation>(), OnOrientationChanged));

        private static void OnMinItemSizeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (UIElement)d;
            element.InvalidateMeasure();
        }

        private static void OnOrientationChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (UIElement)d;
            element.InvalidateMeasure();
        }
    }
}
