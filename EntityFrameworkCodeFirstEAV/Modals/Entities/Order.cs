using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEAV.Modals.Entities
{
	public class Order:BaseEntity
	{
		public string ShippingAddress { get; set; }

		public int? AppUserID { get; set; }

		public int? ShipperID { get; set; }

		//Relatioanl Properties

		public virtual AppUser AppUser { get; set; }
		public virtual List<OrderDetail> OrderDetails { get; set; }
		public virtual  Shipper Shipper { get; set; }
	}
}
