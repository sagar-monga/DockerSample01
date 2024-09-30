using DockerSample01.Models;

namespace DockerSample01
{
    public class EmployeeDataStore
    {
        public List<EmployeeDto> Employees { get; set; }

        public static EmployeeDataStore Current { get; } = new EmployeeDataStore();

        public EmployeeDataStore()
        {
            Employees = new List<EmployeeDto>() {
        new EmployeeDto()
{
        Id = 1,
        FirstName = "Editha",
        LastName = "Tregear",
        Salary = 622619,
        Department = "Services",
        Position = "Assistant Manager",
        HireDate = DateTime.Parse("2022-09-08 23:04:01"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-01-24 09:33:18")
    },
    new EmployeeDto()
{
        Id = 2,
        FirstName = "Torin",
        LastName = "Bowller",
        Salary = 121237,
        Department = "Marketing",
        Position = "Account Executive",
        HireDate = DateTime.Parse("2022-03-17 01:42:26"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-10-18 07:26:31")
    },
    new EmployeeDto()
{
        Id = 3,
        FirstName = "Roby",
        LastName = "Yglesias",
        Salary = 307611,
        Department = "Product Management",
        Position = "Administrative Assistant IV",
        HireDate = DateTime.Parse("2018-03-31 12:59:21"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-09-09 02:22:59")
    },
    new EmployeeDto()
{
        Id = 4,
        FirstName = "Mord",
        LastName = "Lohan",
        Salary = 216914,
        Department = "Product Management",
        Position = "VP Product Management",
        HireDate = DateTime.Parse("2015-06-29 19:41:36"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-01-16 03:52:18")
    },
    new EmployeeDto()
{
        Id = 5,
        FirstName = "Garwin",
        LastName = "Westnedge",
        Salary = 476032,
        Department = "Training",
        Position = "Accountant II",
        HireDate = DateTime.Parse("2022-10-27 13:30:27"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-04-17 01:16:25")
    },
    new EmployeeDto()
{
        Id = 6,
        FirstName = "Sena",
        LastName = "Tonry",
        Salary = 289547,
        Department = "Business Development",
        Position = "Mechanical Systems Engineer",
        HireDate = DateTime.Parse("2015-04-15 15:10:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-02-03 07:23:57")
    },
    new EmployeeDto()
{
        Id = 7,
        FirstName = "Kata",
        LastName = "Morena",
        Salary = 193147,
        Department = "Sales",
        Position = "Librarian",
        HireDate = DateTime.Parse("2017-11-05 16:52:06"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-07-30 17:38:47")
    },
    new EmployeeDto()
{
        Id = 8,
        FirstName = "Pyotr",
        LastName = "Beeken",
        Salary = 666275,
        Department = "Support",
        Position = "VP Sales",
        HireDate = DateTime.Parse("2017-10-16 18:01:47"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-07-31 09:21:28")
    },
    new EmployeeDto()
{
        Id = 9,
        FirstName = "Caralie",
        LastName = "Sammons",
        Salary = 241963,
        Department = "Product Management",
        Position = "Data Coordinator",
        HireDate = DateTime.Parse("2019-07-17 11:33:36"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-02-06 06:51:34")
    },
    new EmployeeDto()
{
        Id = 10,
        FirstName = "Lana",
        LastName = "Itzhak",
        Salary = 353539,
        Department = "Engineering",
        Position = "Human Resources Manager",
        HireDate = DateTime.Parse("2015-01-31 07:00:52"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-04-02 11:53:16")
    },
    new EmployeeDto()
{
        Id = 11,
        FirstName = "Giovanni",
        LastName = "Purrier",
        Salary = 110940,
        Department = "Support",
        Position = "Environmental Specialist",
        HireDate = DateTime.Parse("2018-09-30 10:38:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-09-05 08:25:15")
    },
    new EmployeeDto()
{
        Id = 12,
        FirstName = "Jermaine",
        LastName = "Emett",
        Salary = 442046,
        Department = "Training",
        Position = "Health Coach III",
        HireDate = DateTime.Parse("2018-06-21 11:59:21"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-05-13 11:10:10")
    },
    new EmployeeDto()
{
        Id = 13,
        FirstName = "Lionel",
        LastName = "Tyers",
        Salary = 595280,
        Department = "Sales",
        Position = "VP Product Management",
        HireDate = DateTime.Parse("2023-12-06 13:43:15"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-06-23 02:20:51")
    },
    new EmployeeDto()
{
        Id = 14,
        FirstName = "Aurea",
        LastName = "Ruselin",
        Salary = 507691,
        Department = "Training",
        Position = "Project Manager",
        HireDate = DateTime.Parse("2019-09-14 07:51:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-05-12 05:58:56")
    },
    new EmployeeDto()
{
        Id = 15,
        FirstName = "Jard",
        LastName = "Snowdon",
        Salary = 176690,
        Department = "Sales",
        Position = "Executive Secretary",
        HireDate = DateTime.Parse("2018-07-16 03:16:19"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-12-26 08:08:33")
    },
    new EmployeeDto()
{
        Id = 16,
        FirstName = "Perle",
        LastName = "Keech",
        Salary = 672589,
        Department = "Sales",
        Position = "Mechanical Systems Engineer",
        HireDate = DateTime.Parse("2017-06-17 06:41:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-01-07 11:12:43")
    },
    new EmployeeDto()
{
        Id = 17,
        FirstName = "Adriena",
        LastName = "Wearne",
        Salary = 401949,
        Department = "Support",
        Position = "Business Systems Development Analyst",
        HireDate = DateTime.Parse("2019-08-13 23:59:47"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-08-10 19:34:15")
    },
    new EmployeeDto()
{
        Id = 18,
        FirstName = "Frayda",
        LastName = "Pumphreys",
        Salary = 614505,
        Department = "Services",
        Position = "Administrative Assistant II",
        HireDate = DateTime.Parse("2019-01-01 06:00:27"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-01-19 18:18:13")
    },
    new EmployeeDto()
{
        Id = 19,
        FirstName = "Genevieve",
        LastName = "Glackin",
        Salary = 565013,
        Department = "Research and Development",
        Position = "Editor",
        HireDate = DateTime.Parse("2022-12-12 23:59:59"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-06-27 19:46:36")
    },
    new EmployeeDto()
{
        Id = 20,
        FirstName = "Deanna",
        LastName = "Denford",
        Salary = 676940,
        Department = "Research and Development",
        Position = "Geological Engineer",
        HireDate = DateTime.Parse("2021-03-22 18:45:06"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-01-09 07:29:00")
    },
    new EmployeeDto()
{
        Id = 21,
        FirstName = "Cameron",
        LastName = "Maplethorpe",
        Salary = 721453,
        Department = "Human Resources",
        Position = "Assistant Professor",
        HireDate = DateTime.Parse("2022-07-07 21:47:49"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("2000-05-22 08:42:53")
    },
    new EmployeeDto()
{
        Id = 22,
        FirstName = "Hobey",
        LastName = "Vedyashkin",
        Salary = 443392,
        Department = "Marketing",
        Position = "Computer Systems Analyst IV",
        HireDate = DateTime.Parse("2017-03-28 15:37:45"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-03-13 12:07:50")
    },
    new EmployeeDto()
{
        Id = 23,
        FirstName = "Donetta",
        LastName = "Aysh",
        Salary = 325659,
        Department = "Human Resources",
        Position = "Analog Circuit Design manager",
        HireDate = DateTime.Parse("2020-01-16 20:09:40"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-05-26 17:25:41")
    },
    new EmployeeDto()
{
        Id = 24,
        FirstName = "Jaquenette",
        LastName = "Tennock",
        Salary = 757700,
        Department = "Research and Development",
        Position = "Senior Editor",
        HireDate = DateTime.Parse("2023-10-03 03:14:58"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-02-04 12:19:40")
    },
    new EmployeeDto()
{
        Id = 25,
        FirstName = "Barr",
        LastName = "Gleed",
        Salary = 509951,
        Department = "Services",
        Position = "VP Product Management",
        HireDate = DateTime.Parse("2017-11-01 18:01:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-02-15 14:47:54")
    },
    new EmployeeDto()
{
        Id = 26,
        FirstName = "Leonhard",
        LastName = "Hearsum",
        Salary = 302130,
        Department = "Human Resources",
        Position = "Assistant Media Planner",
        HireDate = DateTime.Parse("2016-09-16 06:42:28"),
        LastWorkingDate = DateTime.Parse("2020-07-29 00:20:55"),
        DateOfBirth = DateTime.Parse("1996-05-17 19:34:56")
    },
    new EmployeeDto()
{
        Id = 27,
        FirstName = "Nathanial",
        LastName = "Start",
        Salary = 674286,
        Department = "Marketing",
        Position = "Statistician IV",
        HireDate = DateTime.Parse("2024-07-07 12:21:05"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-01-05 19:38:39")
    },
    new EmployeeDto()
{
        Id = 28,
        FirstName = "Dani",
        LastName = "Brendish",
        Salary = 339585,
        Department = "Marketing",
        Position = "Structural Engineer",
        HireDate = DateTime.Parse("2017-02-12 08:44:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-01-18 04:25:22")
    },
    new EmployeeDto()
{
        Id = 29,
        FirstName = "Tobin",
        LastName = "Wolland",
        Salary = 247974,
        Department = "Product Management",
        Position = "Geologist II",
        HireDate = DateTime.Parse("2018-09-29 13:48:14"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-03-11 19:23:52")
    },
    new EmployeeDto()
{
        Id = 30,
        FirstName = "Demetre",
        LastName = "Binder",
        Salary = 753453,
        Department = "Legal",
        Position = "Design Engineer",
        HireDate = DateTime.Parse("2017-05-16 23:27:04"),
        LastWorkingDate = DateTime.Parse("2033-02-21 23:49:41"),
        DateOfBirth = DateTime.Parse("1997-02-05 17:36:20")
    },
    new EmployeeDto()
{
        Id = 31,
        FirstName = "Hebert",
        LastName = "Skoof",
        Salary = 604185,
        Department = "Sales",
        Position = "Web Designer III",
        HireDate = DateTime.Parse("2023-12-08 20:44:08"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-06-17 05:12:59")
    },
    new EmployeeDto()
{
        Id = 32,
        FirstName = "Inesita",
        LastName = "Balm",
        Salary = 685358,
        Department = "Engineering",
        Position = "Chief Design Engineer",
        HireDate = DateTime.Parse("2015-10-22 10:55:42"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-11-18 03:20:26")
    },
    new EmployeeDto()
{
        Id = 33,
        FirstName = "Arlana",
        LastName = "Oakeby",
        Salary = 526989,
        Department = "Training",
        Position = "Data Coordinator",
        HireDate = DateTime.Parse("2022-05-07 07:50:49"),
        LastWorkingDate = DateTime.Parse("2029-10-17 09:42:26"),
        DateOfBirth = DateTime.Parse("1997-08-27 07:27:05")
    },
    new EmployeeDto()
{
        Id = 34,
        FirstName = "Codi",
        LastName = "Nan Carrow",
        Salary = 593254,
        Department = "Accounting",
        Position = "Media Manager I",
        HireDate = DateTime.Parse("2018-06-09 16:57:45"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-04-15 09:29:59")
    },
    new EmployeeDto()
{
        Id = 35,
        FirstName = "Bear",
        LastName = "Lampe",
        Salary = 200031,
        Department = "Training",
        Position = "Director of Sales",
        HireDate = DateTime.Parse("2020-08-19 19:33:54"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-12-21 21:36:41")
    },
    new EmployeeDto()
{
        Id = 36,
        FirstName = "Hartley",
        LastName = "Tudgay",
        Salary = 241301,
        Department = "Research and Development",
        Position = "Physical Therapy Assistant",
        HireDate = DateTime.Parse("2017-07-22 06:12:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-09-17 10:33:47")
    },
    new EmployeeDto()
{
        Id = 37,
        FirstName = "Bette",
        LastName = "Erik",
        Salary = 646311,
        Department = "Legal",
        Position = "VP Sales",
        HireDate = DateTime.Parse("2018-07-11 17:49:57"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-08-15 17:04:35")
    },
    new EmployeeDto()
{
        Id = 38,
        FirstName = "Ambrosio",
        LastName = "Howitt",
        Salary = 28351,
        Department = "Training",
        Position = "Tax Accountant",
        HireDate = DateTime.Parse("2023-11-03 18:24:25"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-04-08 17:18:26")
    },
    new EmployeeDto()
{
        Id = 39,
        FirstName = "Kane",
        LastName = "Palek",
        Salary = 90536,
        Department = "Support",
        Position = "Health Coach III",
        HireDate = DateTime.Parse("2023-05-31 11:29:28"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-03-04 17:30:27")
    },
    new EmployeeDto()
{
        Id = 40,
        FirstName = "Megan",
        LastName = "Degue",
        Salary = 374488,
        Department = "Sales",
        Position = "Civil Engineer",
        HireDate = DateTime.Parse("2020-06-03 23:01:21"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-03-13 22:51:36")
    },
    new EmployeeDto()
{
        Id = 41,
        FirstName = "Orsola",
        LastName = "Fippe",
        Salary = 642787,
        Department = "Accounting",
        Position = "Nurse",
        HireDate = DateTime.Parse("2021-09-16 23:28:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-11-04 02:22:16")
    },
    new EmployeeDto()
{
        Id = 42,
        FirstName = "Turner",
        LastName = "Stopforth",
        Salary = 214610,
        Department = "Services",
        Position = "Human Resources Assistant I",
        HireDate = DateTime.Parse("2023-12-02 00:17:20"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("2000-04-29 02:37:28")
    },
    new EmployeeDto()
{
        Id = 43,
        FirstName = "Pernell",
        LastName = "Tunny",
        Salary = 665786,
        Department = "Research and Development",
        Position = "VP Accounting",
        HireDate = DateTime.Parse("2019-10-04 15:24:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-06-09 08:22:09")
    },
    new EmployeeDto()
{
        Id = 44,
        FirstName = "Jess",
        LastName = "Hatwells",
        Salary = 625514,
        Department = "Human Resources",
        Position = "Web Designer IV",
        HireDate = DateTime.Parse("2024-04-30 09:18:48"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-08-03 00:44:13")
    },
    new EmployeeDto()
{
        Id = 45,
        FirstName = "Nefen",
        LastName = "Daughtry",
        Salary = 323671,
        Department = "Services",
        Position = "Mechanical Systems Engineer",
        HireDate = DateTime.Parse("2021-05-19 21:18:50"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-10-05 18:21:37")
    },
    new EmployeeDto()
{
        Id = 46,
        FirstName = "Elinor",
        LastName = "Anderer",
        Salary = 308945,
        Department = "Product Management",
        Position = "Staff Accountant III",
        HireDate = DateTime.Parse("2015-08-18 22:30:24"),
        LastWorkingDate = DateTime.Parse("2031-12-15 15:13:38"),
        DateOfBirth = DateTime.Parse("1988-02-29 11:34:59")
    },
    new EmployeeDto()
{
        Id = 47,
        FirstName = "Minny",
        LastName = "Coneybeare",
        Salary = 549919,
        Department = "Research and Development",
        Position = "Research Assistant IV",
        HireDate = DateTime.Parse("2024-06-04 23:31:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-06-14 04:15:55")
    },
    new EmployeeDto()
{
        Id = 48,
        FirstName = "Rem",
        LastName = "Copner",
        Salary = 81344,
        Department = "Product Management",
        Position = "Chemical Engineer",
        HireDate = DateTime.Parse("2023-12-21 17:37:43"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-11-10 18:38:01")
    },
    new EmployeeDto()
{
        Id = 49,
        FirstName = "Cyrill",
        LastName = "Trudgion",
        Salary = 584535,
        Department = "Accounting",
        Position = "Senior Developer",
        HireDate = DateTime.Parse("2017-06-14 05:21:26"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-06-01 00:40:27")
    },
    new EmployeeDto()
{
        Id = 50,
        FirstName = "Lothaire",
        LastName = "Mc Cahey",
        Salary = 726095,
        Department = "Sales",
        Position = "Accounting Assistant II",
        HireDate = DateTime.Parse("2022-12-27 23:43:19"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-05-28 14:23:49")
    },
    new EmployeeDto()
{
        Id = 51,
        FirstName = "Ronny",
        LastName = "Albiston",
        Salary = 506550,
        Department = "Engineering",
        Position = "Dental Hygienist",
        HireDate = DateTime.Parse("2016-05-22 01:39:54"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-12-13 10:07:43")
    },
    new EmployeeDto()
{
        Id = 52,
        FirstName = "Osbert",
        LastName = "Richold",
        Salary = 440155,
        Department = "Marketing",
        Position = "Health Coach IV",
        HireDate = DateTime.Parse("2018-03-18 22:50:22"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-04-11 02:57:54")
    },
    new EmployeeDto()
{
        Id = 53,
        FirstName = "Seamus",
        LastName = "Wycliffe",
        Salary = 554473,
        Department = "Support",
        Position = "Health Coach II",
        HireDate = DateTime.Parse("2020-05-08 22:16:51"),
        LastWorkingDate = DateTime.Parse("2031-05-17 00:03:45"),
        DateOfBirth = DateTime.Parse("1992-03-07 07:27:20")
    },
    new EmployeeDto()
{
        Id = 54,
        FirstName = "Lorilee",
        LastName = "Troucher",
        Salary = 667107,
        Department = "Services",
        Position = "Quality Control Specialist",
        HireDate = DateTime.Parse("2016-07-31 11:52:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-06-28 05:45:20")
    },
    new EmployeeDto()
{
        Id = 55,
        FirstName = "Gian",
        LastName = "Gostall",
        Salary = 306478,
        Department = "Human Resources",
        Position = "Community Outreach Specialist",
        HireDate = DateTime.Parse("2023-07-17 03:12:56"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-05-13 18:51:45")
    },
    new EmployeeDto()
{
        Id = 56,
        FirstName = "Alf",
        LastName = "Saffe",
        Salary = 732026,
        Department = "Human Resources",
        Position = "Associate Professor",
        HireDate = DateTime.Parse("2017-08-31 21:58:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-10-02 23:42:21")
    },
    new EmployeeDto()
{
        Id = 57,
        FirstName = "Torey",
        LastName = "Durman",
        Salary = 266775,
        Department = "Legal",
        Position = "Staff Accountant I",
        HireDate = DateTime.Parse("2023-10-05 01:27:29"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-03-26 20:16:02")
    },
    new EmployeeDto()
{
        Id = 58,
        FirstName = "Nev",
        LastName = "Teasey",
        Salary = 471303,
        Department = "Human Resources",
        Position = "Structural Engineer",
        HireDate = DateTime.Parse("2019-09-09 21:07:25"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-02-24 10:58:54")
    },
    new EmployeeDto()
{
        Id = 59,
        FirstName = "Becki",
        LastName = "Duval",
        Salary = 88280,
        Department = "Sales",
        Position = "Payment Adjustment Coordinator",
        HireDate = DateTime.Parse("2024-01-09 17:55:39"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-05-25 22:12:53")
    },
    new EmployeeDto()
{
        Id = 60,
        FirstName = "Shellysheldon",
        LastName = "Swannie",
        Salary = 462503,
        Department = "Product Management",
        Position = "Speech Pathologist",
        HireDate = DateTime.Parse("2018-04-17 09:55:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-12-25 09:47:55")
    },
    new EmployeeDto()
{
        Id = 61,
        FirstName = "Welch",
        LastName = "Horder",
        Salary = 38639,
        Department = "Product Management",
        Position = "Clinical Specialist",
        HireDate = DateTime.Parse("2024-01-23 00:35:15"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-06-18 22:34:46")
    },
    new EmployeeDto()
{
        Id = 62,
        FirstName = "Huntlee",
        LastName = "Pond",
        Salary = 658820,
        Department = "Sales",
        Position = "Senior Quality Engineer",
        HireDate = DateTime.Parse("2022-02-05 07:17:58"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-02-15 11:31:32")
    },
    new EmployeeDto()
{
        Id = 63,
        FirstName = "Freeman",
        LastName = "Crutcher",
        Salary = 668694,
        Department = "Accounting",
        Position = "Administrative Assistant IV",
        HireDate = DateTime.Parse("2017-07-14 23:14:18"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-07-29 23:37:16")
    },
    new EmployeeDto()
{
        Id = 64,
        FirstName = "Tressa",
        LastName = "Yegorev",
        Salary = 545926,
        Department = "Marketing",
        Position = "Librarian",
        HireDate = DateTime.Parse("2020-01-18 07:48:45"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-08-21 08:38:53")
    },
    new EmployeeDto()
{
        Id = 65,
        FirstName = "Susannah",
        LastName = "Glassman",
        Salary = 94925,
        Department = "Services",
        Position = "Desktop Support Technician",
        HireDate = DateTime.Parse("2015-07-19 12:18:08"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-03-04 16:49:29")
    },
    new EmployeeDto()
{
        Id = 66,
        FirstName = "Don",
        LastName = "Ibeson",
        Salary = 662660,
        Department = "Accounting",
        Position = "Technical Writer",
        HireDate = DateTime.Parse("2024-03-18 21:03:44"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-07-17 15:47:44")
    },
    new EmployeeDto()
{
        Id = 67,
        FirstName = "Annice",
        LastName = "Brixey",
        Salary = 361616,
        Department = "Training",
        Position = "Biostatistician I",
        HireDate = DateTime.Parse("2017-08-08 22:58:21"),
        LastWorkingDate = DateTime.Parse("2028-06-29 23:15:51"),
        DateOfBirth = DateTime.Parse("1995-03-13 23:36:44")
    },
    new EmployeeDto()
{
        Id = 68,
        FirstName = "Millard",
        LastName = "Harold",
        Salary = 655325,
        Department = "Support",
        Position = "Automation Specialist IV",
        HireDate = DateTime.Parse("2020-07-17 22:48:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-05-15 20:29:04")
    },
    new EmployeeDto()
{
        Id = 69,
        FirstName = "Chauncey",
        LastName = "Stampfer",
        Salary = 664486,
        Department = "Training",
        Position = "Junior Executive",
        HireDate = DateTime.Parse("2021-12-21 13:19:29"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-03-24 11:28:46")
    },
    new EmployeeDto()
{
        Id = 70,
        FirstName = "Roanna",
        LastName = "Brunn",
        Salary = 284589,
        Department = "Engineering",
        Position = "Administrative Assistant IV",
        HireDate = DateTime.Parse("2022-03-13 23:34:16"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-04-27 07:53:35")
    },
    new EmployeeDto()
{
        Id = 71,
        FirstName = "Joyce",
        LastName = "Mahon",
        Salary = 389039,
        Department = "Support",
        Position = "Physical Therapy Assistant",
        HireDate = DateTime.Parse("2021-11-22 11:24:12"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-04-11 21:38:01")
    },
    new EmployeeDto()
{
        Id = 72,
        FirstName = "North",
        LastName = "Bischof",
        Salary = 523191,
        Department = "Accounting",
        Position = "Nurse Practicioner",
        HireDate = DateTime.Parse("2020-12-10 19:16:55"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-03-01 06:00:06")
    },
    new EmployeeDto()
{
        Id = 73,
        FirstName = "Earle",
        LastName = "Stanlick",
        Salary = 167795,
        Department = "Accounting",
        Position = "Software Engineer III",
        HireDate = DateTime.Parse("2015-01-29 05:39:12"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-09-23 12:29:52")
    },
    new EmployeeDto()
{
        Id = 74,
        FirstName = "Franz",
        LastName = "Addicott",
        Salary = 609441,
        Department = "Legal",
        Position = "Programmer II",
        HireDate = DateTime.Parse("2023-05-12 08:36:08"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("2000-04-04 16:53:12")
    },
    new EmployeeDto()
{
        Id = 75,
        FirstName = "Thekla",
        LastName = "Rosenschein",
        Salary = 584453,
        Department = "Marketing",
        Position = "Occupational Therapist",
        HireDate = DateTime.Parse("2020-07-11 04:23:40"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-05-12 05:56:41")
    },
    new EmployeeDto()
{
        Id = 76,
        FirstName = "Virgina",
        LastName = "de Marco",
        Salary = 88398,
        Department = "Training",
        Position = "Staff Scientist",
        HireDate = DateTime.Parse("2020-07-15 18:32:07"),
        LastWorkingDate = DateTime.Parse("2024-01-16 23:38:25"),
        DateOfBirth = DateTime.Parse("1993-02-08 07:40:17")
    },
    new EmployeeDto()
{
        Id = 77,
        FirstName = "Rianon",
        LastName = "Glazier",
        Salary = 45833,
        Department = "Support",
        Position = "Human Resources Assistant III",
        HireDate = DateTime.Parse("2022-08-28 00:14:44"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-05-03 14:49:56")
    },
    new EmployeeDto()
{
        Id = 78,
        FirstName = "Witty",
        LastName = "Puddephatt",
        Salary = 337322,
        Department = "Services",
        Position = "Actuary",
        HireDate = DateTime.Parse("2016-05-19 22:49:36"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-02-24 08:14:03")
    },
    new EmployeeDto()
{
        Id = 79,
        FirstName = "Tris",
        LastName = "Desesquelle",
        Salary = 109629,
        Department = "Sales",
        Position = "Paralegal",
        HireDate = DateTime.Parse("2017-11-04 09:43:19"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-01-02 11:29:06")
    },
    new EmployeeDto()
{
        Id = 80,
        FirstName = "Constancy",
        LastName = "Corneliussen",
        Salary = 362586,
        Department = "Accounting",
        Position = "Pharmacist",
        HireDate = DateTime.Parse("2016-10-28 13:02:59"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-10-16 15:25:49")
    },
    new EmployeeDto()
{
        Id = 81,
        FirstName = "Analiese",
        LastName = "Antognoni",
        Salary = 85934,
        Department = "Support",
        Position = "Environmental Specialist",
        HireDate = DateTime.Parse("2023-01-27 22:47:41"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-02-07 17:01:38")
    },
    new EmployeeDto()
{
        Id = 82,
        FirstName = "Elisabetta",
        LastName = "McGreal",
        Salary = 580690,
        Department = "Human Resources",
        Position = "Registered Nurse",
        HireDate = DateTime.Parse("2015-03-11 23:33:21"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-07-01 02:46:05")
    },
    new EmployeeDto()
{
        Id = 83,
        FirstName = "Elvyn",
        LastName = "Courtonne",
        Salary = 599576,
        Department = "Accounting",
        Position = "VP Accounting",
        HireDate = DateTime.Parse("2022-09-11 20:01:38"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-03-19 23:54:15")
    },
    new EmployeeDto()
{
        Id = 84,
        FirstName = "Randy",
        LastName = "Nucator",
        Salary = 504971,
        Department = "Training",
        Position = "Software Consultant",
        HireDate = DateTime.Parse("2018-06-25 18:18:48"),
        LastWorkingDate = DateTime.Parse("2023-04-30 15:46:46"),
        DateOfBirth = DateTime.Parse("1985-09-19 23:47:10")
    },
    new EmployeeDto()
{
        Id = 85,
        FirstName = "Ev",
        LastName = "Goligly",
        Salary = 251543,
        Department = "Engineering",
        Position = "Pharmacist",
        HireDate = DateTime.Parse("2019-12-23 09:04:50"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-11-21 06:34:28")
    },
    new EmployeeDto()
{
        Id = 86,
        FirstName = "Jaquelyn",
        LastName = "O'Nolan",
        Salary = 68513,
        Department = "Sales",
        Position = "Teacher",
        HireDate = DateTime.Parse("2019-06-06 03:44:55"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-08-26 00:25:40")
    },
    new EmployeeDto()
{
        Id = 87,
        FirstName = "Albertine",
        LastName = "Fayer",
        Salary = 705512,
        Department = "Support",
        Position = "Dental Hygienist",
        HireDate = DateTime.Parse("2016-10-26 10:56:01"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-03-06 18:48:02")
    },
    new EmployeeDto()
{
        Id = 88,
        FirstName = "Horst",
        LastName = "Fasey",
        Salary = 685385,
        Department = "Research and Development",
        Position = "Information Systems Manager",
        HireDate = DateTime.Parse("2023-10-04 15:21:46"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-02-14 17:20:40")
    },
    new EmployeeDto()
{
        Id = 89,
        FirstName = "Quinn",
        LastName = "Sheere",
        Salary = 615452,
        Department = "Product Management",
        Position = "Financial Analyst",
        HireDate = DateTime.Parse("2017-02-08 07:08:47"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-04-29 18:38:05")
    },
    new EmployeeDto()
{
        Id = 90,
        FirstName = "Donall",
        LastName = "Beers",
        Salary = 446388,
        Department = "Product Management",
        Position = "Programmer I",
        HireDate = DateTime.Parse("2021-05-25 15:30:14"),
        LastWorkingDate = DateTime.Parse("2025-02-08 02:20:53"),
        DateOfBirth = DateTime.Parse("1993-03-31 20:00:51")
    },
    new EmployeeDto()
{
        Id = 91,
        FirstName = "Mayer",
        LastName = "Yexley",
        Salary = 739999,
        Department = "Support",
        Position = "Data Coordinator",
        HireDate = DateTime.Parse("2021-07-08 22:35:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-11-18 23:25:53")
    },
    new EmployeeDto()
{
        Id = 92,
        FirstName = "Kitti",
        LastName = "Marklew",
        Salary = 419651,
        Department = "Marketing",
        Position = "Senior Cost Accountant",
        HireDate = DateTime.Parse("2022-11-25 05:27:30"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-10-31 04:29:19")
    },
    new EmployeeDto()
{
        Id = 93,
        FirstName = "Lucila",
        LastName = "Marzelli",
        Salary = 448824,
        Department = "Product Management",
        Position = "Database Administrator III",
        HireDate = DateTime.Parse("2017-03-01 16:23:24"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-09-23 07:48:49")
    },
    new EmployeeDto()
{
        Id = 94,
        FirstName = "Lamont",
        LastName = "Hordell",
        Salary = 533476,
        Department = "Product Management",
        Position = "Cost Accountant",
        HireDate = DateTime.Parse("2015-05-29 16:00:55"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-09-23 20:43:09")
    },
    new EmployeeDto()
{
        Id = 95,
        FirstName = "Gayleen",
        LastName = "Norster",
        Salary = 505049,
        Department = "Engineering",
        Position = "Structural Engineer",
        HireDate = DateTime.Parse("2021-03-26 02:09:04"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-04-12 20:56:18")
    },
    new EmployeeDto()
{
        Id = 96,
        FirstName = "Aurlie",
        LastName = "Tripett",
        Salary = 320614,
        Department = "Marketing",
        Position = "Executive Secretary",
        HireDate = DateTime.Parse("2019-10-23 00:30:17"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-04-16 19:24:00")
    },
    new EmployeeDto()
{
        Id = 97,
        FirstName = "Egan",
        LastName = "Suddell",
        Salary = 601511,
        Department = "Business Development",
        Position = "Marketing Manager",
        HireDate = DateTime.Parse("2019-06-05 17:38:27"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-10-08 22:20:03")
    },
    new EmployeeDto()
{
        Id = 98,
        FirstName = "Juana",
        LastName = "Reuven",
        Salary = 680453,
        Department = "Product Management",
        Position = "Payment Adjustment Coordinator",
        HireDate = DateTime.Parse("2016-09-06 15:59:52"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-03-06 19:13:35")
    },
    new EmployeeDto()
{
        Id = 99,
        FirstName = "Addison",
        LastName = "Schneidau",
        Salary = 55711,
        Department = "Marketing",
        Position = "Pharmacist",
        HireDate = DateTime.Parse("2016-01-17 07:03:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-03-30 20:54:59")
    },
    new EmployeeDto()
{
        Id = 100,
        FirstName = "Tammy",
        LastName = "Demangel",
        Salary = 671083,
        Department = "Business Development",
        Position = "Account Coordinator",
        HireDate = DateTime.Parse("2019-09-18 10:25:03"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-10-25 04:09:21")
    },
    new EmployeeDto()
{
        Id = 101,
        FirstName = "Gray",
        LastName = "Clowes",
        Salary = 293243,
        Department = "Research and Development",
        Position = "Structural Analysis Engineer",
        HireDate = DateTime.Parse("2018-05-27 17:19:48"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-10-21 15:13:29")
    },
    new EmployeeDto()
{
        Id = 102,
        FirstName = "Shell",
        LastName = "Heliar",
        Salary = 171680,
        Department = "Support",
        Position = "Nurse Practicioner",
        HireDate = DateTime.Parse("2020-10-12 15:50:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-04-12 13:17:27")
    },
    new EmployeeDto()
{
        Id = 103,
        FirstName = "Dorris",
        LastName = "De Roeck",
        Salary = 740567,
        Department = "Research and Development",
        Position = "Help Desk Technician",
        HireDate = DateTime.Parse("2016-05-31 04:08:55"),
        LastWorkingDate = DateTime.Parse("2016-12-24 17:39:56"),
        DateOfBirth = DateTime.Parse("1989-01-17 03:31:41")
    },
    new EmployeeDto()
{
        Id = 104,
        FirstName = "Bride",
        LastName = "Heinle",
        Salary = 584510,
        Department = "Human Resources",
        Position = "Programmer Analyst II",
        HireDate = DateTime.Parse("2021-11-17 12:32:50"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-07-30 19:39:42")
    },
    new EmployeeDto()
{
        Id = 105,
        FirstName = "Alleyn",
        LastName = "Huske",
        Salary = 92201,
        Department = "Business Development",
        Position = "Pharmacist",
        HireDate = DateTime.Parse("2021-03-23 06:29:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-10-08 10:17:42")
    },
    new EmployeeDto()
{
        Id = 106,
        FirstName = "Neils",
        LastName = "Heffernon",
        Salary = 752265,
        Department = "Research and Development",
        Position = "Actuary",
        HireDate = DateTime.Parse("2018-02-09 11:27:57"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-04-13 10:04:37")
    },
    new EmployeeDto()
{
        Id = 107,
        FirstName = "Sibylle",
        LastName = "Konig",
        Salary = 231625,
        Department = "Engineering",
        Position = "Editor",
        HireDate = DateTime.Parse("2017-12-06 05:42:50"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-12-28 11:20:11")
    },
    new EmployeeDto()
{
        Id = 108,
        FirstName = "Sigmund",
        LastName = "Swalwel",
        Salary = 268806,
        Department = "Sales",
        Position = "Administrative Officer",
        HireDate = DateTime.Parse("2019-02-21 01:48:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-11-29 10:53:50")
    },
    new EmployeeDto()
{
        Id = 109,
        FirstName = "Harmon",
        LastName = "Ioannou",
        Salary = 343983,
        Department = "Human Resources",
        Position = "Software Test Engineer IV",
        HireDate = DateTime.Parse("2022-04-18 04:58:24"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-06-04 14:58:35")
    },
    new EmployeeDto()
{
        Id = 110,
        FirstName = "Geoffrey",
        LastName = "Tidmarsh",
        Salary = 319690,
        Department = "Accounting",
        Position = "Occupational Therapist",
        HireDate = DateTime.Parse("2018-04-10 04:40:43"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-12-21 23:10:54")
    },
    new EmployeeDto()
{
        Id = 111,
        FirstName = "Engracia",
        LastName = "Crockford",
        Salary = 421929,
        Department = "Support",
        Position = "Civil Engineer",
        HireDate = DateTime.Parse("2018-01-05 12:22:12"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-05-17 04:59:12")
    },
    new EmployeeDto()
{
        Id = 112,
        FirstName = "Hilton",
        LastName = "Folbig",
        Salary = 248231,
        Department = "Training",
        Position = "Associate Professor",
        HireDate = DateTime.Parse("2016-04-05 00:54:00"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-10-27 17:14:23")
    },
    new EmployeeDto()
{
        Id = 113,
        FirstName = "Cirillo",
        LastName = "Conroy",
        Salary = 88823,
        Department = "Accounting",
        Position = "VP Sales",
        HireDate = DateTime.Parse("2023-02-17 22:20:44"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-05-21 09:21:02")
    },
    new EmployeeDto()
{
        Id = 114,
        FirstName = "Hobard",
        LastName = "Izon",
        Salary = 466196,
        Department = "Engineering",
        Position = "Automation Specialist IV",
        HireDate = DateTime.Parse("2021-09-30 14:10:09"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-09-07 11:43:53")
    },
    new EmployeeDto()
{
        Id = 115,
        FirstName = "Joelie",
        LastName = "Berre",
        Salary = 638990,
        Department = "Business Development",
        Position = "Budget/Accounting Analyst I",
        HireDate = DateTime.Parse("2020-06-15 23:19:14"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-12-21 11:02:55")
    },
    new EmployeeDto()
{
        Id = 116,
        FirstName = "Darrel",
        LastName = "Alcido",
        Salary = 423425,
        Department = "Business Development",
        Position = "Sales Representative",
        HireDate = DateTime.Parse("2021-06-05 09:22:58"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-07-13 02:19:36")
    },
    new EmployeeDto()
{
        Id = 117,
        FirstName = "Ramsay",
        LastName = "Aspray",
        Salary = 536566,
        Department = "Business Development",
        Position = "Senior Sales Associate",
        HireDate = DateTime.Parse("2024-08-06 09:10:49"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-01-26 12:13:39")
    },
    new EmployeeDto()
{
        Id = 118,
        FirstName = "Paolina",
        LastName = "Seagrove",
        Salary = 306872,
        Department = "Business Development",
        Position = "Programmer IV",
        HireDate = DateTime.Parse("2019-03-07 14:26:29"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-06-07 06:36:37")
    },
    new EmployeeDto()
{
        Id = 119,
        FirstName = "Benny",
        LastName = "Sawyers",
        Salary = 640395,
        Department = "Legal",
        Position = "Senior Developer",
        HireDate = DateTime.Parse("2023-02-10 21:56:08"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-03-29 09:14:26")
    },
    new EmployeeDto()
{
        Id = 120,
        FirstName = "Filippo",
        LastName = "Suatt",
        Salary = 578411,
        Department = "Accounting",
        Position = "Project Manager",
        HireDate = DateTime.Parse("2019-07-21 20:38:02"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-05-22 02:10:35")
    },
    new EmployeeDto()
{
        Id = 121,
        FirstName = "Filip",
        LastName = "Blackett",
        Salary = 252275,
        Department = "Accounting",
        Position = "Internal Auditor",
        HireDate = DateTime.Parse("2016-01-07 08:19:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-07-13 03:59:01")
    },
    new EmployeeDto()
{
        Id = 122,
        FirstName = "Omar",
        LastName = "Soares",
        Salary = 172647,
        Department = "Marketing",
        Position = "VP Quality Control",
        HireDate = DateTime.Parse("2018-12-22 20:17:06"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-07-01 22:09:16")
    },
    new EmployeeDto()
{
        Id = 123,
        FirstName = "Kristen",
        LastName = "Arnett",
        Salary = 694280,
        Department = "Human Resources",
        Position = "Software Consultant",
        HireDate = DateTime.Parse("2017-03-12 14:02:30"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-06-29 16:13:13")
    },
    new EmployeeDto()
{
        Id = 124,
        FirstName = "Ema",
        LastName = "Boal",
        Salary = 461501,
        Department = "Accounting",
        Position = "Administrative Assistant I",
        HireDate = DateTime.Parse("2021-05-22 05:34:48"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-06-18 07:42:56")
    },
    new EmployeeDto()
{
        Id = 125,
        FirstName = "Massimo",
        LastName = "Shovell",
        Salary = 725245,
        Department = "Product Management",
        Position = "Accounting Assistant I",
        HireDate = DateTime.Parse("2019-03-15 23:41:10"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-01-20 12:04:09")
    },
    new EmployeeDto()
{
        Id = 126,
        FirstName = "Urbain",
        LastName = "Izard",
        Salary = 62780,
        Department = "Support",
        Position = "Information Systems Manager",
        HireDate = DateTime.Parse("2019-05-14 21:33:47"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-09-09 19:43:20")
    },
    new EmployeeDto()
{
        Id = 127,
        FirstName = "Elisa",
        LastName = "Rains",
        Salary = 286399,
        Department = "Product Management",
        Position = "Operator",
        HireDate = DateTime.Parse("2018-02-24 08:21:18"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-12-02 13:35:25")
    },
    new EmployeeDto()
{
        Id = 128,
        FirstName = "Matthiew",
        LastName = "Falkinder",
        Salary = 462436,
        Department = "Accounting",
        Position = "Executive Secretary",
        HireDate = DateTime.Parse("2021-09-29 16:18:22"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-03-27 10:58:46")
    },
    new EmployeeDto()
{
        Id = 129,
        FirstName = "Waring",
        LastName = "Pepperell",
        Salary = 272342,
        Department = "Business Development",
        Position = "Desktop Support Technician",
        HireDate = DateTime.Parse("2022-05-06 20:30:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-10-10 05:30:49")
    },
    new EmployeeDto()
{
        Id = 130,
        FirstName = "Faith",
        LastName = "Bull",
        Salary = 671479,
        Department = "Research and Development",
        Position = "Marketing Manager",
        HireDate = DateTime.Parse("2020-08-04 02:11:02"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-11-14 04:17:57")
    },
    new EmployeeDto()
{
        Id = 131,
        FirstName = "Allsun",
        LastName = "Strewthers",
        Salary = 341281,
        Department = "Services",
        Position = "Office Assistant II",
        HireDate = DateTime.Parse("2021-06-03 03:15:40"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-08-07 06:36:49")
    },
    new EmployeeDto()
{
        Id = 132,
        FirstName = "Lory",
        LastName = "Rosindill",
        Salary = 285596,
        Department = "Training",
        Position = "Health Coach I",
        HireDate = DateTime.Parse("2023-04-22 18:35:42"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-06-17 13:10:45")
    },
    new EmployeeDto()
{
        Id = 133,
        FirstName = "Obidiah",
        LastName = "Burdytt",
        Salary = 395789,
        Department = "Product Management",
        Position = "Quality Engineer",
        HireDate = DateTime.Parse("2022-02-28 15:18:24"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-06-15 10:34:30")
    },
    new EmployeeDto()
{
        Id = 134,
        FirstName = "Des",
        LastName = "Sperrett",
        Salary = 122904,
        Department = "Accounting",
        Position = "Help Desk Operator",
        HireDate = DateTime.Parse("2020-03-28 04:16:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-10-19 23:45:32")
    },
    new EmployeeDto()
{
        Id = 135,
        FirstName = "Carlin",
        LastName = "Leaver",
        Salary = 448944,
        Department = "Accounting",
        Position = "GIS Technical Architect",
        HireDate = DateTime.Parse("2015-07-05 06:05:31"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-06-22 18:23:01")
    },
    new EmployeeDto()
{
        Id = 136,
        FirstName = "Omar",
        LastName = "Pally",
        Salary = 290250,
        Department = "Business Development",
        Position = "Senior Developer",
        HireDate = DateTime.Parse("2017-01-22 22:10:24"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-09-11 22:32:11")
    },
    new EmployeeDto()
{
        Id = 137,
        FirstName = "Nettie",
        LastName = "Hellwig",
        Salary = 220751,
        Department = "Human Resources",
        Position = "Professor",
        HireDate = DateTime.Parse("2016-09-16 21:28:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-08-04 00:46:21")
    },
    new EmployeeDto()
{
        Id = 138,
        FirstName = "Georgy",
        LastName = "Sweeting",
        Salary = 192064,
        Department = "Accounting",
        Position = "Structural Analysis Engineer",
        HireDate = DateTime.Parse("2023-12-15 06:13:29"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-10-15 02:25:28")
    },
    new EmployeeDto()
{
        Id = 139,
        FirstName = "Drona",
        LastName = "Vaisey",
        Salary = 130422,
        Department = "Sales",
        Position = "Account Coordinator",
        HireDate = DateTime.Parse("2018-03-09 03:29:02"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-03-12 22:52:50")
    },
    new EmployeeDto()
{
        Id = 140,
        FirstName = "Artemus",
        LastName = "Labon",
        Salary = 330850,
        Department = "Research and Development",
        Position = "Administrative Assistant IV",
        HireDate = DateTime.Parse("2020-09-19 11:20:23"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-02-10 07:10:07")
    },
    new EmployeeDto()
{
        Id = 141,
        FirstName = "Alina",
        LastName = "Lodovichi",
        Salary = 195662,
        Department = "Marketing",
        Position = "Registered Nurse",
        HireDate = DateTime.Parse("2024-05-06 15:27:32"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-02-04 05:34:22")
    },
    new EmployeeDto()
{
        Id = 142,
        FirstName = "Roscoe",
        LastName = "Hoopper",
        Salary = 360419,
        Department = "Human Resources",
        Position = "Chemical Engineer",
        HireDate = DateTime.Parse("2016-08-31 03:02:21"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-01-26 17:18:45")
    },
    new EmployeeDto()
{
        Id = 143,
        FirstName = "Marlin",
        LastName = "Hearley",
        Salary = 521430,
        Department = "Sales",
        Position = "Help Desk Operator",
        HireDate = DateTime.Parse("2018-02-06 20:08:41"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-11-09 06:40:04")
    },
    new EmployeeDto()
{
        Id = 144,
        FirstName = "Gayle",
        LastName = "Talks",
        Salary = 320160,
        Department = "Accounting",
        Position = "Nuclear Power Engineer",
        HireDate = DateTime.Parse("2020-11-02 06:55:44"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-03-19 22:38:53")
    },
    new EmployeeDto()
{
        Id = 145,
        FirstName = "Alica",
        LastName = "Tayloe",
        Salary = 230734,
        Department = "Business Development",
        Position = "Physical Therapy Assistant",
        HireDate = DateTime.Parse("2020-05-27 14:35:46"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-03-05 15:20:27")
    },
    new EmployeeDto()
{
        Id = 146,
        FirstName = "Sergeant",
        LastName = "Vigietti",
        Salary = 266343,
        Department = "Marketing",
        Position = "Librarian",
        HireDate = DateTime.Parse("2016-02-20 07:40:30"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-07-25 11:05:10")
    },
    new EmployeeDto()
{
        Id = 147,
        FirstName = "Kendricks",
        LastName = "Edmunds",
        Salary = 650754,
        Department = "Human Resources",
        Position = "Executive Secretary",
        HireDate = DateTime.Parse("2019-08-11 14:19:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-07-15 23:59:11")
    },
    new EmployeeDto()
{
        Id = 148,
        FirstName = "Howie",
        LastName = "Upston",
        Salary = 119621,
        Department = "Sales",
        Position = "Community Outreach Specialist",
        HireDate = DateTime.Parse("2015-02-24 08:35:30"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-06-11 21:29:18")
    },
    new EmployeeDto()
{
        Id = 149,
        FirstName = "Dwight",
        LastName = "Gambie",
        Salary = 25106,
        Department = "Human Resources",
        Position = "Research Assistant II",
        HireDate = DateTime.Parse("2021-12-24 10:12:57"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("2000-05-07 16:22:52")
    },
    new EmployeeDto()
{
        Id = 150,
        FirstName = "Sacha",
        LastName = "Elders",
        Salary = 148359,
        Department = "Support",
        Position = "Information Systems Manager",
        HireDate = DateTime.Parse("2019-05-28 22:04:53"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-05-17 12:07:33")
    },
    new EmployeeDto()
{
        Id = 151,
        FirstName = "Andee",
        LastName = "Gibbonson",
        Salary = 184528,
        Department = "Marketing",
        Position = "Recruiter",
        HireDate = DateTime.Parse("2024-07-19 10:44:38"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-06-24 11:51:13")
    },
    new EmployeeDto()
{
        Id = 152,
        FirstName = "Helena",
        LastName = "Quickfall",
        Salary = 166036,
        Department = "Human Resources",
        Position = "Accountant II",
        HireDate = DateTime.Parse("2023-05-29 02:22:41"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-01-25 13:33:13")
    },
    new EmployeeDto()
{
        Id = 153,
        FirstName = "Janette",
        LastName = "Sherlock",
        Salary = 397586,
        Department = "Business Development",
        Position = "Staff Accountant I",
        HireDate = DateTime.Parse("2016-02-11 13:36:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-12-11 19:36:50")
    },
    new EmployeeDto()
{
        Id = 154,
        FirstName = "Sherwynd",
        LastName = "Hawgood",
        Salary = 556338,
        Department = "Accounting",
        Position = "Recruiting Manager",
        HireDate = DateTime.Parse("2022-08-30 01:29:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-10-11 09:09:31")
    },
    new EmployeeDto()
{
        Id = 155,
        FirstName = "Bastien",
        LastName = "Croser",
        Salary = 572273,
        Department = "Human Resources",
        Position = "Information Systems Manager",
        HireDate = DateTime.Parse("2018-01-02 20:14:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-09-13 13:13:07")
    },
    new EmployeeDto()
{
        Id = 156,
        FirstName = "Rutherford",
        LastName = "Furtado",
        Salary = 306731,
        Department = "Marketing",
        Position = "Geologist II",
        HireDate = DateTime.Parse("2024-03-14 09:20:04"),
        LastWorkingDate = DateTime.Parse("2031-08-06 13:51:41"),
        DateOfBirth = DateTime.Parse("1998-05-27 15:20:37")
    },
    new EmployeeDto()
{
        Id = 157,
        FirstName = "Gwendolen",
        LastName = "Swatman",
        Salary = 589698,
        Department = "Sales",
        Position = "Junior Executive",
        HireDate = DateTime.Parse("2015-07-05 17:56:45"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-09-26 06:33:13")
    },
    new EmployeeDto()
{
        Id = 158,
        FirstName = "Camel",
        LastName = "Stradling",
        Salary = 79370,
        Department = "Accounting",
        Position = "Human Resources Assistant II",
        HireDate = DateTime.Parse("2015-03-11 17:01:07"),
        LastWorkingDate = DateTime.Parse("2020-12-17 21:44:08"),
        DateOfBirth = DateTime.Parse("1995-01-07 19:49:00")
    },
    new EmployeeDto()
{
        Id = 159,
        FirstName = "Leisha",
        LastName = "Janosevic",
        Salary = 699744,
        Department = "Support",
        Position = "Geologist IV",
        HireDate = DateTime.Parse("2022-09-28 01:07:04"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-05-16 00:05:11")
    },
    new EmployeeDto()
{
        Id = 160,
        FirstName = "Yetta",
        LastName = "Mazillius",
        Salary = 365947,
        Department = "Accounting",
        Position = "VP Quality Control",
        HireDate = DateTime.Parse("2020-11-17 02:33:59"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-02-11 04:51:39")
    },
    new EmployeeDto()
{
        Id = 161,
        FirstName = "Cherilyn",
        LastName = "Danbury",
        Salary = 226762,
        Department = "Product Management",
        Position = "Analyst Programmer",
        HireDate = DateTime.Parse("2015-07-17 02:30:36"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-07-20 17:29:04")
    },
    new EmployeeDto()
{
        Id = 162,
        FirstName = "Marna",
        LastName = "Roskam",
        Salary = 78983,
        Department = "Support",
        Position = "Nuclear Power Engineer",
        HireDate = DateTime.Parse("2016-04-03 02:44:00"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-01-19 09:41:01")
    },
    new EmployeeDto()
{
        Id = 163,
        FirstName = "Ginni",
        LastName = "Hagger",
        Salary = 101348,
        Department = "Marketing",
        Position = "Professor",
        HireDate = DateTime.Parse("2024-03-03 02:15:31"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-10-09 23:54:13")
    },
    new EmployeeDto()
{
        Id = 164,
        FirstName = "Ashlee",
        LastName = "Trowl",
        Salary = 646030,
        Department = "Product Management",
        Position = "Human Resources Assistant II",
        HireDate = DateTime.Parse("2021-07-02 16:55:41"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-11-26 11:02:48")
    },
    new EmployeeDto()
{
        Id = 165,
        FirstName = "Newton",
        LastName = "Keach",
        Salary = 572021,
        Department = "Services",
        Position = "Research Assistant IV",
        HireDate = DateTime.Parse("2015-02-14 14:09:34"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("2000-05-22 02:37:07")
    },
    new EmployeeDto()
{
        Id = 166,
        FirstName = "Mord",
        LastName = "Thirsk",
        Salary = 555292,
        Department = "Business Development",
        Position = "Project Manager",
        HireDate = DateTime.Parse("2022-04-28 17:20:48"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-08-25 14:20:16")
    },
    new EmployeeDto()
{
        Id = 167,
        FirstName = "Gregoire",
        LastName = "Sharphurst",
        Salary = 452455,
        Department = "Engineering",
        Position = "Geologist III",
        HireDate = DateTime.Parse("2018-10-21 06:23:30"),
        LastWorkingDate = DateTime.Parse("2025-10-15 13:59:52"),
        DateOfBirth = DateTime.Parse("1994-06-05 06:19:07")
    },
    new EmployeeDto()
{
        Id = 168,
        FirstName = "Aguie",
        LastName = "Mostin",
        Salary = 89286,
        Department = "Engineering",
        Position = "Librarian",
        HireDate = DateTime.Parse("2022-07-24 16:12:55"),
        LastWorkingDate = DateTime.Parse("2034-08-05 08:39:07"),
        DateOfBirth = DateTime.Parse("1991-09-04 01:55:29")
    },
    new EmployeeDto()
{
        Id = 169,
        FirstName = "Vinnie",
        LastName = "Duffil",
        Salary = 640288,
        Department = "Research and Development",
        Position = "Staff Scientist",
        HireDate = DateTime.Parse("2023-08-16 05:49:45"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-05-13 18:27:55")
    },
    new EmployeeDto()
{
        Id = 170,
        FirstName = "Frazer",
        LastName = "Manzell",
        Salary = 438374,
        Department = "Services",
        Position = "Biostatistician I",
        HireDate = DateTime.Parse("2015-11-11 21:44:39"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-09-18 02:39:53")
    },
    new EmployeeDto()
{
        Id = 171,
        FirstName = "Adora",
        LastName = "Briers",
        Salary = 332880,
        Department = "Product Management",
        Position = "Accountant II",
        HireDate = DateTime.Parse("2020-10-14 15:48:18"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-03-13 12:48:05")
    },
    new EmployeeDto()
{
        Id = 172,
        FirstName = "Johnath",
        LastName = "Ludewig",
        Salary = 178759,
        Department = "Human Resources",
        Position = "Physical Therapy Assistant",
        HireDate = DateTime.Parse("2015-07-19 05:37:05"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-06-26 12:22:11")
    },
    new EmployeeDto()
{
        Id = 173,
        FirstName = "Isa",
        LastName = "Balcon",
        Salary = 57569,
        Department = "Marketing",
        Position = "VP Product Management",
        HireDate = DateTime.Parse("2023-01-09 00:03:01"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-08-26 04:01:25")
    },
    new EmployeeDto()
{
        Id = 174,
        FirstName = "Nalani",
        LastName = "Spark",
        Salary = 487787,
        Department = "Human Resources",
        Position = "Administrative Assistant III",
        HireDate = DateTime.Parse("2024-04-24 12:54:23"),
        LastWorkingDate = DateTime.Parse("2025-10-07 10:35:07"),
        DateOfBirth = DateTime.Parse("1990-04-08 11:25:09")
    },
    new EmployeeDto()
{
        Id = 175,
        FirstName = "Giorgi",
        LastName = "Curl",
        Salary = 146582,
        Department = "Human Resources",
        Position = "Systems Administrator I",
        HireDate = DateTime.Parse("2020-05-05 08:18:23"),
        LastWorkingDate = DateTime.Parse("2026-12-02 10:11:58"),
        DateOfBirth = DateTime.Parse("1987-11-18 11:17:32")
    },
    new EmployeeDto()
{
        Id = 176,
        FirstName = "Keefer",
        LastName = "Aitchison",
        Salary = 562734,
        Department = "Marketing",
        Position = "Geological Engineer",
        HireDate = DateTime.Parse("2016-09-07 03:48:07"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-11-15 16:20:03")
    },
    new EmployeeDto()
{
        Id = 177,
        FirstName = "Daryle",
        LastName = "Barden",
        Salary = 768498,
        Department = "Engineering",
        Position = "Account Coordinator",
        HireDate = DateTime.Parse("2016-08-06 17:24:35"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-09-15 01:24:49")
    },
    new EmployeeDto()
{
        Id = 178,
        FirstName = "Arther",
        LastName = "Grover",
        Salary = 604150,
        Department = "Accounting",
        Position = "Geological Engineer",
        HireDate = DateTime.Parse("2017-11-03 17:39:37"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-01-22 19:03:29")
    },
    new EmployeeDto()
{
        Id = 179,
        FirstName = "Elayne",
        LastName = "Nealon",
        Salary = 27020,
        Department = "Training",
        Position = "Financial Analyst",
        HireDate = DateTime.Parse("2023-04-26 02:17:18"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-11-17 15:00:38")
    },
    new EmployeeDto()
{
        Id = 180,
        FirstName = "Archy",
        LastName = "Cossey",
        Salary = 434172,
        Department = "Training",
        Position = "Account Coordinator",
        HireDate = DateTime.Parse("2024-03-08 10:56:51"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-12-02 09:23:21")
    },
    new EmployeeDto()
{
        Id = 181,
        FirstName = "Brendin",
        LastName = "Seagar",
        Salary = 232503,
        Department = "Research and Development",
        Position = "Assistant Manager",
        HireDate = DateTime.Parse("2024-02-29 08:58:33"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1993-04-01 18:30:40")
    },
    new EmployeeDto()
{
        Id = 182,
        FirstName = "Marthe",
        LastName = "McRamsey",
        Salary = 197174,
        Department = "Services",
        Position = "Financial Advisor",
        HireDate = DateTime.Parse("2022-09-03 22:14:40"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-03-13 16:35:25")
    },
    new EmployeeDto()
{
        Id = 183,
        FirstName = "Ferd",
        LastName = "Bryns",
        Salary = 191713,
        Department = "Engineering",
        Position = "Project Manager",
        HireDate = DateTime.Parse("2015-03-12 13:49:30"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-10-11 04:40:43")
    },
    new EmployeeDto()
{
        Id = 184,
        FirstName = "Noble",
        LastName = "Danilovitch",
        Salary = 26216,
        Department = "Business Development",
        Position = "Assistant Professor",
        HireDate = DateTime.Parse("2015-12-24 15:04:08"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1986-11-24 17:43:26")
    },
    new EmployeeDto()
{
        Id = 185,
        FirstName = "Legra",
        LastName = "Kidwell",
        Salary = 264111,
        Department = "Marketing",
        Position = "Senior Developer",
        HireDate = DateTime.Parse("2016-10-07 00:48:56"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1988-02-16 07:59:16")
    },
    new EmployeeDto()
{
        Id = 186,
        FirstName = "Joye",
        LastName = "Razzell",
        Salary = 92674,
        Department = "Accounting",
        Position = "Human Resources Manager",
        HireDate = DateTime.Parse("2016-01-13 18:26:06"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1998-11-23 20:24:33")
    },
    new EmployeeDto()
{
        Id = 187,
        FirstName = "Lacee",
        LastName = "Simmank",
        Salary = 301243,
        Department = "Training",
        Position = "Senior Developer",
        HireDate = DateTime.Parse("2015-02-13 21:01:23"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-05-08 19:57:42")
    },
    new EmployeeDto()
{
        Id = 188,
        FirstName = "Puff",
        LastName = "Nafzger",
        Salary = 702505,
        Department = "Services",
        Position = "Senior Financial Analyst",
        HireDate = DateTime.Parse("2022-07-05 03:20:13"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1991-01-21 11:39:17")
    },
    new EmployeeDto()
{
        Id = 189,
        FirstName = "Oralla",
        LastName = "Fantone",
        Salary = 201796,
        Department = "Marketing",
        Position = "Accounting Assistant IV",
        HireDate = DateTime.Parse("2019-04-03 09:49:05"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1996-04-11 00:31:31")
    },
    new EmployeeDto()
{
        Id = 190,
        FirstName = "Reed",
        LastName = "Cuncliffe",
        Salary = 514309,
        Department = "Marketing",
        Position = "Office Assistant IV",
        HireDate = DateTime.Parse("2017-04-13 06:19:35"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-07-25 08:59:37")
    },
    new EmployeeDto()
{
        Id = 191,
        FirstName = "Redford",
        LastName = "Bicker",
        Salary = 501691,
        Department = "Legal",
        Position = "Chief Design Engineer",
        HireDate = DateTime.Parse("2015-01-01 02:36:17"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-11-09 23:25:19")
    },
    new EmployeeDto()
{
        Id = 192,
        FirstName = "Loria",
        LastName = "McGloughlin",
        Salary = 676168,
        Department = "Product Management",
        Position = "Social Worker",
        HireDate = DateTime.Parse("2016-10-29 22:09:04"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1987-10-08 05:10:50")
    },
    new EmployeeDto()
{
        Id = 193,
        FirstName = "Meggie",
        LastName = "Tomsen",
        Salary = 662538,
        Department = "Training",
        Position = "Statistician IV",
        HireDate = DateTime.Parse("2019-09-13 15:03:15"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1990-01-19 02:10:53")
    },
    new EmployeeDto()
{
        Id = 194,
        FirstName = "Brook",
        LastName = "Aimer",
        Salary = 606254,
        Department = "Services",
        Position = "Sales Representative",
        HireDate = DateTime.Parse("2015-07-08 19:47:24"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-06-02 00:04:47")
    },
    new EmployeeDto()
{
        Id = 195,
        FirstName = "Kyle",
        LastName = "Issacoff",
        Salary = 269274,
        Department = "Accounting",
        Position = "Project Manager",
        HireDate = DateTime.Parse("2017-10-20 06:16:01"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1994-07-23 02:52:57")
    },
    new EmployeeDto()
{
        Id = 196,
        FirstName = "Marlo",
        LastName = "Henze",
        Salary = 392860,
        Department = "Services",
        Position = "Legal Assistant",
        HireDate = DateTime.Parse("2017-07-15 16:49:11"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1989-09-04 01:53:07")
    },
    new EmployeeDto()
{
        Id = 197,
        FirstName = "Beatrisa",
        LastName = "Kingsbury",
        Salary = 339495,
        Department = "Support",
        Position = "Nurse Practicioner",
        HireDate = DateTime.Parse("2017-11-19 17:55:37"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1999-12-19 06:15:12")
    },
    new EmployeeDto()
{
        Id = 198,
        FirstName = "Lazarus",
        LastName = "Daingerfield",
        Salary = 435134,
        Department = "Training",
        Position = "Account Coordinator",
        HireDate = DateTime.Parse("2021-05-14 21:14:46"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1995-05-23 22:56:38")
    },
    new EmployeeDto()
{
        Id = 199,
        FirstName = "Carri",
        LastName = "Johnson",
        Salary = 263605,
        Department = "Research and Development",
        Position = "Quality Control Specialist",
        HireDate = DateTime.Parse("2021-08-03 11:13:25"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1992-10-09 03:04:59")
    },
    new EmployeeDto()
{
        Id = 200,
        FirstName = "Arlena",
        LastName = "Copestake",
        Salary = 156577,
        Department = "Legal",
        Position = "Director of Sales",
        HireDate = DateTime.Parse("2020-10-24 08:44:37"),
        LastWorkingDate = null,
        DateOfBirth = DateTime.Parse("1997-01-06 10:06:58")
    }

           };
        }
    }

}
