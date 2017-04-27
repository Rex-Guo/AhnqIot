#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AWProductType.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class AWProductType : BaseEntity
    {
        public AWProductType()
        {
            AWProduct = new HashSet<AWProduct>();
        }

        public string Description { get; set; }
        public string Name { get; set; }
        public string ParentSerialnum { get; set; }
        public virtual ICollection<AWProduct> AWProduct { get; set; }
    }
}