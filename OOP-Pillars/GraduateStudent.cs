namespace OOP_Pillars
{
    public class GraduateStudent : IAthlete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public string Sport { get; set; }
        public string Team { get; set; }
        public string ThesisTitle { get; set; }

        public GraduateStudent(int id, string name, int age, string school, string grade, string sport, string team, string thesisTitle)
        {
            Id = id;
            Name = name;
            Age = age;
            School = school;
            Grade = grade;
            Sport = sport;
            Team = team;
            ThesisTitle = thesisTitle;
        }

        public string Introduce()
        {
            return $"Graduate Student ID: {Id}, Name: {Name}, Age: {Age}, School: {School}, Grade: {Grade}, Sport: {Sport}, Team: {Team}, Thesis Title: {ThesisTitle}";
        }

        public string GetAthleteInfo()
        {
            return $"Athlete Sport: {Sport}, Team: {Team}";
        }
    }
}
