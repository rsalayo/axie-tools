namespace Axie.Tools.Models
{
	public class Round
	{
		public int Id { get; set; }

		public int Used { get; set; }

		public int Gained { get; set; }

		public int Destroyed { get; set; }

		public int Remaining { get; set; }

		public int Energy => this.Remaining + this.Gained - this.Used - this.Destroyed + 2;
	}
}