#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� Log.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;

#endregion

namespace AhnqIot.DbModel
{
    public partial class Log
    {
        public int ID { get; set; }
        public string Action { get; set; }
        public string Category { get; set; }
        public string IP { get; set; }
        public DateTime OccurTime { get; set; }
        public string Remark { get; set; }
        public int? UserID { get; set; }
        public string UserName { get; set; }
    }
}