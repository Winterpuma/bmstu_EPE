namespace COCOMO.Attributes
{
	/// <summary>
	/// Атрибуты программного продукта
	/// </summary>
	public static class Product
	{
		/// <summary>
		/// Требуемая надежность
		/// </summary>
		public static double RELY(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 0.75;

				case Ratings.Low:
					return 0.86;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.15;

				case Ratings.VeryHigh:
					return 1.4;
			}
			return 0;
		}

		/// <summary>
		/// Размер БД
		/// </summary>
		public static double DATA(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.Low:
					return 0.94;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.08;

				case Ratings.VeryHigh:
					return 1.16;
			}
			return 0;
		}

		/// <summary>
		/// Сложность продукта
		/// </summary>
		public static double CPLX(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 0.7;

				case Ratings.Low:
					return 0.85;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.15;

				case Ratings.VeryHigh:
					return 1.3;
			}
			return 0;
		}
	}
}
