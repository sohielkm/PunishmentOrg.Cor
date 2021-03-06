

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.BaseInfo.Types
{
    public abstract class OutputLetterTypeBase : BaseInfoEntity<string>
    {

		[Column("CODE")]
		public virtual string? Code { get; set; }

		[Column("STATE")]
		public virtual Anu.Enumerations.State? State { get; set; }

		[InverseProperty("TheOutputLetterType")]
		public virtual List<Anu.BaseInfo.Types.OutputLetterTypeTranscript>? TheOutputLetterTypeTranscriptList { get; set; }

		[Column("TITLE")]
		public virtual string? Title { get; set; }

		[Column("UNITTYPEACCESS")]
		public virtual string? UnitTypeAccess { get; set; }

    }
    [Table("OUTPUTLETTERTYPE")]
    public partial class OutputLetterType : OutputLetterTypeBase { }

    }


