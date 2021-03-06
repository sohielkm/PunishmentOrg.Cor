

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.ExchangeData
{
    public abstract class GExchangeUnitTitleBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("ISMECHANIZERELATION")]
		public virtual Anu.Enumerations.YesNo? IsMechanizeRelation { get; set; }

		[Column("ORGLOGO")]
		public virtual byte[]? OrgLogo { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheGExchangeUnitTitle")]
		public virtual List<Anu.BaseInfo.FrontEndSecurity.GFESNJUnitRelatedUserAccess>? TheGFESNJUnitRelatedUserAccessList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("WEBSERVICEFULLNAME")]
		public virtual string? WebServiceFullName { get; set; }

    }
    [Table("GEXCHANGEUNITTITLE")]
    public partial class GExchangeUnitTitle : GExchangeUnitTitleBase { }

    }


