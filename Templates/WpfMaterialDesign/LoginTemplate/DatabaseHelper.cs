using System.Data.SQLite;
using System.IO;

namespace LoginTemplate
{
    public static class DatabaseHelper
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.Base