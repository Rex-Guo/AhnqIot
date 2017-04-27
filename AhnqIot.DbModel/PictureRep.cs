#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� PictureRep.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System.Collections.Generic;

#endregion

namespace AhnqIot.DbModel
{
    public partial class PictureRep : BaseEntity
    {
        public PictureRep()
        {
            CameraStationPics = new HashSet<CameraStationPics>();
            CompanyPics = new HashSet<CompanyPics>();
            FacilityPics = new HashSet<FacilityPics>();
        }

        public string Description { get; set; }
        public string Href { get; set; }
        public int Status { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public virtual ICollection<CameraStationPics> CameraStationPics { get; set; }
        public virtual ICollection<CompanyPics> CompanyPics { get; set; }
        public virtual ICollection<FacilityPics> FacilityPics { get; set; }
    }
}