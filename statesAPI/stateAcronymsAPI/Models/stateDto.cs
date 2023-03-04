using System;
namespace stateAcronymsAPI.Models
{
	public class stateDto
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public string? stateAcryonym { get; set; }
		public double StatePopulation { get; set; }
		public StateRegion Region { get; set; }
	}

	public enum StateRegion
	{
		NewEngland,
		MiddleAtlantic,
		South,
		Midwest,
		Southwest,
		West
	}
}

