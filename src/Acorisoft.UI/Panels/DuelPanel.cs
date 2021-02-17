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
    /// <see cref="DuelPanel"/> 表示一个只支持双元素布局的面板。用于快速计算。
    /// </summary>
    public class DuelPanel : Panel
    {
        private static readonly Point Zero = new Point(0, 0);

        protected class AlwaysTwoUIElementCollection : UIElementCollection
        {
            public AlwaysTwoUIElementCollection(UIElement visualParent, FrameworkElement logicalParent) : base(visualParent, logicalParent)
            {

            }

            public override int Add(UIElement element)
            {
                if (Count < 2)
                {
                    return base.Add(element);
                }

                return -1;
            }

            public override void Insert(int index, UIElement element)
            {
                if (Count < 2)
                {
                    base.Insert(index, element);
                }
            }
        }

        protected override sealed UIElementCollection CreateUIElementCollection(FrameworkElement logicalParent)
        {
            return new AlwaysTwoUIElementCollection(this, logicalParent);
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            if (Children.Count < 2)
            {
                foreach (UIElement item in Children)
                {
                    item.Arrange(new Rect(Zero, finalSize));
                }
            }
            else
            {
                var length = FixPartLegnth;
                switch (Direction)
                {
                    case Dock.Top:
                        ArrangeTopDirection(length, finalSize);
                        break;
                    case Dock.Bottom:
                        ArrangeBottomDirection(length, finalSize);
                        break;
                    case Dock.Right:
                        ArrangeRightDirection(length, finalSize);
                        break;
                    case Dock.Left:
                    default:
                        ArrangeLeftDirection(length, finalSize);
                        break;
                }
            }

            return base.ArrangeOverride(finalSize);
        }

        protected virtual void ArrangeLeftDirection(double fixPartLength, Size finalSize)
        {
            //
            // 左边是固定部分，右边是拓展部份
            //
            // 左边的尺寸计算为:
            // x: 0
            // y: 0
            // width : fixPartLength
            // height = finalSize.Height
            //
            // 右边
            // x: fixPartLength
            // y: 0
            // width : finalSize.Width - fixPartLength
            // height = finalSize.Height
            //
            var fixPart = Children[0];
            var dynamicPart = Children[1];

            fixPart.Arrange(new Rect(0, 0, fixPartLength, finalSize.Height));
            dynamicPart.Arrange(new Rect(fixPartLength, 0, finalSize.Width - fixPartLength, finalSize.Height));
        }

        protected virtual void ArrangeRightDirection(double fixPartLength, Size finalSize)
        {
            //
            // 左边是拓展部分，右边是固定部份
            //
            // 左边的尺寸计算为:
            // x: 0
            // y: 0
            // width : finalSize.Width - fixPartLength
            // height = finalSize.Height
            //
            // 右边
            // x: finalSize.Width - fixPartLength
            // y: 0
            // width : fixPartLength
            // height = finalSize.Height
            //
            var dynamicPart = Children[0];
            var fixPart = Children[1];

            fixPart.Arrange(new Rect(finalSize.Width - fixPartLength, 0, fixPartLength, finalSize.Height));
            dynamicPart.Arrange(new Rect(0, 0, finalSize.Width - fixPartLength, finalSize.Height));
        }

        protected virtual void ArrangeTopDirection(double fixPartLength, Size finalSize)
        {
            //
            // 上边边是固定部分，下边是拓展部份
            //
            // 上边的尺寸计算为:
            // x: 0
            // y: 0
            // width : finalSize.Width
            // height = fixPartLength
            //
            // 下边
            // x: 0
            // y: fixPartLength
            // width : finalSize.Width
            // height = finalSize.Height - fixPartLength
            //

            var dynamicPart = Children[0];
            var fixPart = Children[1];

            fixPart.Arrange(new Rect(0, 0, finalSize.Width, fixPartLength));
            dynamicPart.Arrange(new Rect(0, fixPartLength, finalSize.Width, finalSize.Height - fixPartLength));
        }
        protected virtual void ArrangeBottomDirection(double fixPartLength, Size finalSize)
        {
            //
            // 下边边是固定部分，上边是拓展部份
            //
            // 上边的尺寸计算为:
            // x: 0
            // y: 0
            // width : finalSize.Width
            // height = finalSize.Height - fixPartLength
            //
            // 下边
            // x: 0
            // y: finalSize.Height - fixPartLength
            // width : finalSize.Width
            // height = fixPartLength
            //

            var dynamicPart = Children[0];
            var fixPart = Children[1];

            fixPart.Arrange(new Rect(0, 0, finalSize.Width, fixPartLength));
            dynamicPart.Arrange(new Rect(0, finalSize.Height - fixPartLength, finalSize.Width, finalSize.Height - fixPartLength));
        }

        public Dock Direction
        {
            get => (Dock)GetValue(DirectionProperty);
            set => SetValue(DirectionProperty, value);
        }
        public double FixPartLegnth
        {
            get => (double)GetValue(MainPartLegnthProperty);
            set => SetValue(MainPartLegnthProperty, value);
        }

        public static readonly DependencyProperty MainPartLegnthProperty = DependencyProperty.Register(
            "FixPartLegnth",
            typeof(double),
            typeof(DuelPanel),
            new PropertyMetadata(0d, OnValueChanged));


        public static readonly DependencyProperty DirectionProperty = DependencyProperty.Register(
            "Direction",
            typeof(Dock),
            typeof(DuelPanel),
            new PropertyMetadata(Boxes.Box<Dock>(), OnValueChanged));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = (UIElement)d;
            element.InvalidateMeasure();
        }

    }
}
