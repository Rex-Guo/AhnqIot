#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CompanyUser.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class CompanyUser : BaseEntity
    {
        public string CompanySerialnum { get; set; }
        public string FacilitySerialnum { get; set; }
        public string FarmSerialnum { get; set; }
        public string SysUserSerialnum { get; set; }
        public virtual Company CompanySerialnumNavigation { get; set; }
        public virtual SysUser SysUserSerialnumNavigation { get; set; }
    }
}