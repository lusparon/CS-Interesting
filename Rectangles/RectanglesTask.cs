using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
            bool res = false;
            if ((Math.Min(r1.Right, r2.Right) >= Math.Max(r1.Left, r2.Left)) && (Math.Min(r1.Bottom, r2.Bottom) >= Math.Max(r1.Top, r2.Top)))
                res = true;
			return res;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            int res = 0;
            if (AreIntersected(r1, r2))
                res = (Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left) ) * (Math.Min(r1.Bottom,r2.Bottom)-Math.Max(r1.Top,r2.Top));
            return res;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            int res = -1;
            if (((Math.Min(r1.Right, r2.Right) - Math.Max(r1.Left, r2.Left))
                == Math.Min(r1.Width, r2.Width)) && ((Math.Min(r1.Bottom, r2.Bottom) - 
                Math.Max(r1.Top, r2.Top)) == Math.Min(r1.Height, r2.Height)))
                if (r1.Width < r2.Width)
                    res = 0;
                else
                    if (r1.Width == r2.Width)
                        res = r1.Height < r2.Height ? 0 : 1;
                else
                        if (r1.Width > r2.Width)
                            res = 1;
                if (!( (r1.Width == Math.Min(Math.Abs(r1.Width), Math.Abs(r2.Width))) && (r1.Height == Math.Min(Math.Abs(r1.Height), Math.Abs(r2.Height)))) && !(( r2.Width == Math.Min(Math.Abs(r1.Width), Math.Abs(r2.Width))) && (r2.Height == Math.Min(Math.Abs(r1.Height), Math.Abs(r2.Height)))))
                    res = -1;
			return res;
		}
	}
}