#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AgrProductObject.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class AgrProductObject : BaseEntity
    {
        public AgrProductObject()
        {
            AgrProduceAnniversaryService = new HashSet<AgrProduceAnniversaryService>();
            AgrProduceCondition = new HashSet<AgrProduceCondition>();
            AgrProductObjectGrowthInfo = new HashSet<AgrProductObjectGrowthInfo>();
            FacilityProduceInfo = new HashSet<FacilityProduceInfo>();
        }

        public string Name { get; set; }
        public string CropUrl { get; set; }
        public string Introduce { get; set; }
        public string AgrProducationTypeSerialnum { get; set; }
        public virtual ICollection<AgrProduceAnniversaryService> AgrProduceAnniversaryService { get; set; }
        public virtual ICollection<AgrProduceCondition> AgrProduceCondition { get; set; }
        public virtual ICollection<AgrProductObjectGrowthInfo> AgrProductObjectGrowthInfo { get; set; }
        public virtual ICollection<FacilityProduceInfo> FacilityProduceInfo { get; set; }
    }
}