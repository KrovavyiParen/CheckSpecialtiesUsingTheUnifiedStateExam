using CheckSpecialtiesUsingTheUnifiedStateExam.Components.Models;

namespace CheckSpecialtiesUsingTheUnifiedStateExam.Components.Data
{
    public class AdmissionService
    {
        private readonly List<AdmissionSpecialty> _specialties = new()
    {
        new AdmissionSpecialty {
            Id = 1,
            Name = "07.03.01 Архитектура",
            PassingScore = 302,
            Institute = "Архитектуры и дизайна(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Вступительные, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Вступительные, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 2,
            Name = "07.03.03 Дизайн архитектурной среды",
            PassingScore = 297,
            Institute = "Архитектуры и дизайна(ТИУ)",
            RequiredSubjects = new() { Subject.Вступительные, Subject.Математика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Вступительные, Subject.Математика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 3,
            Name = "54.03.01 Дизайн",
            PassingScore = 156,
            Institute = "Архитектуры и дизайна(ТИУ)",
            RequiredSubjects = new() { Subject.Вступительные, Subject.Литература, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Вступительные, Subject.Литература, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 4,
            Name = "15.03.03 Прикладная механика",
            PassingScore = 168,
            Institute = "Транспорта(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 5,
            Name = "23.03.01 Технология транспортных процессов",
            PassingScore = 245,
            Institute = "Транспорта(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 6,
            Name = "08.03.01 Строительство",
            PassingScore = 137,
            Institute = "Строительный(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 7,
            Name = "08.03.01 Строительство",
            PassingScore = 137,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 8,
            Name = "013.03.02 Электроэнергетика и электротехника",
            PassingScore = 197,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 9,
            Name = "15.03.04. Автоматизация технологических процессов и производств",
            PassingScore = 225,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 10,
            Name = "18.03.01 Химическая технология",
            PassingScore = 167,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Химия, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Химия, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 11,
            Name = "18.03.02 Энерго - и ресурсосберегающие процессы в химической технологии, нефтехимии и биотехнологии",
            PassingScore = 230,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Химия, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Химия, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 12,
            Name = "21.03.01 Нефтегазовое дело",
            PassingScore = 219,
            Institute = "Высшая инженерная школа EG(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 13,
            Name = "01.03.02 Прикладная математика и информатика",
            PassingScore = 249,
            Institute = "Высшая школа цифровых технологий(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 14,
            Name = "09.03.01 Информатика и вычислительная техника",
            PassingScore = 231,
            Institute = "Высшая школа цифровых технологий(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 15,
            Name = "09.03.02 Информационные системы и технологии",
            PassingScore = 231,
            Institute = "Высшая школа цифровых технологий(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 16,
            Name = "38.03.05 Бизнес-информатика",
            PassingScore = 137,
            Institute = "Высшая школа цифровых технологий(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Информатика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 17,
            Name = "05.03.01 Геология",
            PassingScore = 186,
            Institute = "Нефтегазовый(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 18,
            Name = "12.03.04 Биотехнические системы и технологии",
            PassingScore = 148,
            Institute = "Нефтегазовый(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 19,
            Name = "15.03.04 Автоматизация технологических процессов и производств",
            PassingScore = 225,
            Institute = "Нефтегазовый(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 20,
            Name = "21.03.01 Нефтегазовое дело",
            PassingScore = 219,
            Institute = "Нефтегазовый(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 21,
            Name = "27.03.04 Управление в технических системах",
            PassingScore = 230,
            Institute = "Нефтегазовый(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 22,
            Name = "13.03.01 Теплоэнергетика и теплотехника",
            PassingScore = 147,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 23,
            Name = "20.03.01 Техносферная безопасность",
            PassingScore = 129,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 24,
            Name = "21.03.02 Землеустройство и кадастры",
            PassingScore = 161,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 25,
            Name = "27.03.03 Системный анализ и управление",
            PassingScore = 204,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 26,
            Name = "42.03.01 Реклама и связи с общественностью",
            PassingScore = 138,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 27,
            Name = "43.03.01 Сервис",
            PassingScore = 218,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 28,
            Name = "43.03.03 Гостиничное дело",
            PassingScore = 218,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Обществознание, Subject.История, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 29,
            Name = "38.03.01 Экономика",
            PassingScore = 110,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.История, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.История, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 30,
            Name = "38.03.02 Менеджмент",
            PassingScore = 110,
            Institute = "Сервиса и отраслевого управления(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.История, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.История, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 31,
            Name = "12.03.01 Приборостроение",
            PassingScore = 169,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 32,
            Name = "13.03.02 Электроэнергетика и электротехника",
            PassingScore = 197,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 33,
            Name = "15.03.01 Машиностроение",
            PassingScore = 182,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 34,
            Name = "15.03.05 Конструкторско-технологическое обеспечение машиностроительных производства",
            PassingScore = 119,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 35,
            Name = "15.03.06 Мехатроника и робототехника",
            PassingScore = 207,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 36,
            Name = "18.03.01 Химическая технология",
            PassingScore = 167,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Химия, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Химия, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 37,
            Name = "18.03.02 Энерго - и ресурсосберегающие процессы в химической технологии, нефтехимии и биотехнологии",
            PassingScore = 230,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Химия, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Химия, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 38,
            Name = "19.03.04 Технология продукции и организация общественного питания",
            PassingScore = 142,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 39,
            Name = "28.03.03 Наноматериалы",
            PassingScore = 158,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 40,
            Name = "122.03.01 Материаловедение и технологии материалов",
            PassingScore = 144,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 41,
            Name = "27.03.01 Стандартизация и метрология",
            PassingScore = 174,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 42,
            Name = "27.03.05 Инноватика",
            PassingScore = 176,
            Institute = "Промышленных технологий и инжиниринга(ТИУ)",
            RequiredSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык },
            OptionalSubjects = new() { Subject.Математика, Subject.Физика, Subject.РусскийЯзык }
        },
        new AdmissionSpecialty {
            Id = 43,
            Name = "06.03.01 Биология",
            PassingScore = 203,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.Биология, Subject.РусскийЯзык },
            OptionalSubjects = new() {Subject.Математика, Subject.Физика, Subject.Информатика, Subject.Химия }
        },
        new AdmissionSpecialty {
            Id = 44,
            Name = "05.03.02 География",
            PassingScore = 229,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.География, Subject.РусскийЯзык },
            OptionalSubjects = new() {Subject.Математика, Subject.Физика, Subject.Информатика, Subject.Биология }
        },
        new AdmissionSpecialty {
            Id = 45,
            Name = "38.03.04 Государственное и муниципальное управление",
            PassingScore = 276,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.Обществознание, Subject.РусскийЯзык },
            OptionalSubjects = new() {Subject.Математика, Subject.История }
        },
        new AdmissionSpecialty {
            Id = 46,
            Name = "42.03.02 Журналистика",
            PassingScore = 281,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.Литература, Subject.РусскийЯзык, Subject.Вступительные},
            OptionalSubjects = new() { Subject.Литература, Subject.РусскийЯзык, Subject.Вступительные}
        },
        new AdmissionSpecialty {
            Id = 47,
            Name = "41.03.01 Зарубежное регионоведение",
            PassingScore = 256,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.История, Subject.РусскийЯзык},
            OptionalSubjects = new() { Subject.Обществознание, Subject.География}
        },
        new AdmissionSpecialty {
            Id = 48,
            Name = "10.03.01 Информационная безопасность",
            PassingScore = 248,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.Математика, Subject.РусскийЯзык},
            OptionalSubjects = new() { Subject.Физика, Subject.Информатика}
        },
        new AdmissionSpecialty {
            Id = 49,
            Name = "09.03.02 Информационные системы и технологии",
            PassingScore = 263,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.Математика, Subject.РусскийЯзык},
            OptionalSubjects = new() { Subject.Физика, Subject.Информатика}
        },
        new AdmissionSpecialty {
            Id = 50,
            Name = "50.03.01 Искусства и гуманитарные науки",
            PassingScore = 263,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.История, Subject.РусскийЯзык},
            OptionalSubjects = new() { Subject.История, Subject.Обществознание}
        },

        new AdmissionSpecialty {
            Id = 51,
            Name = "46.03.01 История",
            PassingScore = 236,
            Institute = "ТюмГУ",
            RequiredSubjects = new() { Subject.История, Subject.РусскийЯзык},
            OptionalSubjects = new() { Subject.География, Subject.Обществознание}
        },
        
    };

        public List<AdmissionSpecialty> GetMatchingSpecialties(
            Dictionary<Subject, int> userScores,
            int minPassingScore = 0)
        {
            return _specialties
                .Where(s =>
            s.PassingScore >= minPassingScore &&
            s.RequiredSubjects.All(rs => userScores.ContainsKey(rs)) &&
            s.OptionalSubjects.Any(os => userScores.ContainsKey(os))
        )
            .ToList();
        }
    }
}
