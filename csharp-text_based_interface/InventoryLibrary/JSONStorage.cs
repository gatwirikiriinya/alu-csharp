using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

public class JSONStorage {
    private Dictionary<string, object> objects = new Dictionary<string, object>();
    private readonly string filename = "inventory_manager.json";
    private string? path;
    private readonly string baseDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    private readonly string newDirectoryName = "storage";

    public void New(object value) {
        if (value is BaseClass classObject) {
            string obj_id = $"{value.GetType().Name}.{classObject.id}";
            objects.Add(obj_id, value);
        }
    }

    public void Save() {
        string newDirectoryFullPath = Path.Combine(baseDirectory, newDirectoryName);

        if (!Directory.Exists(newDirectoryFullPath)) {
            Directory.CreateDirectory(newDirectoryFullPath);
        }

        path = Path.Combine(newDirectoryFullPath, filename);

        string jsonData = JsonSerializer.Serialize(objects.Values);
        
        File.WriteAllText(path, jsonData);
    }

    public void Load() {
        string newDirectoryFullPath = Path.Combine(baseDirectory, newDirectoryName);
        path = Path.Combine(newDirectoryFullPath, filename);

        if (File.Exists(path)) {
            string jsonData = File.ReadAllText(path);
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonData);
        }
    }
}
