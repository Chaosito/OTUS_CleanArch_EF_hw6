using System;

namespace Services.Contracts.Lesson
{
    /// <summary>
    /// ДТО прикладываемого урока.
    /// </summary>
    public class AttachingLessonDto
    {
        /// <summary>
        /// Тема.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Дата добавления.
        /// </summary>
        public DateTime DateTime { get; set; }
    }
}