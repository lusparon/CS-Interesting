using System.Linq;

namespace Recognizer
{
	internal static class MedianFilterTask
	{
		/* 
		 * Для борьбы с пиксельным шумом, подобным тому, что на изображении,
		 * обычно применяют медианный фильтр, в котором цвет каждого пикселя, 
		 * заменяется на медиану всех цветов в некоторой окрестности пикселя.
		 * https://en.wikipedia.org/wiki/Median_filter
		 * 
		 * Используйте окно размером 3х3 для не граничных пикселей,
		 * Окно размером 2х2 для угловых и 3х2 или 2х3 для граничных.
		 */
		public static double[,] MedianFilter(double[,] original)
		{
            int width = original.GetLength(0);
            int length = original.GetLength(1);
            double[,] res = new double[width, length];
            int window_width; // ширина окна
            int window_length; // длина окна

            for (int i = 0; i < width; i++)
                for (int j = 0; j < length; j++) //Цикл по всем пикселям
                {
                    //находим размер окна для пикселя
                    if (i == 0 || i == width -1)
                    {
                        if (j == 0 || j == length - 1)
                        {
                            window_width = 2;
                            window_length = 2;
                        }
                        else
                        {
                            window_width = 2;
                            window_length = 3;
                        }

                    }
                    else 
                    if (j == 0 || j == length-1)
                    {
                        if (i == 0 || i == width - 1)
                        {
                            window_width = 2;
                            window_length = 2;
                        }
                        else
                        {
                            window_width = 3;
                            window_length = 2;
                        }
                    }
                    else
                    {
                        window_width = 3;
                        window_length = 3;
                    }

                    double[] arr = new double[window_width * window_length];
                    int k = 0;//счетчик

                    if (window_width == 3 && window_length == 3)
                        for (int ii = i - 1; ii < i + 2; ii++)
                            for (int jj = j - 1; jj < j + 2; jj++)
                            {
                                arr[k] = original[ii, jj];
                                k++;
                            }

                    k = 0;
                }

            return res;
        }
	}
}