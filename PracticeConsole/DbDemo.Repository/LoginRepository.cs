using DbDemo.Model;
using DbDemo.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbDemo.Repository
{
    public class LoginRepository
    {
        public static void Authenticated(LoginUser loginUser)
        {
                string connectionString = DBConfiguration.ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_CheckIsUserCredentialsCorrect3", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 50).Value = loginUser.UserName;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar, 50).Value = loginUser.Password;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar, 50).Value = loginUser.Role;

                        cmd.Parameters.Add("@IsCredentialsCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@IsUserNameCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@IsPasswordCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@IsRoleCorrect", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        conn.Open();

                        cmd.ExecuteNonQuery();

                        loginUser.AreCredentialsCorrect = (bool)cmd.Parameters["@IsCredentialsCorrect"].Value;
                        loginUser.IsUserNameCorrect = (bool)cmd.Parameters["@IsUserNameCorrect"].Value;
                        loginUser.IsPasswordCorrect = (bool)cmd.Parameters["@IsPasswordCorrect"].Value;
                        loginUser.IsRoleCorrect = (bool)cmd.Parameters["@IsRoleCorrect"].Value;
                    }
                }
        }

        public static void GetAllRoles(System.Collections.Generic.List<UserRole> userRole)
        {
                string connectionString = DBConfiguration.ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_GetAllRoles", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            userRole.Add(new UserRole()
                            {
                                RoleDescription = (string)reader[1]
                            });
                            }
                        }
                    }
                }
        }
    }
}
