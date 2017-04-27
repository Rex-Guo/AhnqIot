#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CameraStationOnlineStatistics.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class CameraStationOnlineStatistics : BaseEntity
    {
        public int AllCount { get; set; }
        public string CameraStationsSerialnum { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int OnlineCount { get; set; }
        public decimal OnlinePercent { get; set; }
        public int Year { get; set; }
        public virtual CameraStations CameraStationsSerialnumNavigation { get; set; }
    }
}