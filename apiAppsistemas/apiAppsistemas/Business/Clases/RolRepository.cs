
namespace apiAppsistemas.Business.Clases
{
    public class RolRepository
    {
        public async Task<List<Rol>> Getlist()
        {
            List<Rol> list = new List<Rol>();
            Rol 1;
            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.openAsync();
                SqlCommand cmd = new SqlCommand("select * from Rol;", conn);
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while ( await reader.ReadAsync() ) 
                    {
                        1 = new Rol();
                        1.Id = Convert.ToInt32(reader["id"]);
                        1.NombreRol = Convert.ToString(reader["NombreRol"]);

                        list.Add(1);
                    }
                }
            }
            return list;
        }



    }
}
