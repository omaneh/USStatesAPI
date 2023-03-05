using System;
using Microsoft.AspNetCore.Mvc;
using stateAcronymsAPI.Models;
using Microsoft.AspNetCore.JsonPatch;

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

		[HttpPatch("{stateID}")]

		public ActionResult UpdateStatePopulation(string stateID, JsonPatchDocument<stateUpdateDto> patchedPopulation)
		{
			var state = StatesDataStore.Current.State.FirstOrDefault(p => p.stateAcryonym == stateID);

			if (state == null)
			{

				return NotFound();
			}

			var statePopulationToPatch = new stateUpdateDto()
			{
				StatePopulation = state.StatePopulation
			};

			patchedPopulation.ApplyTo(statePopulationToPatch, ModelState);

			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (!TryValidateModel(ModelState))
			{
				return BadRequest(ModelState);
			}

			state.StatePopulation = statePopulationToPatch.StatePopulation;

			return Ok(state);
		}



        }

    }



