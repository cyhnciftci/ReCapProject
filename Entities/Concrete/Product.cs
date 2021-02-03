using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string ColorId { get; set; }
        public string ModelYear { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal DailyPrice { get; set; }
    }
}
