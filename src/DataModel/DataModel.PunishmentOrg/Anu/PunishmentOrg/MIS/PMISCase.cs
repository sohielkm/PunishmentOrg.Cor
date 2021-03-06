

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataModel.PunishemntOrg.Anu.PunishmentOrg.MIS
{
    public abstract class PMISCaseBase : PunishmentOrgEntity<string>
    {

		[Column("ABSOLUTIONISSUED")]
		public virtual long? AbsolutionIssued { get; set; }

		[Column("ALLABSOLUTED")]
		public virtual long? AllAbsoluted { get; set; }

		[Column("ASSISTANCECOUNT")]
		public virtual long? AssistanceCount { get; set; }

		[Column("CASEARCHIVESTATE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUCaseArchiveState? CaseArchiveState { get; set; }

		[Column("CASESTORENO")]
		public virtual string? CaseStoreNo { get; set; }

		[Column("CASETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUCaseType? CaseType { get; set; }

		[Column("CONVICTIONISSUED")]
		public virtual long? ConvictionIssued { get; set; }

		[Column("CONVICTIONPRICEFORGOVERMENT")]
		public virtual long? ConvictionPriceForGoverment { get; set; }

		[Column("CONVICTIONPRICEFORPLAINTIFF")]
		public virtual long? ConvictionPriceForPlaintiff { get; set; }

		[Column("COOPERATIONOFFENDINGCOUNT")]
		public virtual long? CooperationOffendingCount { get; set; }

		[Column("COPYCOUNT")]
		public virtual long? CopyCount { get; set; }

		[Column("CORRECTIVEJUDGECOUNT")]
		public virtual long? CorrectiveJudgeCount { get; set; }

		[Column("CREATECASETYPE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUCreateCaseType? CreateCaseType { get; set; }

		[Column("CREATEDATETIME")]
		public virtual string? CreateDateTime { get; set; }

		[Column("DAYSHASNOTTRIPLE")]
		public virtual long? DaysHasNotTriple { get; set; }

		[Column("DAYSNOTSENTTOEXECUTER")]
		public virtual long? DaysNotSentToExecuter { get; set; }

		[Column("DAYSOPENINCOURT")]
		public virtual long? DaysOpenInCourt { get; set; }

		[Column("DAYSOPENINEXECUTER")]
		public virtual long? DaysOpenInExecuter { get; set; }

		[Column("DIVANJUDGECOUNT")]
		public virtual long? DivanJudgeCount { get; set; }

		[Column("ENDDATETIME")]
		public virtual string? EndDateTime { get; set; }

		[Column("EXECUTIONTIME")]
		public virtual long? ExecutionTime { get; set; }

		[Column("FEMALEOFFENDINGCOUNT")]
		public virtual long? FemaleOffendingCount { get; set; }

		[Column("FINESISSUED")]
		public virtual long? FinesIssued { get; set; }

		[Column("FOREIGNOFFENDINGCOUNT")]
		public virtual long? ForeignOffendingCount { get; set; }

		[Column("GOVERNMENTALOFFENDINGCOUNT")]
		public virtual long? GovernmentalOffendingCount { get; set; }

		[Column("GUILD")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUGuild? Guild { get; set; }

		[Column("HANDLETIME")]
		public virtual long? HandleTime { get; set; }

		[Column("HASCARDSTEWARDSHIPCOUNT")]
		public virtual long? HasCardStewardshipCount { get; set; }

		[Column("HASTIMENOT")]
		public virtual long? HasTimeNot { get; set; }

		[Column("IMPORTANCEDEGREE")]
		public virtual DataModel.Anu.Enumerations.PunishmentOrg.PUImportanceDegree? ImportanceDegree { get; set; }

		[Column("INPUTCOUNT")]
		public virtual long? InputCount { get; set; }

		[Column("INSTALLMENTSCOUNT")]
		public virtual long? InstallmentsCount { get; set; }

		[Column("INTERIMLICENSEOFFENDINGCOUNT")]
		public virtual long? InterimLicenseOffendingCount { get; set; }

		[Column("INVALIDITYISSUED")]
		public virtual long? InvalidityIssued { get; set; }

		[Column("ISGUILDCASE")]
		public virtual long? IsGuildCase { get; set; }

		[Column("ISHEALTHMEDICINECASE")]
		public virtual long? IsHealthMedicineCase { get; set; }

		[Column("ISRELATEDTOCURRENCY")]
		public virtual long? IsRelatedToCurrency { get; set; }

		[Column("ISRELATEDTOPRODUCT")]
		public virtual long? IsRelatedToProduct { get; set; }

		[Column("ISRELATEDTOSERVICESTYPE")]
		public virtual long? IsRelatedToServicesType { get; set; }

		[Column("ISSMUGGLINGCASE")]
		public virtual long? IsSmugglingCase { get; set; }

		[Column("LEASEDESTATECOUNT")]
		public virtual long? LeasedEstateCount { get; set; }

		[Column("LEGALOFFENDINGCOUNT")]
		public virtual long? LegalOffendingCount { get; set; }

		[Column("MAINJUDGECOUNT")]
		public virtual long? MainJudgeCount { get; set; }

		[Column("MAINJUDGEHASCORRECTIVECOUNT")]
		public virtual long? MainJudgeHasCorrectiveCount { get; set; }

		[Column("MALEOFFENDINGCOUNT")]
		public virtual long? MaleOffendingCount { get; set; }

		[Column("NO")]
		public virtual string? No { get; set; }

		[Column("NONGOVERNMENTALOFFENDINGCOUNT")]
		public virtual long? NonGovernmentalOffendingCount { get; set; }

		[Column("NOTPAIDINSTALLMENTSCOUNT")]
		public virtual long? NotPaidInstallmentsCount { get; set; }

		[Column("NOTPAIDINSTALLMENTSPRICE")]
		public virtual long? NotPaidInstallmentsPrice { get; set; }

		[Column("OFFENDINGCOUNT")]
		public virtual long? OffendingCount { get; set; }

		[Column("OTHERJUDGESUBJECTSISSUED")]
		public virtual long? OtherJudgeSubjectsIssued { get; set; }

		[Column("PAIDPRICE")]
		public virtual long? PaidPrice { get; set; }

		[Column("PARDONPRICE")]
		public virtual long? PardonPrice { get; set; }

		[Column("PARDONWRITISSUED")]
		public virtual long? PardonWritIssued { get; set; }

		[Column("PARTNERSHIPCOUNT")]
		public virtual long? PartnershipCount { get; set; }

		[Column("PERMANENTLICENSEOFFENDINGCOUNT")]
		public virtual long? PermanentLicenseOffendingCount { get; set; }

		[Column("PERSONALESTATECOUNT")]
		public virtual long? PersonalEstateCount { get; set; }

		[Column("PERSONCOUNT")]
		public virtual long? PersonCount { get; set; }

		[Column("PLAINTIFFCOUNT")]
		public virtual long? PlaintiffCount { get; set; }

		[Column("PRISONPRICE")]
		public virtual long? PrisonPrice { get; set; }

		[Column("PRISONWRITISSUED")]
		public virtual long? PrisonWritIssued { get; set; }

		[Column("PRIVATEORGOFFENDINGCOUNT")]
		public virtual long? PrivateOrgOffendingCount { get; set; }

		[Column("PRIVATESPECIALOFFENDINGCOUNT")]
		public virtual long? PrivateSpecialOffendingCount { get; set; }

		[Column("PUBLICAFFAIRSPRICE")]
		public virtual long? PublicAffairsPrice { get; set; }

		[Column("PUBLICAFFAIRSWRITISSUED")]
		public virtual long? PublicAffairsWritIssued { get; set; }

		[Column("REALOFFENDINGCOUNT")]
		public virtual long? RealOffendingCount { get; set; }

		[Column("REDUCEPRICE")]
		public virtual long? ReducePrice { get; set; }

		[Column("REDUCEWRITISSUED")]
		public virtual long? ReduceWritIssued { get; set; }

		[Column("REFERESHDATETIME")]
		public virtual string? RefereshDateTime { get; set; }

		[Column("SOURCEOBJECTID")]
		public virtual string? SourceObjectId { get; set; }

		[Column("STARTDATETIME")]
		public virtual string? StartDateTime { get; set; }

		[Column("STEWARDSHIPCOUNT")]
		public virtual long? StewardshipCount { get; set; }

		[Column("STOPCHASEPRICE")]
		public virtual long? StopChasePrice { get; set; }

		[Column("STOPCHASEWRITISSUED")]
		public virtual long? StopChaseWritIssued { get; set; }

		[Column("SUBNO")]
		public virtual long? SubNo { get; set; }

		[Column("TAJDIDJUDGECOUNT")]
		public virtual long? TajdidJudgeCount { get; set; }

		[Column("TERMINATEORDERISSUED")]
		public virtual long? TerminateOrderIssued { get; set; }

		[ForeignKey("GEOLOCATIONID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.GeoInfo.GeoLocation? TheGeoLocation { get; set; }

		[ForeignKey("GUNITTYPEID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.GUnitType? TheGUnitType { get; set; }

		[ForeignKey("NAJAUNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.ExchangeData.NAJAUnit? TheNAJAUnit { get; set; }

		[ForeignKey("PBCASESTOREID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBCaseStore? ThePBCaseStore { get; set; }

		[ForeignKey("PBREGULATORYPLANID")]
		public virtual Anu.BaseInfo.PunishmentOrg.PBRegulatoryPlan? ThePBRegulatoryPlan { get; set; }

		[ForeignKey("PCASEID")]
		public virtual DataModel.PunishemntOrg.Anu.PunishmentOrg.Case.PCase? ThePCase { get; set; }

		[ForeignKey("PMISCASECITYID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISCaseCity { get; set; }

		[ForeignKey("PMISCASECOMPLEXID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISCaseComplex { get; set; }

		[InverseProperty("ThePMISCase")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseInput>? ThePMISCaseInputList { get; set; }

		[ForeignKey("PMISCASEOSTANID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISCaseOstan { get; set; }

		[InverseProperty("ThePMISCase")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCasePerson>? ThePMISCasePersonList { get; set; }

		[ForeignKey("PMISCASESPECIALID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? ThePMISCaseSpecial { get; set; }

		[InverseProperty("ThePMISCase")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseTriple>? ThePMISCaseTripleList { get; set; }

		[InverseProperty("ThePMISCase")]
		public virtual List<Anu.PunishmentOrg.MIS.PMISCaseViolation>? ThePMISCaseViolationList { get; set; }

		[ForeignKey("UNITID")]
		public virtual DataModel.BaseInfo.Anu.BaseInfo.OrganizationChart.Unit? TheUnit { get; set; }

		[Column("TOTALVIOLATIONPRICE")]
		public virtual long? TotalViolationPrice { get; set; }

		[Column("TOTALVIOLATIONPRICEBYCOURT")]
		public virtual long? TotalViolationPriceByCourt { get; set; }

		[Column("TOTALVIOLATIONPRICEBYEXPERT")]
		public virtual long? TotalViolationPriceByExpert { get; set; }

		[Column("TRIPLECOUNT")]
		public virtual long? TripleCount { get; set; }

		[Column("VIOLATIONCOUNT")]
		public virtual long? ViolationCount { get; set; }

		[Column("WRITISSUED")]
		public virtual long? WritIssued { get; set; }

    }
    [Table("PMISCASE")]
    public partial class PMISCase : PMISCaseBase { }

    }


