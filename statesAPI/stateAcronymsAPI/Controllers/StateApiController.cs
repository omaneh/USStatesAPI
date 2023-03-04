using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using stateAcronymsAPI.Models;
using System.Linq;
using stateAcronymsAPI;

namespace stateAcronymsAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]

	public class StateApiController : ControllerBase
	{
		[HttpGet]

		public ActionResult<IEnumerable<stateDto>> GetState()
		{
			return Ok(StatesDataStore.Current.State);
		}

		[HttpGet("{stateShorthand}")]
		public ActionResult<stateDto> GetState(string stateShorthand)
		{
			var stateReturned = StatesDataStore.Current.State.FirstOrDefault(p => p.stateAcryonym == stateShorthand);

			if (stateReturned == null)
			{
				return NotFound();
			}

			return Ok(stateReturned);
		}

	}
}

