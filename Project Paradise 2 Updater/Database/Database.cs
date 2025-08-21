using Newtonsoft.Json;
using System;
using System.IO;

namespace Project_Paradise_2_Updater
{
    /// <summary>
    /// Handles database operations such as reading and writing data related to Project Paradise 2.
    /// </summary>
    class Database
    {
        internal static string DokumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Project-Paradise 2/";
        /// <summary>
        /// An instance of the main database object.
        /// </summary>
        public static PP2Database p2Database = new PP2Database();
        /// <summary>
        /// Flag indicating if the database has been loaded successfully.
        /// </summary>
        public static bool IsLoadet { get; set; } = false;

        /// <summary>
        /// Reads the database from the saved location or initializes a new one if it doesn't exist.
        /// </summary>
        public static void Read()
        {
            try
            {
                var sysp = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var fold = "PP2";

                var savedir = (Path.Combine(sysp, fold));
                if (!Directory.Exists(savedir))
                    Directory.CreateDirectory(savedir);

                if (File.Exists(DokumentsFolder + "/dbData.db"))
                {
                    try
                    {
                        string json = File.ReadAllText(DokumentsFolder + "/dbData.db");
                        p2Database = JsonConvert.DeserializeObject<PP2Database>(json);
                    }
                    catch (Exception)
                    {
                    }
                }
                else
                {

                }
                IsLoadet = true;
            }
            catch (Exception)
            {
            }
        }
    }
}