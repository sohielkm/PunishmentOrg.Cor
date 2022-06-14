﻿

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Attachment
{
    public abstract class GTransactionAsyncBase : BaseInfoEntity<string>
    {

		[Column("ASYNCTYPE")]
		public virtual Rad.CMS.Enumerations.AsyncType? AsyncType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DBTRANSACTIONID")]
		public virtual string? DBTransactionId { get; set; }

		[Column("ECMTRANSACTIONID")]
		public virtual string? ECMTransactionId { get; set; }

		[ForeignKey("CASESERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.CaseServer? TheCaseServer { get; set; }

		[ForeignKey("CMSUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheCMSUser { get; set; }

		[ForeignKey("ECMSERVERID")]
		public virtual Rad.BaseInfo.SystemConfiguration.ECMServer? TheECMServer { get; set; }

		[ForeignKey("SYSTEMFORMID")]
		public virtual Rad.BaseInfo.SystemObject.SystemForm? TheSystemForm { get; set; }

		[ForeignKey("SYSTEMOBJECTID")]
		public virtual Rad.BaseInfo.SystemObject.SystemObject? TheSystemObject { get; set; }

    }
    [Table("GTRANSACTIONASYNC")]
    public partial class GTransactionAsync : GTransactionAsyncBase { }

    }

