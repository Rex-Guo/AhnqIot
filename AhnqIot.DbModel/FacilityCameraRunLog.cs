#region Code File Comment

// SOLUTION   ： 农业气象物联网V3
// PROJECT    ： AhnqIot.DbModel
// FILENAME   ： FacilityCameraRunLog.cs
// AUTHOR     ： soft-cq
// CREATE TIME： 2016-01-11 15:27
// COPYRIGHT  ： 版权所有 (C) 物联网科技有限公司 http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace
using ProtoBuf;
#endregion

namespace AhnqIot.DbModel
{
    [ProtoContract]
    public partial class FacilityCameraRunLog : BaseEntity
    {
        [ProtoMember(1)]
        public string Description { get; set; }
        [ProtoMember(2)]
        public string FacilityCameraSerialnum { get; set; }
        [ProtoMember(3)]
        public bool Status { get; set; }
        [ProtoMember(4)]
        public virtual FacilityCamera FacilityCameraSerialnumNavigation { get; set; }
    }
}