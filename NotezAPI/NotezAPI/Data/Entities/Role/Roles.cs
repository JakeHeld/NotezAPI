namespace NotezAPI.Data.Entities.Role
{
    internal static class Roles
    {
        public const string Lecturer = nameof(Lecturer);
        public const string Student = nameof(Student);
        public const string StudentPlus = Lecturer + "," + Student;
    }
}