

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.BaseInfo.Anu.Trm.SMS
{
    public abstract class TrmReceiveSMSNotRespondBase : BaseInfoEntity<string>
    {

		[ForeignKey("TRMRECEIVESMSID")]
		public virtual Anu.Trm.SMS.TrmReceiveSMS? TheTrmReceiveSMS { get; set; }

    }
    [Table("TRMRECEIVESMSNOTRESPOND")]
    public partial class TrmReceiveSMSNotRespond : TrmReceiveSMSNotRespondBase { }

    }


