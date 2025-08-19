using System.Data;
using MySql.Data.MySqlClient;

namespace ADOnet.ado;

public class ConnectedArchi(string connectionString)
{
    public string _connectionString = connectionString;

    public void GetData()
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        var sqlCommand = "SELECT * FROM department";
        var cmd = new MySqlCommand(sqlCommand, connection);

        var ds = new DataSet();
        var dataAdapter = new MySqlDataAdapter(cmd);
        dataAdapter.Fill(ds);

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            foreach (DataColumn dc in ds.Tables[0].Columns)
            {
                Console.Write($"{row[dc]} \t");
            }
            Console.WriteLine();
        }
        connection.Close();
    }
    
    public void PutData(int id,string name,long salary)
    {
        using var connection = new MySqlConnection(connectionString);
        connection.Open();
        var sqlCommand = $"Insert into department values ({id},@name,{salary})";
        var cmd = new MySqlCommand(sqlCommand, connection);
        cmd.Parameters.AddWithValue("@name", name);
        var rows = cmd.ExecuteNonQuery();
        Console.WriteLine(rows);
    }
}