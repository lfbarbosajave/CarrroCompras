using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PicaCarrito.Models
{
    public class Producto
    {

        
        public string id { get; set; }
        public string tipo { get; set; }
        public int cantidad { get; set; }
    }
}
