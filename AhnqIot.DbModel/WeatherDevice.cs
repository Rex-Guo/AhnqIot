#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� WeatherDevice.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class WeatherDevice : BaseEntity
    {
        public WeatherDevice()
        {
            WeatherStationOnlineStatistics = new HashSet<WeatherStationOnlineStatistics>();
        }

        public string Name { get; set; }
        public decimal Value { get; set; }
        public string WeatherDeviceTypeSerialnum { get; set; }
        public string WeatherStationSerialnum { get; set; }
        public virtual ICollection<WeatherStationOnlineStatistics> WeatherStationOnlineStatistics { get; set; }
        public virtual WeatherDeviceType WeatherDeviceTypeSerialnumNavigation { get; set; }
        public virtual WeatherStation WeatherStationSerialnumNavigation { get; set; }
    }
}