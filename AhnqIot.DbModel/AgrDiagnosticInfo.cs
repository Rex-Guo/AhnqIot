#region Code File Comment

// SOLUTION   ： 农业气象物联网V3
// PROJECT    ： AhnqIot.DbModel
// FILENAME   ： AgrDiagnosticInfo.cs
// AUTHOR     ： soft-cq
// CREATE TIME： 2016-01-11 15:27
// COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2015

#endregion

namespace AhnqIot.DbModel
{
    public partial class AgrDiagnosticInfo : BaseEntity
    {
        public string AgrDiagnosticModelSerialnum { get; set; }
        public string Info { get; set; }
        public virtual AgrDiagnosticModel AgrDiagnosticModelSerialnumNavigation { get; set; }
    }
}