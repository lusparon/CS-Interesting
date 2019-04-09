namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            int c = count % 10;
            int c1 = (count % 100) / 10;
            string res = "";
            if (c1 == 1 || c >= 5 && c <= 9 || c == 0)
                res = "рублей";
            else
            if (c == 1) res = "рубль";
            else if (c >= 2 && c <= 4) res = "рубля";
            return res;
        }
	}
}