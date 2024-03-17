using System;
using System.Collections.Generic;

#nullable disable

namespace WebLibrary.Models
{
    public partial class LessonProgress
    {
        public int LessonProgressId { get; set; }
        public int? LessonId { get; set; }
        public int? ChapterProgressId { get; set; }
        public int? ProgressPercent { get; set; }
        public bool? Completed { get; set; }
        public DateTime? StartAt { get; set; }

        public virtual ChapterProgress ChapterProgress { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
