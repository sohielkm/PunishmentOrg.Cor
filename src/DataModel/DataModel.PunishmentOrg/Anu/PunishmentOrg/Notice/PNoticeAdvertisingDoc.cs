﻿

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Notice
{
    public abstract class PNoticeAdvertisingDocBase : PunishmentOrgEntity<string>
    {

		[Column("RELATEDDOCNO")]
		public virtual string? RelatedDocNo { get; set; }

		[Column("RELATEDOBJECTID")]
		public virtual string? RelatedObjectId { get; set; }

		[ForeignKey("PNOTICEADVERTISINGID")]
		public virtual Anu.PunishmentOrg.Notice.PNoticeAdvertising? ThePNoticeAdvertising { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("PNOTICEADVERTISINGDOC")]
    public partial class PNoticeAdvertisingDoc : PNoticeAdvertisingDocBase { }

    }


