using Api.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly MySqlConfiguration _connectionString;

        public CarRepository(MySqlConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection DbConection()
        {
            return new MySqlConnection(_connectionString.ConnectionString);
        }

        public Task<bool> DeleteCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertCar(Car car)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCar(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
