

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.Letter
{
    public abstract class PIncomingLetterSubjectBase : PunishmentOrgEntity<string>
    {

		[ForeignKey("PINCOMINGLETTERID")]
		public virtual Anu.PunishmentOrg.Letter.PIncomingLetter? ThePIncomingLetter { get; set; }

    }
    [Table("PINCOMINGLETTERSUBJECT")]
    public partial class PIncomingLetterSubject : PIncomingLetterSubjectBase { }

    }


