namespace BackupCore_Frontend
{
    class BackupProfile
    {
        public string ActionName;
        public string[] SourcePath;
        public string[] DestinationPath;
        public string Mode = "database";
        public string Comparator = "bydate";
        public int BackupCopies;
        public bool Archive;
        public string ArchivePassword = "";
        public bool Locked = false;

        public BackupProfile(string name, string[] source, string[] destination, string bmode, string comparator,
            int copies = 0, bool archive = false, string pass = "", bool locked = false)
        {
            ActionName = name;
            SourcePath = source;
            DestinationPath = destination;
            Mode = bmode;
            Comparator = comparator;
            BackupCopies = copies;
            Archive = archive;
            ArchivePassword = pass;
            Locked = locked;
        }

        public BackupProfile()
        {
        }

        public override string ToString()
        {
            return ActionName;
        }
    }
}
