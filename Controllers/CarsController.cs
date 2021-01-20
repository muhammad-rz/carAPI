using System.Collections.Generic;
using AutoMapper;
using carApi.Data;
using carApi.Dtos;
using carApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace carApi.Controllers
{
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepo _repository;
        private readonly IMapper _mapper;

        public CarsController(ICarRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        // GET api/cars
        [HttpGet]
        public ActionResult<IEnumerable<CarReadDto>> GetAllCars()
        {
            var carItems = _repository.GetAllCars();

            return Ok(_mapper.Map<IEnumerable<CarReadDto>>(carItems));
        }

        // GET api/cars/{id}
        [HttpGet("{id}", Name = "GetCarById")]
        public ActionResult<CarReadDto> GetCarById(int id)
        {
            var carItem = _repository.GetCarById(id);
            if (carItem == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<CarReadDto>(carItem));

        }

        // POST api/cars
        [HttpPost]
        public ActionResult<CarReadDto> CreateCar(CarCreateDto carCreateDto)
        {
            var carModel = _mapper.Map<Car>(carCreateDto);
            _repository.CreateCar(carModel);
            _repository.SaveChanges();

            var carReadDto = _mapper.Map<CarReadDto>(carModel);

            return CreatedAtRoute(nameof(GetCarById), new { Id = carReadDto.Id }, carReadDto);
        }

        // PUT /api/cars/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateCar(int id, CarUpdateDto carUpdateDto)
        {
            var carModelFromRepo = _repository.GetCarById(id);
            if (carModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(carUpdateDto, carModelFromRepo);
            _repository.UpdateCar(carModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }

        // DELETE /api/cars/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteCar(int id)
        {
            var carModelFromRepo = _repository.GetCarById(id);
            if (carModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteCar(carModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}