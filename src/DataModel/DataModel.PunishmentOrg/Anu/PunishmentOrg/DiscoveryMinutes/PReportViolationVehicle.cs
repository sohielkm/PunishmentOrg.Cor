

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.DiscoveryMinutes
{
    public abstract class PReportViolationVehicleBase : PunishmentOrgEntity<string>
    {

		[Column("ARRESTEDVEHICLE")]
		public virtual DataModel.BaseInfo.Anu.Enumerations.YesNo? ArrestedVehicle { get; set; }

		[Column("CHASSISNUMBER")]
		public virtual string? ChassisNumber { get; set; }

		[Column("COLOR")]
		public virtual string? color { get; set; }

		[Column("DRIVERFULLNAME")]
		public virtual string? DriverFullName { get; set; }

		[Column("MODEL")]
		public virtual string? Model { get; set; }

		[Column("MOTORNUMBER")]
		public virtual string? MotorNumber { get; set; }

		[Column("OTHERINFO")]
		public virtual string? OtherInfo { get; set; }

		[Column("OWNERFULLNAME")]
		public virtual string? OwnerFullName { get; set; }

		[Column("PARKFICHENO")]
		public virtual string? ParkFicheNo { get; set; }

		[Column("PARKINGNAME")]
		public virtual string? ParkingName { get; set; }

		[Column("PLAQUENUMBER")]
		public virtual string? PlaqueNumber { get; set; }

		[Column("ROWNUMBER")]
		public virtual long? RowNumber { get; set; }

		[ForeignKey("PREPORTVIOLATIONID")]
		public virtual Anu.PunishmentOrg.DiscoveryMinutes.PReportViolation? ThePReportViolation { get; set; }

		[Column("VEHICLETYPE")]
		public virtual string? VehicleType { get; set; }

    }
    [Table("PREPORTVIOLATIONVEHICLE")]
    public partial class PReportViolationVehicle : PReportViolationVehicleBase { }

    }


