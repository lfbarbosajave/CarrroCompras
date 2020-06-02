using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PicaCarrito.Models
{
    public class PicaDatabaseSettings : IPicaDatabaseSettings
    {
        public string PicaCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IPicaDatabaseSettings
    {
        string PicaCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
