using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace _18042022Task
{
    class InsertCourse
    {
        public static void InsertCoursee()
        {
            string connectionstring = @"Server=215-12;Database=CodeAcademy;Trusted_Connection=True";
            Console.WriteLine("Name daxil edin:");
            string name = Console.ReadLine();
            Console.WriteLine("Description daxil edin:");
            string description = Console.ReadLine();
            Console.WriteLine("Price daxil edin:");
            int price = Convert.ToInt32(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(connectionstring))
            {

                
                con.Open();
                string query2 = $"Insert Into Course (Name,Description,Price) Values ('{name}','{description}',{price})";
                using (SqlCommand cmd1= new SqlCommand(query2, con))
                {
                   
                  
                    var result=cmd1.ExecuteNonQuery();
                    Console.WriteLine(result+" rows accepted");
                   
                }
             
               
            }
            
        }
    }
}
