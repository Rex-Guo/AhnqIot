#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� SysArea.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class SysArea : BaseEntity
    {
        public SysArea()
        {
            AgrProduceAnniversaryService = new HashSet<AgrProduceAnniversaryService>();
            AgrProduceCondition = new HashSet<AgrProduceCondition>();
            SysDepartment = new HashSet<SysDepartment>();
        }

        public string AwCode { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ParentSerialnum { get; set; }
        public int Status { get; set; }
        public virtual ICollection<AgrProduceAnniversaryService> AgrProduceAnniversaryService { get; set; }
        public virtual ICollection<AgrProduceCondition> AgrProduceCondition { get; set; }
        public virtual ICollection<SysDepartment> SysDepartment { get; set; }
    }
}