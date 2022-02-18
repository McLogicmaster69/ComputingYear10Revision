using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

public static class SaveSystem
{
    public static void Save<T>(T file, string fileName, string fileExtension)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.StartupPath + $"/{fileName}.{fileExtension}";
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, file);
        stream.Close();
    }
    public static T Load<T>(string fileName, string fileExtension)
    {
        string path = Application.StartupPath + $"/{fileName}.{fileExtension}";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            T file = (T)formatter.Deserialize(stream);
            stream.Close();
            return file;
        }
        else
        {
            Console.WriteLine("Unable to find file");
            return default(T);
        }
    }
}