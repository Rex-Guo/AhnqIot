#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� FacilityProduceInfo.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;

#endregion

namespace AhnqIot.DbModel
{
    public partial class FacilityProduceInfo : BaseEntity
    {
        public string AgrProductObjectSerialnum { get; set; }
        public string Description { get; set; }
        public DateTime? EndTime { get; set; }
        public string FacilitySerialnum { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public bool Status { get; set; }
        public virtual AgrProductObject AgrProductObjectSerialnumNavigation { get; set; }
        public virtual Facility FacilitySerialnumNavigation { get; set; }
    }
}