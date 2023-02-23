namespace Static_Classes;

public static class DatabaseConfig
{
    private static string DATABASE_NAME;
    private const int NUMBER_OF_CONNECTIONS = 5;
    private static readonly string DatabaseUrl;

    static DatabaseConfig()
    {
        DATABASE_NAME = "PostgreSql";
        DatabaseUrl = $"htpps//:{DATABASE_NAME}:4500";
    }

    public static string GetDatabaseUrl()
    {
        return DatabaseUrl;
    }
}