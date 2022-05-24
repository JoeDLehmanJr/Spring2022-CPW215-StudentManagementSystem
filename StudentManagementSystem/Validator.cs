
namespace StudentManagementSystem
{
    /// <summary>
    /// Helper class to validate Windows Forms controls and data.
    /// </summary>
    static class Validator
    {
        /// <summary>
        /// Checks if the TextBox Text property has a non-empty, non-whitespace string.
        /// </summary>
        /// <param name="box">The textbox to validate.</param>
        /// <returns>True if textbox contains non-whitespace data.</returns>
        public static bool IsPresent(TextBox box)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                return false;
            }
            return true; 
        }

        /// <summary>
        /// Checks string to ensure it is in a valid datetime format.
        /// </summary>
        /// <param name="dateString">The string to validate.</param>
        /// <returns>True if <paramref name="dateString"/> is a valid datetime</returns>
        public static bool IsValidDate(string dateString)
        {
            // The "_" is the dicard variable. Meaning we are ignoring the returned variable.
            if (DateTime.TryParse(dateString, out _)) 
            { 
                return true; 
            }
            return false;
        }
    }
}
