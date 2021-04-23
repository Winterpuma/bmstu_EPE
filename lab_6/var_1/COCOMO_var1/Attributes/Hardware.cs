namespace COCOMO.Attributes
{
	/// <summary>
	/// Атрибуты компьютера
	/// </summary>
	public static class Hardware
	{
		/// <summary>
		/// Ограничение времени выполнения
		/// </summary>
		public static double TIME(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.11;

				case Ratings.VeryHigh:
					return 1.5;
			}
			return 0;
		}

		/// <summary>
		/// Ограничение объема основной памяти
		/// </summary>
		public static double STOR(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.06;

				case Ratings.VeryHigh:
					return 1.21;
			}
			return 0;
		}

		/// <summary>
		/// Изменчивость виртуальной машины
		/// </summary>
		public static double VIRT(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.Low:
					return 0.87;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.15;

				case Ratings.VeryHigh:
					return 1.3;
			}
			return 0;
		}

		/// <summary>
		/// Время реакции компьютера
		/// </summary>
		public static double TURN(int level)
		{
			switch ((Ratings)level)
			{
				case Ratings.Low:
					return 0.87;

				case Ratings.Nominal:
					return 1;

				case Ratings.High:
					return 1.07;

				case Ratings.VeryHigh:
					return 1.15;
			}
			return 0;
		}
	}
}
