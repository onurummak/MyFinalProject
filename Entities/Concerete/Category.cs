using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concerete
{    // Çıplak Class Kalmasın
    public class Category:IEntity //işaretleme ularak using load etmelisin
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
