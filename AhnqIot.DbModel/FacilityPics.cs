#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� FacilityPics.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

#endregion

namespace AhnqIot.DbModel
{
    public partial class FacilityPics : BaseEntity
    {
        public string FacilityCameraPresetSerialnum { get; set; }
        public string FacilitySerialnum { get; set; }
        public string PicSerialnum { get; set; }
        public virtual FacilityCameraPresetPoint FacilityCameraPresetSerialnumNavigation { get; set; }
        public virtual Facility FacilitySerialnumNavigation { get; set; }
        public virtual PictureRep PicSerialnumNavigation { get; set; }
    }
}