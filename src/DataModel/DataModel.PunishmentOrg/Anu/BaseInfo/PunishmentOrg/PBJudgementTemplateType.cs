

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.BaseInfo.PunishmentOrg
{
    public abstract class PBJudgementTemplateTypeBase : PunishmentOrgEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("FORMTYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUFormTemplateType? FormType { get; set; }

		[Column("STATE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.State? State { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

    }
    [Table("PBJUDGEMENTTEMPLATETYPE")]
    public partial class PBJudgementTemplateType : PBJudgementTemplateTypeBase { }

    }


