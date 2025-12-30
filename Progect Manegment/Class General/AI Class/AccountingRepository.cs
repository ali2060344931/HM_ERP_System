using System;
using System.Data.SqlClient;

public class AccountingRepository
{
    private readonly string _connectionString;

    public AccountingRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public decimal GetTopDebtorAmount()
    {
         var con = new SqlConnection(_connectionString);
        con.Open();

        var cmd = new SqlCommand(@"
            SELECT TOP 1 SUM(Amount) AS Total
            FROM CustomerDebts
            GROUP BY CustomerId
            ORDER BY Total DESC
        ", con);

        return (decimal)(cmd.ExecuteScalar() ?? 0);
    }

    public decimal GetMonthlySales(DateTime from, DateTime to)
    {
         var con = new SqlConnection(_connectionString);
        con.Open();

        var cmd = new SqlCommand(@"
            SELECT SUM(Amount)
            FROM Sales
            WHERE SaleDate BETWEEN @from AND @to
        ", con);

        cmd.Parameters.AddWithValue("@from", from);
        cmd.Parameters.AddWithValue("@to", to);

        return (decimal)(cmd.ExecuteScalar() ?? 0);
    }
}
