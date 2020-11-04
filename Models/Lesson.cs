using System;

namespace SchoolPlanner.Models {
    public class Lesson {
        public Classroom Classroom { get; set; }
        public _Class _Class { get; set; }
        public string Subject { get; set; }
        public int Slot { get; set; }
        public Teacher Teacher { get; set; }

        public Lesson (Classroom classroom, _Class _class, string subject, int slot, Teacher teacher) {
            Classroom = classroom;
            _Class = _class;
            Subject = subject;
            Slot = slot;
            Teacher = teacher;
        }
    }
}