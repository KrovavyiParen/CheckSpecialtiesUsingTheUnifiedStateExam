namespace CheckSpecialtiesUsingTheUnifiedStateExam.Components.Models
{
    public class AdmissionSpecialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Institute { get; set; }
        public int PassingScore { get; set; }
        public List<Subject> RequiredSubjects { get; set; } = new();

        public List<Subject> OptionalSubjects { get; set; } = new();
    }
}
