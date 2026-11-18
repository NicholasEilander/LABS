namespace Lab3_1.FileAccess
{
    public interface IFileStreamStorage
    {
        void WriteAllText(string filePath, string content);
        string ReadAllText(string filePath);
        bool Exists(string filePath);
    }
}
