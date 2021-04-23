namespace COCOMO.Attributes
{
	/// <summary>
	/// Атрибуты персонала
	/// </summary>
	public static class Personnel
	{
		/// <summary>
		/// Способности аналитика
		/// </summary>
		public static double ACAP(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.46;

				case Ratings.Low:
					return 1.19;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 0.86;

				case Ratings.VeryHigh:
					return 0.71;
			}
			return 0;
		}

		/// <summary>
		/// Знание приложений
		/// </summary>
		public static double AEXP(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.29;

				case Ratings.Low:
					return 1.15;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 0.91;

				case Ratings.VeryHigh:
					return 0.82;
			}
			return 0;
		}

		/// <summary>
		/// Способности программиста
		/// </summary>
		public static double PCAP(int level)
		{
			switch ((Ratings)level)
			{

				case Ratings.VeryLow:
					return 1.42;

				case Ratings.Low:
					return 1.17;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 0.86;

				case Ratings.VeryHigh:
					return .7;
			}
			return 0;
		}

		/// <summary>
		/// Знание виртуальной машины
		/// </summary>
		public static double VEXP(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.21;

				case Ratings.Low:
					return 1.1;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return .9;
			}
			return 0;
		}

		/// <summary>
		/// Знание языка программирования
		/// </summary>
		public static double LEXP(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.VeryLow:
					return 1.14;

				case Ratings.Low:
					return 1.07;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return .95;
			}
			return 0;
		}
	}
}
