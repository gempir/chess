namespace ChessCS
{
	struct Move
	{
		public string From;
		public string To;

		public Move(string from, string to)
		{
			From = from;
			To = to;
		}
	}
}