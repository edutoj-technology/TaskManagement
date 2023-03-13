namespace TaskManagement.Services
{
    public interface IJsonFileService
    {
        public bool WriteToJsonFile(string jsonFilePath, object data);

        public T ReadFromJsonFile<T>(string jsonFilePath);
    }
}
