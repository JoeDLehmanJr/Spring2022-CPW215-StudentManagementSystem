#nullable disable
using System.Data.SqlClient;
namespace StudentManagementSystem
{
    static class StudentDb
    {
        /// <summary>
        /// Adds a student to the database
        /// </summary>
        /// <param name="s">The student to be added</param>
        public static void add(Student s)
        {
            SqlConnection con = GetDatabaseConnection();

            // Prepare insert statement
            SqlCommand insertCmd = new();
            insertCmd.Connection = con;

            // Parameterized query
            insertCmd.CommandText = "Insert Into Student( FName, LName, DateOfBirth)" +
                "Values (@FName, @LName, @DateOfBirth)";
            insertCmd.Parameters.AddWithValue("@FName", s.FirstName);
            insertCmd.Parameters.AddWithValue("@LName", s.LastName);
            insertCmd.Parameters.AddWithValue("@DateOfBirth", s.DateOfBirth);

            // Open connection to the database
            con.Open();

            // Execute insert query
            insertCmd.ExecuteNonQuery();

            // Close connection to the database
            con.Close();
        }

        private static SqlConnection GetDatabaseConnection()
        {
            // Establish connection to database
            return new SqlConnection("Data Source = localhost; Initial Catalog = SMS; Integrated Security = True");
        }

        /// <summary>
        /// Gets a list of all students ordered by last name in 
        /// ascending order
        /// </summary>
        /// <returns>List of students sorted by last name</returns>
        public static List<Student> GetAllStudents() 
        { 
             // Get Connection
             SqlConnection con = GetDatabaseConnection();

            // Prepare the query
            SqlCommand selCmd = new();
            selCmd.Connection = con;
            selCmd.CommandText = "Select StudentId,FName, LName, DateOfBirth" +
                "  From Student Order By LName";
            con.Open();
            // Execute the query and use results
            SqlDataReader reader = selCmd.ExecuteReader();

            List<Student> students = new List<Student>();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["StudentId"]);
                string FName = reader["FName"].ToString();
                string LName = reader["LName"].ToString();
                DateTime dob = Convert.ToDateTime(reader["DateOfBirth"]);

                Student tempStu = new(FName, LName, dob);
                tempStu.StudentId = id;

                students.Add(tempStu);

            }
            // Close connection
            con.Close();

            // Return list of students
            return students;
        }

        public static void Update(Student s) 
        { 
            throw new NotImplementedException(); 
        }

        /// <summary>
        /// Deletes a student
        /// </summary>
        /// <param name="s">The student to be deleted</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the student does not exist.</exception>
        public static void Delete(Student s) 
        { 
            if (s.StudentId == 0)
            {
                throw new ArgumentException("The StudentId must be populated.");
            }
            Delete(s.StudentId); 
        }

        /// <summary>
        /// Deletes a student by the StudentId number
        /// </summary>
        /// <param name="id">The SWtudentId of the student to be deleted.</param>
        /// <exception cref="SqlException">Thrown for SQL problems</exception>
        /// <exception cref="ArgumentException">Thrown if the student does not exist.</exception>
        public static void Delete(int id)
        {
            // Get Connection
            using SqlConnection con = GetDatabaseConnection();

            // Prepare the query
            SqlCommand deleteCmd = new();
            deleteCmd.Connection = con;
            deleteCmd.CommandText = "Delete From Student Where StudentId = @id";

            // Setup parameters
            deleteCmd.Parameters.AddWithValue("@id", id);

            // Open database connection
            con.Open();

            // Execute the query
            int rows = deleteCmd.ExecuteNonQuery();

            // Make sure the query was successful in its deletion
            if (rows == 0)
            {
                throw new ArgumentException("A student with that id does not exist.");
            } 
        }

        public static Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}