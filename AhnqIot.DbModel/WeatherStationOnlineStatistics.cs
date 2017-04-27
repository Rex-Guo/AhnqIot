#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� WeatherStationOnlineStatistics.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;

#endregion

namespace AhnqIot.DbModel
{
    public partial class WeatherStationOnlineStatistics : BaseEntity
    {
        public int AllCount { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int ReceiveCount { get; set; }
        public decimal ReceivePercent { get; set; }
        public DateTime SetupTime { get; set; }
        public string WeatherDeviceSerialnum { get; set; }
        public int Year { get; set; }
        public virtual WeatherDevice WeatherDeviceSerialnumNavigation { get; set; }
    }
}