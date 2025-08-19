using System.Data;
using MySql.Data.MySqlClient;

namespace ADOnet.ado;

public class DisconnectedArchi(string connectionString)
{
    private string _connectionString{
        get;
        set;
    } = connectionString;

    public void PutData_(int id, string name, long salary)
    {
        using var connection = new MySqlConnection(_connectionString);
        const string sql = $"SELECT * FROM department";
        var adapter = new MySqlDataAdapter(sql, connection);
        var commandBuilder = new MySqlCommandBuilder(adapter);
        var dataTable = new DataTable();
        adapter.Fill(dataTable); 
        DataRow newRow = dataTable.NewRow();
        newRow["id"] = id;
        newRow["name"] = name;
        newRow["salary"] = salary;
        dataTable.Rows.Add(newRow); 
        adapter.Update(dataTable);
        Console.WriteLine("Showing the class Department.");
    }

}