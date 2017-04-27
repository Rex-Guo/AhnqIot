#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� SysMenu.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class SysMenu : BaseEntity
    {
        public SysMenu()
        {
            SysRoleMenu = new HashSet<SysRoleMenu>();
        }

        public string Description { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public bool Necessary { get; set; }
        public string ParentSerialnum { get; set; }
        public int Status { get; set; }
        public string SysFunctionSerialnum { get; set; }
        public bool Visiable { get; set; }
        public virtual ICollection<SysRoleMenu> SysRoleMenu { get; set; }
        public virtual SysFunction SysFunctionSerialnumNavigation { get; set; }
    }
}