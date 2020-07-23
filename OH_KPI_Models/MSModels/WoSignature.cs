using System;
using System.Collections.Generic;

namespace OH_KPI_Models.MSModels
{
    public partial class WoSignature
    {
        public int SignatureId { get; set; }
        public string MarkName { get; set; }
        public string RoleUnitList { get; set; }
        public string Password { get; set; }
        public string MarkType { get; set; }
        public string RealMarkType { get; set; }
        public byte[] MarkBody { get; set; }
        public byte[] RealMarkBody { get; set; }
        public string MarkPath { get; set; }
        public int? MarkSize { get; set; }
        public int? RealMarkSize { get; set; }
        public DateTime? MarkDate { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Descripe { get; set; }
    }
}
