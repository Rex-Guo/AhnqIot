#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CameraStationRunLog.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class CameraStationRunLog : BaseEntity
    {
        public string CameraStationsSerialnum { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public virtual CameraStations CameraStationsSerialnumNavigation { get; set; }
    }
}