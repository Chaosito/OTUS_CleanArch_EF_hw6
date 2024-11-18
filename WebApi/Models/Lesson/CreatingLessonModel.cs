using System;

namespace WebApi.Models.Lesson
{
    public class CreatingLessonModel
    {
        /// <summary>
        /// Идентификатор курса.
        /// </summary>
        public int CourseId { get; set; }
        
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