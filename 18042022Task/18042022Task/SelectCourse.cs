using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _18042022Task
{
    class SelectCourse
    {
        public static void SelectCoursee()
        {
            string connectionstring = @"Server=215-12;Database=CodeAcademy;Trusted_Connection=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Select *from Course";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        int id = dataReader.GetInt32(0);
                        string name = dataReader.GetString(1);
                        string description = dataReader.GetString(2);
                        int price = dataReader.GetInt32(3);
                        Course course = new Course()
                        {
                            ID = id,
                            Name = name,
                            Description = description,
                            Price = price
                        };
                        course.ShowInfo();
                    }
                    dataReader.Close();
                }

            }
        }
    }
}
