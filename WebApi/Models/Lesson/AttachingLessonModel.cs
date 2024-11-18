using System;

namespace WebApi.Models.Lesson
{
    /// <summary>
    /// Модель прикладываемого урока.
    /// </summary>
    public class AttachingLessonModel
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