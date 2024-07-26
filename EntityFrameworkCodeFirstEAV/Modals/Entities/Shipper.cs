using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEAV.Modals.Entities
{
	public class Shipper:BaseEntity
	{
		public string CompanyName { get; set; }

		//Relatioanl Properties

		public virtual List<Order> Orders { get; set; }
	}
}
