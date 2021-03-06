

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.ArrestSaftyWrit
{
    public abstract class PSaftyWritAcceptBase : PunishmentOrgEntity<string>
    {

		[Column("BANKBRANCHADDRESS")]
		public virtual string? BankBranchAddress { get; set; }

		[Column("BANKBRANCHCODE")]
		public virtual string? BankBranchCode { get; set; }

		[Column("BANKBRANCHNAME")]
		public virtual string? BankBranchName { get; set; }

		[Column("BILLDATE")]
		public virtual string? BillDate { get; set; }

		[Column("BILLNO")]
		public virtual string? BillNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("PLAQUEORIGINAL")]
		public virtual string? PlaqueOriginal { get; set; }

		[Column("PLEDGETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUPledgeType? PledgeType { get; set; }

		[Column("SECTION")]
		public virtual string? Section { get; set; }

		[Column("SIDEWAYPLAQUE")]
		public virtual string? SidewayPlaque { get; set; }

		[ForeignKey("BANKID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.Types.Bank? TheBank { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

		[ForeignKey("PSAFTYWRITID")]
		public virtual Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWrit? ThePSaftyWrit { get; set; }

		[InverseProperty("ThePSaftyWritAccept")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWritAcceptIssuer>? ThePSaftyWritAcceptIssuerList { get; set; }

		[InverseProperty("ThePSaftyWritAccept")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWritAcceptTransition>? ThePSaftyWritAcceptTransitionList { get; set; }

		[InverseProperty("ThePSaftyWritAccept")]
		public virtual List<Anu.PunishmentOrg.ArrestSaftyWrit.PSaftyWritAcceptUnit>? ThePSaftyWritAcceptUnitList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("WRITDATE")]
		public virtual string? WritDate { get; set; }

		[Column("WRITTEXT")]
		public virtual string? WritText { get; set; }

    }
    [Table("PSAFTYWRITACCEPT")]
    public partial class PSaftyWritAccept : PSaftyWritAcceptBase { }

    }


