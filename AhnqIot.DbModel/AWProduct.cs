#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AWProduct.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class AWProduct : BaseEntity
    {
        public string AWProductTypeSerialnum { get; set; }
        public string Description { get; set; }
        public int Hits { get; set; }
        public string Href { get; set; }
        public string PhotoUrl { get; set; }
        public string SysDepartmentSerialnum { get; set; }
        public string Title { get; set; }
        public virtual AWProductType AWProductTypeSerialnumNavigation { get; set; }
        public virtual SysDepartment SysDepartmentSerialnumNavigation { get; set; }
    }
}