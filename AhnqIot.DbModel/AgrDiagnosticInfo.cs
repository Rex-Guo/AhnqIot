#region Code File Comment

// SOLUTION   �� ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� AgrDiagnosticInfo.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) �������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

namespace AhnqIot.DbModel
{
    public partial class AgrDiagnosticInfo : BaseEntity
    {
        public string AgrDiagnosticModelSerialnum { get; set; }
        public string Info { get; set; }
        public virtual AgrDiagnosticModel AgrDiagnosticModelSerialnumNavigation { get; set; }
    }
}