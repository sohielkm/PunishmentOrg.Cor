

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBTradeUnionsBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("HEMAYATCODE")]
		public virtual string? HemayatCode { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBTRADEUNIONS")]
    public partial class PBTradeUnions : PBTradeUnionsBase { }

    }


