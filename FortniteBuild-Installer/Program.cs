using System.Diagnostics;
using System.IO.Compression;

namespace FortniteBuildInstaller
{
    class Program
    {

        public struct Build
        {
            public string Name;
            public string Date;
            public string EngineVersion;
            public string DownloadLink;

            public Build(string name, string date, string engineVersion, string downloadLink)
            {
                Name = name;
                Date = date;
                EngineVersion = engineVersion;
                DownloadLink = downloadLink;
            }
        }

        static async Task Main(string[] args)
        {
            Console.Title = "FortniteBuild Installer";
            Dictionary<string, string> messages;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Select your language / Choisissez votre langue: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. English\n2. Français\n3. Deutsch\n4. Español\n5. Italiano ");
            Console.Write("Choice: ");
            string langChoice = Console.ReadLine();

            switch (langChoice)
            {
                case "1":
                    messages = Languages.English;
                    Console.Clear();
                    break;
                case "2":
                    messages = Languages.French;
                    Console.Clear();
                    break;
                case "3":
                    messages = Languages.German;
                    Console.Clear();
                    break;
                case "4":
                    messages = Languages.Spanish;
                    Console.Clear();
                    break;
                case "5":
                    messages = Languages.Italian;
                    Console.Clear();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Defaulting to English.");
                    messages = Languages.English;
                    break;
            }

            List<Build> builds = new List<Build>
            {
                new Build("OT6.5-CL-2870186", "28-02-16", "UE4.12", "https://galaxiafn.co.uk/0.6.5.zip"),
                new Build("1.7.2-CL-3700114", "17-10-17", "UE4.16", "https://galaxiafn.co.uk/1.7.2.zip"),
                new Build("1.11-CL-3807424", "14-12-17", "UE4.19", "https://galaxiafn.co.uk/1.11.zip"),
                new Build("2.4.0-CL-3858292", "01-02-18", "UE4.19", "https://galaxiafn.co.uk/2.4.0.zip"),
                new Build("3.0-CL-3901517", "21-02-18", "UE4.20", "https://galaxiafn.co.uk/3.0.zip"),
                new Build("3.5-CL-4008490", "11-04-18", "UE4.20", "https://galaxiafn.co.uk/3.5.zip"),
                new Build("4.2-CL-4072250", "16-05-18", "UE4.20", "https://galaxiafn.co.uk/4.2.zip"),
                new Build("5.41-CL-4363240", "19-09-18", "UE4.21", "https://galaxiafn.co.uk/5.41.zip"),
                new Build("7.30-CL-4834550", "29-01-19", "UE4.22", "https://galaxiafn.co.uk/7.30.zip"),
                new Build("8.00-CL-5203069", "28-02-19", "UE4.22", "https://galaxiafn.co.uk/8.00.zip"),
                new Build("8.50-CL-6058028", "25-04-19", "UE4.23", "https://galaxiafn.co.uk/8.50.zip"),
                new Build("8.51-CL-6165369", "02-05-19", "UE4.23", "https://galaxiafn.co.uk/8.51.zip"),
                new Build("9.10-CL-6639283", "19-05-19", "UE4.23", "https://galaxiafn.co.uk/9.10.zip"),
                new Build("11.00-CL-9603448", "15-10-19", "UE4.24", "https://galaxiafn.co.uk/11.00.zip"),
                new Build("15.50-CL-15526472", "02-03-21", "UE4.26", "https://galaxiafn.co.uk/15.50.zip"),
                new Build("16.50-CL-16432754", "26-05-21", "UE4.26.1", "https://galaxiafn.co.uk/16.50.zip")
            };

            Console.WriteLine(messages["welcome"]);
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("\n" + "Credit: Code made by Waslyl, Repo by Shoqapique");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + messages["available_builds"] + "\n");

            for (int i = 0; i < builds.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Build: {builds[i].Name}, Date: {builds[i].Date}, Engine: {builds[i].EngineVersion}");
            }

            Console.WriteLine("\n" + messages["enter_choice"]);

            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= builds.Count)
            {
                Build selectedBuild = builds[choice - 1];
                Console.WriteLine($"\n{messages["build_choice"]} {selectedBuild.Name}");

                Console.WriteLine("\n" + messages["enter_path"]);
                string installPath = Console.ReadLine();

                if (!Directory.Exists(installPath))
                {
                    Console.WriteLine(messages["invalid_path"]);
                    return;
                }

                string zipPath = Path.Combine(installPath, "build.zip");
                string extractPath = Path.Combine(installPath, selectedBuild.Name);

                Console.WriteLine($"\n{messages["downloading"]} {zipPath}\n");

                try
                {
                    await DownloadFileAsync(selectedBuild.DownloadLink, zipPath);
                    Console.WriteLine(messages["download_success"]);

                    Console.WriteLine(messages["extracting"]);
                    ExtractZipFile(zipPath, extractPath);
                    Console.WriteLine(messages["extract_success"]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n{messages["download_error"]} {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(messages["invalid_choice"]);
            }

            Console.WriteLine(messages["press_key"]);
            Console.ReadKey();
        }

        private static async Task DownloadFileAsync(string url, string filePath)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();
                    long totalBytes = response.Content.Headers.ContentLength ?? 0;

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        byte[] buffer = new byte[8192];
                        long totalRead = 0;
                        int bytesRead;

                        var stopwatch = Stopwatch.StartNew();

                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await fileStream.WriteAsync(buffer, 0, bytesRead);
                            totalRead += bytesRead;

                            Console.Write($"\rProgression: {((double)totalRead / totalBytes) * 100:0.00}%");

                            if (stopwatch.Elapsed.TotalSeconds > 0)
                            {
                                double speed = (totalRead / (1024 * 1024)) / stopwatch.Elapsed.TotalSeconds;
                                Console.Write($" - Speed: {speed:0.00} Mo/s");
                            }
                        }
                        stopwatch.Stop();
                    }
                }
            }
        }

        private static void ExtractZipFile(string zipPath, string extractPath)
        {
            using (var zip = ZipFile.OpenRead(zipPath))
            {
                long totalEntries = zip.Entries.Count;
                long processedEntries = 0;

                foreach (var entry in zip.Entries)
                {
                    string destinationPath = Path.Combine(extractPath, entry.FullName);
                    Directory.CreateDirectory(Path.GetDirectoryName(destinationPath));

                    if (!entry.FullName.EndsWith("/"))
                    {
                        entry.ExtractToFile(destinationPath, overwrite: true);
                    }
                    processedEntries++;
                    double progress = ((double)processedEntries / totalEntries) * 100;
                    Console.Write($"\rExtraction progression : {progress:0.00}%");
                }

                Console.WriteLine();
            }
        }
    }
}
