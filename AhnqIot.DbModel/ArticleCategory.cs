#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� ArticleCategory.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class ArticleCategory : BaseEntity
    {
        public string CreateSysUserUserName { get; set; }
        public string Name { get; set; }
        public int? Num { get; set; }
        public string ParentSerialnum { get; set; }
        public string UpdateSysUserUserName { get; set; }
    }
}