#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� DeviceExceptionSet.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace
using ProtoBuf;
#endregion

namespace AhnqIot.DbModel
{
    [ProtoContract]
    public partial class DeviceExceptionSet : BaseEntity
    {
        [ProtoMember(1)]
        public string DeviceSerialnum { get; set; }
        [ProtoMember(2)]
        public decimal Max { get; set; }
        [ProtoMember(3)]
        public decimal Min { get; set; }
        [ProtoMember(4)]
        public bool Status { get; set; }
        [ProtoMember(5)]
        public virtual Device DeviceSerialnumNavigation { get; set; }
    }
}