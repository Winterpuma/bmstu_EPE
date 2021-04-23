namespace COCOMO.Attributes
{
	/// <summary>
	/// Атрибуты проекта
	/// </summary>
	public static class Project
	{
		/// <summary>
		/// Использование современных методов
		/// </summary>
		public static double MODP(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.24;

				case Ratings.Low:
					return 1.1;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return .91;

				case Ratings.VeryHigh:
					return .82;
			}
			return 0;
		}

		/// <summary>
		/// Использование программных инструментов
		/// </summary>
		public static double TOOL(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.24;

				case Ratings.Low:
					return 1.1;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return .91;

				case Ratings.VeryHigh:
					return .82;
			}
			return 0;
		}

		/// <summary>
		/// Требуемые сроки разработки
		/// </summary>
		public static double SCED(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.23;

				case Ratings.Low:
					return 1.08;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.04;

				case Ratings.VeryHigh:
					return 1.1;
			}
			return 0;
		}
	}
}
