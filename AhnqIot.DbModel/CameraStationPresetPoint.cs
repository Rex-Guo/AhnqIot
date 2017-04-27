#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CameraStationPresetPoint.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class CameraStationPresetPoint : BaseEntity
    {
        public CameraStationPresetPoint()
        {
            CameraStationPics = new HashSet<CameraStationPics>();
        }

        public string Name { get; set; }
        public string CameraStationsSerialnum { get; set; }
        public int PresetPoint { get; set; }
        public virtual ICollection<CameraStationPics> CameraStationPics { get; set; }
        public virtual CameraStations CameraStationsSerialnumNavigation { get; set; }
    }
}