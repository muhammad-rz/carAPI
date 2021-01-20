using System;
using System.Collections.Generic;
using System.Linq;
using carApi.Models;

namespace carApi.Data
{
    public class CarRepo : ICarRepo
    {
        private readonly CarContext _context;

        public CarRepo(CarContext context)
        {
            _context = context;
        }

        public void CreateCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            _context.Cars.Add(car);
        }

        public void DeleteCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException(nameof(car));
            }

            _context.Cars.Remove(car);
        }

        public IEnumerable<Car> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public Car GetCarById(int id)
        {
            return _context.Cars.FirstOrDefault(c => c.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateCar(Car car)
        {
            //Nothing
        }
    }
}