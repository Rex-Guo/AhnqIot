#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� SysRoleMenu.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class SysRoleMenu : BaseEntity
    {
        public string Name { get; set; }
        public int Status { get; set; }
        public string SysMenuSerialnum { get; set; }
        public string SysRoleSerialnum { get; set; }
        public virtual SysMenu SysMenuSerialnumNavigation { get; set; }
        public virtual SysRole SysRoleSerialnumNavigation { get; set; }
    }
}