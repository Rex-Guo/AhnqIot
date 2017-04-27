#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� WeatherDeviceType.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class WeatherDeviceType : BaseEntity
    {
        public WeatherDeviceType()
        {
            WeatherDevice = new HashSet<WeatherDevice>();
        }

        public string Calc { get; set; }
        public string Introduce { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public string ParentSerialnum { get; set; }
        public string Unit { get; set; }
        public virtual ICollection<WeatherDevice> WeatherDevice { get; set; }
    }
}