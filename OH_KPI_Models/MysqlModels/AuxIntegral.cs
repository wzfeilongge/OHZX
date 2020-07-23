using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MysqlModels
{
    public partial class AuxIntegral
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string OrderCode { get; set; }
        public string ProvideUserId { get; set; }
        public long Integral { get; set; }
        public int Type { get; set; }
        public int WithdrawalsState { get; set; }
        public string WithdrawalsData { get; set; }
        public string WithdrawalsBack { get; set; }
        public DateTime CreateTime { get; set; }
        public string RealName { get; set; }
        public string OrganizeId { get; set; }
        public string OrganizeName { get; set; }
    }
}
