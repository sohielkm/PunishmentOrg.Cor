﻿
using Anu.PunishmentOrg.ServiceContract;
using ServiceModel.Commons.ServiceResponse;

namespace ServiceResponse.Anu.PunishmentOrg
{
    public class ReceivePChaseLicenseReqResponse :PChaseLicenseReqResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePChaseLicenseReqResponse()
          {
              Result = new Result();
          }
        }
        public class ReceivePChaseLicenseReqResultFromJudiciaryResponse :PChaseLicenseReqResponse ,IResponseMessage
        {
          public Result Result { get; set; }
          public ReceivePChaseLicenseReqResultFromJudiciaryResponse()
          {
              Result = new Result();
          }
        }
        public class SendPChaseLicenseReqResponse :PChaseLicenseReq ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPChaseLicenseReqResponse()
          {
              Result = new Result();
          }
        }
        public class SendPChaseLicenseReqResultFromJudiciaryResponse :PChaseLicenseReq ,IResponseMessage
        {
          public Result Result { get; set; }
          public SendPChaseLicenseReqResultFromJudiciaryResponse()
          {
              Result = new Result();
          }
        }

}
