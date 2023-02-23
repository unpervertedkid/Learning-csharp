namespace Static_Classes;

public static class DatabaseConfig
{
    private static string DATABASE_NAME;
    private const int NUMBER_OF_CONNECTIONS = 5;
    private static string DATABASE_URL;

    static DatabaseConfig()
    {
        DATABASE_NAME = "PostgreSql";
        DATABASE_URL = $"htpps//:{DATABASE_NAME}:4500";
    }

    public static string getDatabaseUrl()
    {
        return DATABASE_URL;
    }
}