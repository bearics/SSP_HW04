using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Paint
{
    public enum ToolsType { Pen=0, Brush, Line, Square, Circle  }

    public class Tools
    {
        public ToolsType mType;

        public Color mColor;
        public int mThick;
        public bool mIsFill;

        public Tools()
        {
            mType = ToolsType.Pen;
            mColor = Color.Black;
            mThick = 1;
            mIsFill = false;
        }
    }

    public class Pens : Tools
    {
        public List<Point> point;

        public Pens(Color color, Point po) : base()
        {
            mType = ToolsType.Pen;
            mThick = 1;
            point = new List<Point>();
            point.Add(po);
            mColor = color;
        }

        public void Draw(Graphics g)
        {
            for(int i=0; i<point.Count-1;i++)
            {
                g.DrawLine(new Pen(mColor, 1), point[i], point[i + 1]);
            }
        }

        public void Add(Point po)
        {
            point.Add(po);
        }
    }

    public class Brushes : Tools
    {
        public List<Point> point;

        public Brushes(Color color, Point po) : base()
        {
            mType = ToolsType.Brush;
            mThick = 5;
            point = new List<Point>();
            point.Add(po);
            mColor = color;
        }

        public void Draw(Graphics g)
        {
            for (int i = 0; i < point.Count - 1; i++)
            {
                g.DrawLine(new Pen(mColor, 5), point[i], point[i + 1]);
            }
        }

        public void Add(Point po)
        {
            point.Add(po);
        }
    }

    public class Lines : Tools
    {
        public Point mStartPoint;
        public Point mFinPoint;

        public Lines(Color color, int Thick, Point po) : base()
        {
            mType = ToolsType.Line;
            mThick = Thick;
            mStartPoint = po;
            mColor = color;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(mColor, base.mThick), mStartPoint, mFinPoint);
        }

        public void Add(Point po)
        {
            mFinPoint = po;
        }
    }

    public class Squares : Tools
    {
        public Point mStartPoint;
        public Point mFinPoint;

        public Squares(Color color, int Thick, bool isFill, Point po) : base()
        {
            mType = ToolsType.Square;
            mThick = Thick;
            mIsFill = isFill;
            mColor = color;
            mStartPoint = po;
        }

        public void Draw(Graphics g)
        {
            Point point = new Point(Math.Min(mStartPoint.X, mFinPoint.X), Math.Min(mStartPoint.Y, mFinPoint.Y));
            Size size = new Size(Math.Abs( mFinPoint.X - mStartPoint.X),Math.Abs(mFinPoint.Y - mStartPoint.Y) );
            Rectangle rectangle = new Rectangle(point, size);
            if (mIsFill)
            { // Fill rectangle
                g.FillRectangle(new SolidBrush(mColor), rectangle);
            }
            else
            {
                g.DrawRectangle(new Pen(mColor, mThick), rectangle);
            }
            
        }

        public void Add(Point po)
        {
            mFinPoint = po;
        }
    }

    public class Circles : Tools
    {
        public Point mStartPoint;
        public Point mFinPoint;

        public Circles(Color color, int Thick, bool isFill, Point po) : base()
        {
            mType = ToolsType.Circle;
            mThick = Thick;
            mIsFill = isFill;
            mColor = color;
            mStartPoint = po;
        }

        public void Draw(Graphics g)
        {
            Point point = new Point(Math.Min(mStartPoint.X, mFinPoint.X), Math.Min(mStartPoint.Y, mFinPoint.Y));
            Size size = new Size(Math.Abs(mFinPoint.X - mStartPoint.X), Math.Abs(mFinPoint.Y - mStartPoint.Y));
            Rectangle rectangle = new Rectangle(point, size);
            if (mIsFill)
            { // Fill Circle
                g.FillEllipse(new SolidBrush(mColor), rectangle);
            }
            else
            {
                g.DrawEllipse(new Pen(mColor, mThick), rectangle);
            }

        }

        public void Add(Point po)
        {
            mFinPoint = po;
        }
    }

}
