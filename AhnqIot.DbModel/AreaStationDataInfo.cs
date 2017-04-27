#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AreaStationDataInfo.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;

#endregion

namespace AhnqIot.DbModel
{
    public partial class AreaStationDataInfo : BaseEntity
    {
        public string AreaStationSerialnum { get; set; }
        public decimal Atmosphere { get; set; }
        public decimal Humidity { get; set; }
        public decimal Rainfall { get; set; }
        public decimal Temprature { get; set; }
        public int WindDirection { get; set; }
        public decimal WindSpeed { get; set; }
        public virtual AreaStation AreaStationSerialnumNavigation { get; set; }
    }
}