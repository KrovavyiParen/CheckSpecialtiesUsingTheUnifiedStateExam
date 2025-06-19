namespace CheckSpecialtiesUsingTheUnifiedStateExam.Components.Models
{
    public class AdmissionSpecialty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PassingScore { get; set; }
        public List<Subject> RequiredSubjects { get; set; } = new();
    }
}
