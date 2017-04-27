#region Code File Comment

// SOLUTION   �� ����ũҵ����������V3
// PROJECT    �� AhnqIot.DbModel
// FILENAME   �� ArticleContent.cs
// AUTHOR     �� soft-cq
// CREATE TIME�� 2016-01-11 15:27
// COPYRIGHT  �� ��Ȩ���� (C) ����˹�����������Ƽ����޹�˾ http://www.smartah.cc/ 2011~2015

#endregion

#region using namespace

using System;

#endregion

namespace AhnqIot.DbModel
{
    public partial class ArticleContent : BaseEntity
    {
        public string ArticleCategoryName { get; set; }
        public string ArticleCategorySerialnum { get; set; }
        public string Content { get; set; }
        public string Cover { get; set; }
        public DateTime? PublishTime { get; set; }
        public string SourceName { get; set; }
        public string SourceUrl { get; set; }
        public string Title { get; set; }
        public int? Views { get; set; }
    }
}