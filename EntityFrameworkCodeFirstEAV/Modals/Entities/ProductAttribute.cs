using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirstEAV.Modals.Entities
{
	public class ProductAttribute:BaseEntity
	{
		public int ProductID { get; set; }
		public int AttributeID { get; set; }

		//Relational Properties

		public virtual Product Product { get; set; }
		public virtual  EntityAttribute Attribute { get; set; }

	}
}
