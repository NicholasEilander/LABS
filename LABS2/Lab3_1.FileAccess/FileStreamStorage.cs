using System.IO;
using System.Text;

namespace Lab3_1.FileAccess
{
    public class FileStreamStorage : IFileStreamStorage
    {
        public bool Exists(string filePath)
        {
            return File.Exists(filePath);
        }

        public void WriteAllText(string filePath, string content)
        {
            using (FileStream fs = new FileStream(filePath, FileMode.Create, System.IO.FileAccess.Write, FileShare.None))
            using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
            {
                writer.Write(content);
            }
        }

        public string ReadAllText(string filePath)
        {
            if (!File.Exists(filePath))
                return string.Empty;

            using (FileStream fs = new FileStream(filePath, FileMode.Open, System.IO.FileAccess.Read, FileShare.Read))
            using (StreamReader reader = new StreamReader(fs, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}