using System;

namespace AccessModifiers
{
    class CourseManager //classların defaultu : internal
    //internal o proje içeriisnde istediğimiz noktada çağırabileceğimiz anlamına gelir
    {
        public void Add()
        {
            Course course = new Course(); //direkt course'u kullabiliyorum
        }
    }
}
