﻿

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rad.Letter
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

		[Column("LETTERDATA")]
		public virtual byte[]? LetterData { get; set; }

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

		[Column("SENDERRELATEDID")]
		public virtual string? SenderRelatedID { get; set; }

		[Column("SENDERTYPE")]
		public virtual Rad.CMS.Enumerations.IncommingLetterSenderType? SenderType { get; set; }

		[Column("SENDVIAINTERNET")]
		public virtual Rad.CMS.Enumerations.YesNo? SendViaInternet { get; set; }

		[Column("STATE")]
		public virtual Rad.CMS.Enumerations.IncomingLetterState? State { get; set; }

		[InverseProperty("TheGIncomingLetter")]
		public virtual List<Rad.Letter.GIncomingLetterCase>? TheGIncomingLetterCaseList { get; set; }

		[InverseProperty("TheGIncomingLetter")]
		public virtual List<Rad.Letter.GIncomingLetterFields>? TheGIncomingLetterFieldsList { get; set; }

		[ForeignKey("GINCOMINGLETTERID")]
		public virtual List<Rad.Letter.GIncomingLetterSubject>? TheGIncomingLetterSubjectList { get; set; }

		[ForeignKey("OBJECTSTATEID")]
		public virtual Rad.BaseInfo.SystemObject.ObjectState? TheObjectState { get; set; }

		[ForeignKey("RECEIVERUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheReceiverUnit { get; set; }

		[ForeignKey("REFEREDUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheReferedUser { get; set; }

		[ForeignKey("REFERUNITID")]
		public virtual Rad.BaseInfo.OrganizationChart.Unit? TheReferUnit { get; set; }

		[ForeignKey("REGISTRARUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheRegistrarUser { get; set; }

		[ForeignKey("VIEWERUSERID")]
		public virtual Rad.BaseInfo.Security.CMSUser.CMSUser? TheViewerUser { get; set; }

		[Column("URGENCYLETTER")]
		public virtual Rad.CMS.Enumerations.UrgencyLetter? UrgencyLetter { get; set; }

		[Column("VIEWDATE")]
		public virtual string? ViewDate { get; set; }

    }
    [Table("GINCOMINGLETTER")]
    public partial class GIncomingLetter : GIncomingLetterBase { }

    }

