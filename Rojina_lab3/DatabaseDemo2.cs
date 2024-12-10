using System;
using MySql.Data.MySqlClient;

namespace PKMC2078Unit4
{
    internal class DatabaseDemo2
    {
        // Method to edit/update a student's information in the database
        public void EditStudent()
        {
            try
            {
                // Get the student's ID for which data needs to be updated
                Console.WriteLine("Enter Student ID to update:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new Name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter new Roll:");
                int roll = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter new Semester:");
                int semester = int.Parse(Console.ReadLine());

                // Establish the connection
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=");
                conn.Open();

                // SQL Update query to modify the student's details
                MySqlCommand cmd = new MySqlCommand("UPDATE students SET name = @n, roll = @r, semester = @s WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@r", roll);
                cmd.Parameters.AddWithValue("@s", semester);
                cmd.Parameters.AddWithValue("@id", id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Update success");
                }
                else
                {
                    Console.WriteLine("Update failed. Student not found.");
                }

                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to delete a student from the database
        public void DeleteStudent()
        {
            try
            {
                // Get the student's ID to be deleted
                Console.WriteLine("Enter Student ID to delete:");
                int id = int.Parse(Console.ReadLine());

                // Establish the connection
                MySqlConnection conn = new MySqlConnection("SERVER=localhost;DATABASE=dotnetunit4;UID=root;PASSWORD=");
                conn.Open();

                // SQL Delete query to remove the student
                MySqlCommand cmd = new MySqlCommand("DELETE FROM students WHERE id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Delete success");
                }
                else
                {
                    Console.WriteLine("Delete failed. Student not found.");
                }

                conn.Close();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Database error: " + mex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        /*static void Main(string[] args)
        {
            int option;
            Console.WriteLine("Select Option: \n 1. Edit Student \t 2. Delete Student");
            option = int.Parse(Console.ReadLine());

            DatabaseDemo2 demo = new DatabaseDemo2();
            switch (option)
            {
                case 1:
                    demo.EditStudent();
                    break;
                case 2:
                    demo.DeleteStudent();
                    break;
                default:
                    Console.WriteLine("Invalid option selected.");
                    break;
            }

            Console.ReadKey();
        }*/
    }
}
