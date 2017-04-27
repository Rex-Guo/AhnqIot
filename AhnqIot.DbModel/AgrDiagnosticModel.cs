#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AgrDiagnosticModel.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class AgrDiagnosticModel : BaseEntity
    {
        public AgrDiagnosticModel()
        {
            AgrDiagnosticInfo = new HashSet<AgrDiagnosticInfo>();
        }

        public string Advise { get; set; }
        public string AgrProductObjectGrowthInfoSerialnum { get; set; }
        public string DeviceTypeSerialnum { get; set; }
        public string DisplayColor { get; set; }
        public string Effect { get; set; }
        public bool IsNotice { get; set; }
        public decimal MaxValue { get; set; }
        public decimal MinValue { get; set; }
        public string Name { get; set; }
        public string TipInfo { get; set; }
        public virtual ICollection<AgrDiagnosticInfo> AgrDiagnosticInfo { get; set; }
        public virtual AgrProductObjectGrowthInfo AgrProductObjectGrowthInfoSerialnumNavigation { get; set; }
        public virtual DeviceType DeviceTypeSerialnumNavigation { get; set; }
    }
}