#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� CameraStationPics.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class CameraStationPics : BaseEntity
    {
        public string CameraStationsPresetSerialnum { get; set; }
        public string PicSerialnum { get; set; }
        public virtual CameraStationPresetPoint CameraStationsPresetSerialnumNavigation { get; set; }
        public virtual PictureRep PicSerialnumNavigation { get; set; }
    }
}