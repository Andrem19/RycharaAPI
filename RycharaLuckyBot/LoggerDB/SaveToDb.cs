using Newtonsoft.Json;
using RycharaAPI.RycharaLuckyBot.Settings;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RycharaAPI.RycharaLuckyBot.LoggerDB
{
    public class SaveToDb
    {
        public async static Task<string> SSettings(string filename, SettingsModel model)
        {
            string output = JsonConvert.SerializeObject(model);
            string folderName = $"{filename}";
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            string path = Path.Combine(folderName, $"Settings-{filename}.txt");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream file = new FileStream(path, FileMode.CreateNew))
            using (StreamWriter stream = new StreamWriter(file))
                stream.WriteLine(output);
            return output;
        }
        public async static Task<SettingsModel> SReadSettings(string filename)
        {

            SettingsModel data = new();
            string path = Path.Combine($"{filename}", $"Settings-{filename}.txt");
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        data = JsonConvert.DeserializeObject<SettingsModel>(line);
                    }
                }
            }
            return data;

        }
    }
}
