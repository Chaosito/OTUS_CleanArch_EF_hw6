using System;

namespace WebApi.Models.Lesson
{
    /// <summary>
    /// Модель редактируемого урока.
    /// </summary>
    public class UpdatingLessonModel
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