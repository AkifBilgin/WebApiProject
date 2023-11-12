using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjectEntityLayer.Concrete
{
    public class ToDoList
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool Status { get; set; }

    }
}
