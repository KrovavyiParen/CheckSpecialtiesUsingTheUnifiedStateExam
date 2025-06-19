using CheckSpecialtiesUsingTheUnifiedStateExam.Components.Models;

namespace CheckSpecialtiesUsingTheUnifiedStateExam.Components.Data
{
    public class AdmissionService
    {
        private readonly List<AdmissionSpecialty> _specialties = new()
    {
        new AdmissionSpecialty {
            Id = 1,
            Name = "Информационные системы",
            PassingScore = 245,
            RequiredSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 2,
            Name = "Прикладная физика",
            PassingScore = 230,
            RequiredSubjects = new() { Subject.Физика, Subject.Математика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 3,
            Name = "Биоинженерия",
            PassingScore = 255,
            RequiredSubjects = new() { Subject.Биология, Subject.Химия, Subject.Математика }
        }
    };

        public List<AdmissionSpecialty> GetMatchingSpecialties(
            Dictionary<Subject, int> userScores,
            int minPassingScore = 0)
        {
            return _specialties
                .Where(s =>
                    s.PassingScore >= minPassingScore &&
                    s.RequiredSubjects.All(rs => userScores.ContainsKey(rs)))
                .ToList();
        }
    }
}
