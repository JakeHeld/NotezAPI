namespace NotezAPI.Data.Entities
{
    internal static class Roles
    {
        public const string Lecturer = nameof(Lecturer);
        public const string Student = nameof(Student);
        public const string StudentPLus = Lecturer + "," + Student;
    }
}