using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace EPAMgit
{
    class Program
    {

        static void Main(string[] args)
        {

            string choosenCase;

            bool caseChecker = false;

            Console.WriteLine("1. Отслеживание изменений");
            Console.WriteLine("2. Бекап");
            Console.WriteLine("3. Выход");

            while (true)
            {
                Console.Write("Выберите номер пункта:");
                do
                {
                    choosenCase = Console.ReadLine();

                    if (choosenCase == "1" || choosenCase == "2" || choosenCase == "3")
                    {
                        caseChecker = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 3!");
                    }
                }
                while (caseChecker == false);

                switch (choosenCase)
                {
                    case "1":
                        FileWorker.Activate();
                        break;
                    case "2":
                        Backup();
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }
            }
        }

        static void Backup()
        {
            bool checker = false;

            string[] backups = FileWorker.GetBackups();

            for (int i = 0; i < backups.Length; i++)
            {
                Console.WriteLine(i + " - " + backups[i]);
            }

            while (checker == false)
            {
                string input = Console.ReadLine();

                checker = int.TryParse(input, out int i);

                if (i >= 0 || i <= backups.Length)
                {
                    FileWorker.Copy(backups[i]);
                }
                else
                {
                    Console.WriteLine("Введите корректное значение!");
                    checker = false;
                }
            }
        }
    }

    class FileWorker
    {
        static string backupFolder = @"E:\TestBackup\";

        static string sourceFolder = @"E:\TestFiles\";

        public static void Activate()
        {
            using var watcher = new FileSystemWatcher(sourceFolder);

            watcher.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;

            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;

            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            Console.ReadLine();
        }

        public static void OnChanged(object sender, FileSystemEventArgs e)
        {
            var folderName = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("Работает!!!!");
            DirCopy(sourceFolder, backupFolder + folderName + Path.DirectorySeparatorChar);
        }

        public static void DirCopy(string path1, string path2) //копировать папку
        {
            Directory.CreateDirectory(path2);
            foreach (string dirPath in Directory.GetDirectories(path1, "*", System.IO.SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(path1, path2));

            foreach (string newPath in Directory.GetFiles(path1, "*.*", System.IO.SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(path1, path2), true);
        }
        public static void Copy(string path)
        {
            FileSystem.CopyDirectory(path, sourceFolder, true);
        }

        public static string[] GetBackups()
        {
            return Directory.GetDirectories(backupFolder);
        }
    }
}
