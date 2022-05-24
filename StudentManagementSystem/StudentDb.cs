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
            // Establish connection to database
            SqlConnection con = 
                new SqlConnection("Data Source = localhost; Initial Catalog = SMS; Integrated Security = True");

            // Prepare insert statement
            SqlCommand insertCmd = new SqlCommand();
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

        public static List<Student> GetAllStudents() 
        { 
             
        }

        public static void Update(Student s) 
        { 
            throw new NotImplementedException(); 
        }

        public static void Delete(Student s) 
        { 
            throw new NotImplementedException(); 
        }

        public static void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public static Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
