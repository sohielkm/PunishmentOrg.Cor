

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Destroyed
{
    public abstract class PBoxFileBase : PunishmentOrgEntity<string>
    {

		[Column("BOXFILENO")]
		public virtual string? BoxFileNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("ENDYEAR")]
		public virtual string? EndYear { get; set; }

		[Column("STEPNO")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.DestroyedCaseStep? StepNo { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[InverseProperty("ThePBoxFile")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedCase>? ThePDestroyedCaseList { get; set; }

		[InverseProperty("ThePBoxFile")]
		public virtual List<Anu.PunishmentOrg.Destroyed.PDestroyedMinuteBoxFiles>? ThePDestroyedMinuteBoxFilesList { get; set; }

		[ForeignKey("REGISTRARID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemConfiguration.RegisterUserHistory? TheRegistrar { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

    }
    [Table("PBOXFILE")]
    public partial class PBoxFile : PBoxFileBase { }

    }


