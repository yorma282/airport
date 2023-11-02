using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
    static class DataBase // строка подключения к БД
    {
        public static string connectionString = @"Data Source=db.db; Integrated Security=False; MultipleActiveResultSets=True";
    }
    static class Aiarplane_table // описание таблиц из БД
    {
        public static string main = "Aiarplane";
        public static string ID = "ID";
        public static string Number = "Number";
        public static string Type = "Type";
        public static string QuanityS = "QuanityS";
        public static string Speed = "Speed";
    }
    static class Date_table // описание таблиц из БД
    {
        public static string main = "Date";
        public static string ID = "ID";
        public static string DateA = "Date/Time - A";
        public static string DateB = "Date/Time - B";
        public static string Quanity = "Quanity";
    }
    static class Route_table // описание таблиц из БД
    {
        public static string main = "Route";
        public static string ID = "ID";
        public static string Distance = "Distance";
        public static string A = "A";
        public static string B = "B";
    }
}
