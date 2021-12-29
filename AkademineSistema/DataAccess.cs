using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace AkademineSistema
{
    public class DataAccess
    {
        public List<GradeClass> StudentGetGrades(int idSubject, int idStudent)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<GradeClass>("dbo.spStudentGetGrades @ID, @StudentID", new { ID = idSubject, StudentID = idStudent }).ToList();
                return output;
            }
        }
        public List<SubjectClass> StudentGetSubject (int idGroup)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<SubjectClass>("dbo.spStudentGetSubject @ID", new { ID = idGroup }).ToList();
                return output;
            }
        }
        public void AddGrade(string gradeSource, string gradeDate, int grade, int studentID, int subjectID, int lectorID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<SubjectClass>("dbo.spAddGrade @GradeSource, @GradeDate, @Grade, @StudentID, @SubjectID, @LectorID", new {
                    GradeSource = gradeSource,
                    GradeDate = gradeDate,
                    Grade = grade,
                    StudentID = studentID,
                    SubjectID= subjectID,
                    LectorID = lectorID});
            }
        }
        public List<GradeClass> GetStudentGrades(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<GradeClass>("dbo.spGetStudentGrades @ID", new { ID = id }).ToList();
                return output;
            }
        }
        public List<GroupClass> GetGroupSubject(int idSubject)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<GroupClass>("dbo.spGetGroupSubjects @ID", new { ID = idSubject }).ToList();
                return output;
            }
        }
        public List<SubjectClass> GetAllSubjects(int idLector)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<SubjectClass>("dbo.spGetSubjects @ID", new { ID = idLector }).ToList();
                return output;
            }
        }
        public void AssignSubjectGroup(int idGroup, int idSubject)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<SubjectClass>("dbo.spAssignSubjectGroup @ID, @Subject", new { ID = idGroup, Subject = idSubject });
            }
        }
        public void AssignSubjectLector(int idLector, int idSubject )
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<SubjectClass>("dbo.spAssignSubjectLector @ID, @Subject", new { ID = idLector, Subject = idSubject });
            }
        }
        public void CreateSubject(string name, int admID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<SubjectClass>("dbo.spCreateSubject @Name, @AdminID", new { Name = name, AdminID=admID });
            }
        }
        public void DeleteSubject(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<SubjectClass>("dbo.spDeleteSubject @Id", new { Id = id });
            }
        }
        public List<SubjectClass> GetSubjectByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<SubjectClass>("dbo.spSubjectGetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }
        public List<SubjectClass> GetAllSubjects()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<SubjectClass>("dbo.spSubjectsGetAll").ToList();
                return output;
            }
        }

        public List<GroupClass> GetGroupByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<GroupClass>("dbo.spGroupGetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }
        public void DeleteGrade (int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<GradeClass>("dbo.spDeleteGrade @Id", new { Id = id });
            }
        }
        public void DeleteGroup(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<GroupClass>("dbo.spDeleteGroup @Id", new { Id = id });
            }
        }
        public void CreateGroup(string name, int admID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<GroupClass>("dbo.spCreateGroup @Name, @AdminID", new { Name = name, AdminID=admID });
            }
        }
        public List<GroupClass> GetAllGroups()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<GroupClass>("dbo.spGroupGetAll").ToList();
                return output;
            }
        }
        public void AddStudentToGroup(int id, int group)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<StudentClass>("dbo.spStudentAddGroup @ID, @Group", new { ID = id, Group = group });
            }
        }
        public void CreateStudent (string name, string surname, int admID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<StudentClass>("dbo.spCreateStudent @Name, @Surname, @AdminID", new { Name = name, Surname = surname, AdminID=admID });
            }
        }
        public void DeleteStudent (int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<StudentClass>("dbo.spDeleteStudent @Id", new { Id = id });
            }
        }
        public List<StudentClass> GetStudentsByGroup(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<StudentClass>("dbo.spStudentsGetByGroup @ID", new { ID = id }).ToList();
                return output;
            }
        }
        public List<StudentClass> GetStudentById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<StudentClass>("dbo.spStudentGetById @ID", new { ID = id }).ToList();
                return output;
            }
        }
        public List<StudentClass> GetStudentsByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<StudentClass>("dbo.spStudentsGetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }
        public List<StudentClass> GetStudentBySurname(string surname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<StudentClass>("dbo.spStudentGetBySurname @Surname", new { Surname = surname }).ToList();
                return output;
            }
        }
        public List<StudentClass> GetAllStudents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<StudentClass>("dbo.StudentsGetAll").ToList();
                return output;
            }
        }
        public List<AdminClass> GetAllAdmins()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<AdminClass>("dbo.spAdminGetAll").ToList();
                return output;
            }
        }
        public List<AdminClass> GetAdminByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<AdminClass>("dbo.spAdminGetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }
        public List<AdminClass> GetAdminBySurname(string surname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<AdminClass>("dbo.spAdminGetBySurname @Surname", new { Surname = surname }).ToList();
                return output;
            }
        }
        public List<LectorClass> GetAllLectors()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<LectorClass>("dbo.spLectorGetAll").ToList();
                return output;
            }
        }
        public List<LectorClass> GetLectorByName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<LectorClass>("dbo.spLectorGetByName @Name", new { Name = name }).ToList();
                return output;
            }
        }
        public List<LectorClass> GetLectorBySurname(string surname)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<LectorClass>("dbo.spLectorGetBySurname @Surname", new { Surname = surname }).ToList();
                return output;
            }
        }
        public void DeleteLector(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                var output = connection.Query<LectorClass>("dbo.spDeleteLector @ID", new { ID = id });
            }
        }
        public void CreateLector(string name, string surname, int admID)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("AcademicSystemDB")))
            {
                connection.Query<StudentClass>("dbo.spCreateLector @Name, @Surname, @AdminId", new { Name = name, Surname = surname, AdminID = admID });
            }
        }
    }
}
