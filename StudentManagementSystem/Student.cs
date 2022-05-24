#nullable disable
namespace StudentManagementSystem
{
    /// <summary>
    /// Represents a college student
    /// </summary>
    class Student
    {
        // Fully implemented C# property
        private int _studentId;

        /// <summary>
        /// Creates a student with the provided name and date of birth.
        /// </summary>
        /// <param name="fName">The students legal first name.</param>
        /// <param name="lName">The students legal last name.</param>
        /// <param name="DateOfBirth">The students date of birth.</param>
        public Student(string fName, string lName, DateTime DateOfBirth)
        {
            FirstName = fName;
            LastName = lName;
            this.DateOfBirth = DateOfBirth;
        }

        /// <summary>
        /// The student unique ID number.
        /// </summary>
        public int StudentId 
        { 
            get { return _studentId; } 
            set { _studentId = value; } 
        }

        // Auto implemented property
        /// <summary>
        /// The students legal first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The students legal last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Students first and last name, formatted as LastName + ", " + FirstName.
        /// e.g. Lehman, Joseph
        /// </summary>
        public string FullName 
        {
            get 
            {
                return LastName + ", " + FirstName;
            } 
             
        }

        /// <summary>
        /// The students date of birth. 
        /// Time is ignored.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        public byte GetAge()
        {
            int yearBorn = DateOfBirth.Year;
            int currentYear = DateTime.Now.Year;

            return (byte) (currentYear - yearBorn);
        }
    }
}
