using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using IniParser;

namespace BackupCore_Frontend
{
    class ConfigHandler
    {
        public BackupProfile OpenConfigFile(string path)
        {
            try
            {
                var parser = new FileIniDataParser();
                var data = parser.ReadFile(path);

                var flags = data["Flags"];
                var files = data["Files"];
                string actionName = flags["profile"];
                string mode = flags["mode"];
                string comparator = flags["compare"];

                int copies = Convert.ToInt32(flags["history"]);
                bool archive = flags["archive"] == "yes" || flags["archive"] == "true" ? true : false;
                string password = flags["password"];

                string[] sources = files["sources"].Replace("\"", "").Split(',');
                string[] destination = files["destinations"].Replace("\"", "").Split(',');

                bool locked = File.Exists("./"+actionName+".db");
                return new BackupProfile(actionName, sources, destination, mode, comparator, copies, archive, password, locked);
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                return null;
            }
        }

        private string ParseAction(BackupProfile config)
        {
            var builder = new StringBuilder();
            builder.AppendLine("[Flags]");
            builder.AppendLine("profile=" + config.ActionName);
            builder.AppendLine("mode=" + config.Mode);
            builder.AppendLine("compare=" + config.Comparator);
            builder.AppendLine("history=" + config.BackupCopies);
            builder.AppendLine("archive=" + (config.Archive ? "yes" : "no:"));
            builder.AppendLine("password=" + config.ArchivePassword);

            builder.AppendLine("[Files]");
            var sources = new StringBuilder();
            var destinations = new StringBuilder();
            foreach (string src in config.SourcePath)
                sources.AppendFormat("\"{0}\",", src);
            sources.Remove(sources.Length - 1, 1);
            builder.AppendLine("sources=" + sources);
            foreach (string src in config.DestinationPath)
                destinations.AppendFormat("\"{0}\",", src);
            destinations.Remove(destinations.Length - 1, 1);
            builder.AppendLine("destinations=" + destinations);

            return builder.ToString();
        }

        public bool SaveConfigToFile(string path, BackupProfile config, bool ask = true)
        {
            if (File.Exists(path) && ask && MessageBox.Show("Do you wish to overwrite existing profile?", "Overwrite?", MessageBoxButtons.YesNo) == DialogResult.No) return false;
            if (string.IsNullOrEmpty(config.ActionName) ||
                config.DestinationPath == null || config.SourcePath == null ||
                config.DestinationPath.Length == 0 || config.SourcePath.Length == 0)
            {
                MessageBox.Show("Error in profile!");
                return false;
            }
            using (var writer = new StreamWriter(path,false))
            {
                writer.Write(ParseAction(config));
            }
            return true;
        }
    }
}
