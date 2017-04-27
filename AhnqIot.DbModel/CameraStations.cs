#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CameraStations.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;
using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class CameraStations : BaseEntity
    {
        public CameraStations()
        {
            CameraStationOnlineStatistics = new HashSet<CameraStationOnlineStatistics>();
            CameraStationPresetPoint = new HashSet<CameraStationPresetPoint>();
            CameraStationRunLog = new HashSet<CameraStationRunLog>();
        }

        public int Channel { get; set; }
        public int DataPort { get; set; }
        public int HttpPort { get; set; }
        public string Introduce { get; set; }
        public string IP { get; set; }
        public string Latitude { get; set; }
        public string Location { get; set; }
        public string Lotitude { get; set; }
        public string Name { get; set; }
        public int RtspPort { get; set; }
        public DateTime SetupTime { get; set; }
        public string StreamMedia { get; set; }
        public string SysDepartmentSerialnum { get; set; }
        public string UserID { get; set; }
        public string UserPwd { get; set; }
        public virtual ICollection<CameraStationOnlineStatistics> CameraStationOnlineStatistics { get; set; }
        public virtual ICollection<CameraStationPresetPoint> CameraStationPresetPoint { get; set; }
        public virtual ICollection<CameraStationRunLog> CameraStationRunLog { get; set; }
        public virtual SysDepartment SysDepartmentSerialnumNavigation { get; set; }
    }
}