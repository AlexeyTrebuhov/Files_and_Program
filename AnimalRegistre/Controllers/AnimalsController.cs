using AnimalsRegistre.Models;
using AnimalsRegistre.Models.Request;
using AnimalsRegistre.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalRegistre.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
        {
        private IAnimalsRepository _animalRepository;

        public AnimalsController(IAnimalsRepository animalRepository) 
        {
            _animalRepository = animalRepository;
        }

        [HttpPost("Create")]
        public ActionResult<int> Create([FromBody] CreateAnimalsRequest createRequest)

        {
            int res = _animalRepository.Create(new Animals
            {
                ClasslName = createRequest.ClasslName,
                AnimalName = createRequest.AnimalName,
                DateOfBirth = createRequest.DateOfBirth,
                ExecutableCommands = createRequest.ExecutableCommands,
                AdditionalCommands = createRequest.AdditionalCommands,
                AdditionalCommandsToo = createRequest.AdditionalCommandsToo,
            });
            return Ok(res);
        }

        [HttpPut("Update")]
        public ActionResult<int> Update([FromBody] UpdateAnimalsRequest updateRequest)

        {
            int res = _animalRepository.Update(new Animals
            {
                ClasslName = updateRequest.ClasslName,
                AnimalName = updateRequest.AnimalName,
                DateOfBirth = updateRequest.DateOfBirth,
                ExecutableCommands = updateRequest.ExecutableCommands,
                AdditionalCommands = updateRequest.AdditionalCommands,
                AdditionalCommandsToo = updateRequest.AdditionalCommandsToo,
            });
            return Ok(res);
        }


        [HttpDelete("delete")]
        public ActionResult<int> Delete(int animalId) 
        {
            int res = _animalRepository.Delete(animalId);
            return Ok(res);
        }

        [HttpGet("GetAll")]
        public ActionResult<List<Animals>> GetAll()
        { 
         return Ok(_animalRepository.GetAll());
        }

        [HttpGet("GetById")]
        public ActionResult<List<Animals>> GetById(int animalId)
        {
            return Ok(_animalRepository.GetById(animalId));
        }


    }
}
