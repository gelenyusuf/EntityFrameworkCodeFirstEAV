using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEAV.Modals.Entities
{
	public class OrderDetail:BaseEntity
	{
		public int ProductID { get; set; }
		public int OrderID { get; set; }
	}
}
