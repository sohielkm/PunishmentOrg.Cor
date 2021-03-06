

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Letter
{
    public abstract class GIncomingLetterBase : BaseInfoEntity<string>
    {

		[Column("ATTACHMENT")]
		public virtual string? Attachment { get; set; }

		[Column("BACKLETTERSNO")]
		public virtual string? BackLettersNo { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DESCRIPTION")]
		public virtual string? Description { get; set; }

		[Column("FOLLOWERLETTERSNO")]
		public virtual string? FollowerLettersNo { get; set; }

		[Column("LETTERDATE")]
		public virtual string? LetterDate { get; set; }

		[Column("LETTERNO")]
		public virtual string? LetterNo { get; set; }

		[Column("LETTERTEXT")]
		public virtual string? LetterText { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("RECEIVELETTERTEXT")]
		public virtual string? ReceiveLetterText { get; set; }

		[Column("SENDER")]
		public virtual string? Sender { get; set; }

		[Column("SENDERTYPE")]
		public virtual Anu.Enumerations.IncommingLetterSenderType? SenderType { get; set; }

		[Column("SENDVIAINTERNET")]
		public virtual Anu.Enumerations.YesNo? SendViaInternet { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.IncomingLetterState? State { get; set; }

		[InverseProperty("TheGIncomingLetter")]
		public virtual List<Anu.Letter.GIncomingLetterCase>? TheGIncomingLetterCaseList { get; set; }

		[InverseProperty("TheGIncomingLetter")]
		public virtual List<Anu.Letter.GIncomingLetterSubject>? TheGIncomingLetterSubjectList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Anu.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReceiverUnit { get; set; }

		[ForeignKey("REFEREDUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheReferedUser { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual Anu.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

		[ForeignKey("VIEWERUSERID")]
		public virtual Anu.BaseInfo.Security.CMSUser.CMSUser? TheViewerUser { get; set; }

		[Column("URGENCYLETTER")]
		public virtual Anu.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

		[Column("VIEWDATE")]
		public virtual string? ViewDate { get; set; }

    }
    [Table("GINCOMINGLETTER")]
    public partial class GIncomingLetter : GIncomingLetterBase { }

    }


