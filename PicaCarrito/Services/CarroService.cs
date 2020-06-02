using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using PicaCarrito.Models;

namespace PicaCarrito.Services
{
    public class CarroService
    {
        private readonly IMongoCollection<Carro> _carros;

        public CarroService(IPicaDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _carros = database.GetCollection<Carro>(settings.PicaCollectionName);
        }

        public List<Carro> Get() =>
            _carros.Find(carro => true).ToList();

        public Carro Get(string id) =>
            _carros.Find<Carro>(carro => carro.Id == id).FirstOrDefault();

        public Carro Create(Carro carro)
        {
            _carros.InsertOne(carro);
            return carro;
        }

        public void Update(string id, Carro carroIn) =>
            _carros.ReplaceOne(carro => carro.Id == id, carroIn);

        public void Remove(Carro carroIn) =>
            _carros.DeleteOne(carro => carro.Id == carroIn.Id);

        public void Remove(string id) =>
            _carros.DeleteOne(carro => carro.Id == id);
    }
}
