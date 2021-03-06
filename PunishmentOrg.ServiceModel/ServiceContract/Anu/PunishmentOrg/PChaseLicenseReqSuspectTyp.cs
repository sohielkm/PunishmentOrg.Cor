
using System.Collections.Generic;
namespace Anu.PunishmentOrg.ServiceContract
{
    [System.ComponentModel.DisplayName("نوع مجوز شخص مورد تعقيب درخواست مجوز تعقيب/بازرسي")]
    public class PChaseLicenseReqSuspectTyp
    {
        public PChaseLicenseReqSuspectTyp()
        {
        }
            
            [System.ComponentModel.DisplayName("نتيجه درخواست")]
            public DataModel.Anu.Enumerations.PunishmentOrg.PUConclusion ConclusionRequest { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("نوع مجوز در مورد شخص")]
            public DataModel.Anu.Enumerations.PunishmentOrg.LicensePersonType LicensePersonType { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("شماره ترتيب")]
            public long? RowNumber { get; set ;} 
            
            
            [System.ComponentModel.DataAnnotations.Required]
            [System.ComponentModel.DisplayName("اشخاص مورد تعقيب درخواست مجوز تعقيب/بازرسي در سرويس")]
            public Anu.PunishmentOrg.ServiceContract.PChaseLicenseReqSuspect ThePChaseLicenseReqSuspect { get; set ;} 
            

    }
    }
