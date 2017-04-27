#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� DeviceRunLogType.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace
using ProtoBuf;
using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    [ProtoContract]
    public partial class DeviceRunLogType : BaseEntity
    {
        public DeviceRunLogType()
        {
            DeviceRunLog = new HashSet<DeviceRunLog>();
        }
        [ProtoMember(1)]
        public string Introduce { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public virtual ICollection<DeviceRunLog> DeviceRunLog { get; set; }
    }
}