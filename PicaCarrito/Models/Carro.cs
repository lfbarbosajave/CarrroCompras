using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PicaCarrito.Models
{
    public class Carro
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string idSesion { get; set; }

        public string idUsuario { get; set; }                    

        public List<Dictionary<string, object>> productos { get; set; }

        public bool activo { get; set; }
    }
}
