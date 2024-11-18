using System;

namespace Services.Contracts.Lesson
{
    /// <summary>
    /// ДТО урока.
    /// </summary>
    public class LessonDto
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }
        
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