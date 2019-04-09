using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки (x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
                if ((ax == x && ay == y) || (bx == x && by == y)) return 0;

                var AB = GetDistanceBetweenPoints(ax, ay, bx, by);
                var AC = GetDistanceBetweenPoints(ax, ay, x, y);

                if (AB == 0) return AC;

                var BC = GetDistanceBetweenPoints(bx, by, x, y);

                if (IsObtuseAngle(AC, BC, AB)) return BC;
                if (IsObtuseAngle(BC, AC, AB)) return AC;

                var p = (AC + BC + AB) / 2;
                return 2 * Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC)) / AB;
        }

        // Расстояние между точками (x1, y1) и (x2, y2)
        public static double GetDistanceBetweenPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        // Является ли угол, противолежащий стороне oppositeLine тупым
        public static bool IsObtuseAngle(double oppositeLine, double a, double b)
        {
            var cos = (a * a + b * b - oppositeLine * oppositeLine) / (2 * a * b);
            return cos < 0;
        }

    }
}