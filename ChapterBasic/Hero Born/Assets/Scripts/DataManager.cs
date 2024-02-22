using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.Text;
public class DataManager : MonoBehaviour, IManger
{
    private string _state;
    private string _dataPath;
    private string _textFile;
    private string _streamingTextFile;
    private string _xmlLevelProgress;
    private string _xmlWeapons;
    private string _jsonWeapons;
    public string State
    {
        get { return _state; }
        set { _state = value; }
    }
    private List<Weapon> weaponInventory = new List<Weapon>(){
        new Weapon("Sword of Doom", 100),
        new Weapon("Butterfly knives", 25),
        new Weapon("Brass Knuckles", 15),
    };
    void Awake()
    {
        _dataPath = Application.persistentDataPath + "/Player_Data/";
        Debug.Log(_dataPath);
        _textFile = _dataPath + "Save_Data.txt";
        _streamingTextFile = _dataPath + "Streaming_Save_Data.txt";
        _xmlLevelProgress = _dataPath + "Progress_Data.xml";
        _xmlWeapons = _dataPath + "WeaponInventory.xml";
        _jsonWeapons = _dataPath + "WeaponJSON.json";
    }
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        _state = "Data Manager initialize";
        Debug.Log(_state);
        // NewDirectory();
        // SerializeJSON();
        // DeserializeJSON();
        // SerializeXML();
        // DeserializeXML();
        // NewTextFile();
        // UpdateTextFile();
        // ReadFromFile(_textFile);
        // WriteToStream(_streamingTextFile);
        // ReadFromStream(_jsonWeapons);
        // WriteToXml(_xmlLevelProgress);
        // ReadFromStream(_xmlLevelProgress);

    }
    public void FileSystemInfo()
    {
        Debug.LogFormat("Path separator character: {0}",
        Path.PathSeparator);

        Debug.LogFormat("Directory separator character: {0}",
        Path.DirectorySeparatorChar);

        Debug.LogFormat("Current directory: {0}",
        Directory.GetCurrentDirectory());

        Debug.LogFormat("Temporary path: {0}",
        Path.GetTempPath());
    }
    public void NewDirectory()
    {
        if (Directory.Exists(_dataPath))
        {
            Debug.Log("Directory already exists...");
            return;
        }
        Directory.CreateDirectory(_dataPath);
        Debug.Log("New directory created");
    }
    public void DeleteDirectory()
    {
        if (!Directory.Exists(_dataPath))
        {
            Debug.Log("Directory doesn't exist or has already been deleted...");
            return;
        }
        Directory.Delete(_dataPath, true);
        Debug.Log("Directory successfully deleted");
    }
    public void NewTextFile()
    {
        if (File.Exists(_textFile))
        {
            Debug.Log("File already exists...");
            return;
        }
        File.WriteAllText(_textFile, "<SAVE DATA>\n\n");
        Debug.Log("New file created");
    }
    public void UpdateTextFile()
    {
        if (!File.Exists(_textFile))
        {
            Debug.Log("File doesn't exist...");
            return;
        }
        File.AppendAllText(_textFile, $"Game started: {DateTime.Now}\n");
        Debug.Log("File updated successfully!");
    }
    public void ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Debug.Log("File doesn't exist...");
            return;
        }
        Debug.Log(File.ReadAllText(filename));
    }
    public void DeleteFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Debug.Log("File doesn't exist or has already been deleted...");
            return;
        }
        File.Delete(_textFile);
        Debug.Log("File successfully deleted");
    }
    public void WriteToStream(string filename)
    {
        if (!File.Exists(filename))
        {
            using (StreamWriter newStream = File.CreateText(filename))
            {
                newStream.WriteLine("<Save Data> for HERO BORN \n\n");
                Debug.Log("New file created with StreamWriter");
            }
        }
        using (StreamWriter streamWriter = File.AppendText(filename))
        {
            streamWriter.WriteLine("Game ended: " + DateTime.Now);
            Debug.Log("File contents update with StreamWriter!");
        }
    }
    public void ReadFromStream(string filename)
    {
        if (!File.Exists(filename))
        {
            Debug.Log("File doesn't exist...");
            return;
        }
        StreamReader streamReader = new StreamReader(filename);
        Debug.Log(streamReader.ReadToEnd());
    }
    public void WriteToXml(string filename)
    {
        if (!File.Exists(filename))
        {
            FileStream xmlStream = File.Create(filename);

            XmlWriter xmlWriter = XmlWriter.Create(xmlStream);

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("level_progress");

            for (int i = 0; i < 5; i++)
            {
                xmlWriter.WriteElementString("level", "Level-" + i);
            }
            xmlWriter.WriteEndElement();

            xmlWriter.Close();
            xmlStream.Close();
        }
    }
    public void SerializeXML()
    {
        var xmlSerializer = new XmlSerializer(typeof(List<Weapon>));
        using (FileStream stream = File.Create(_xmlWeapons))
        {
            xmlSerializer.Serialize(stream, weaponInventory);
        }
    }

    public void DeserializeXML()
    {
        if (File.Exists(_xmlWeapons))
        {
            var xmlSerializer = new XmlSerializer(typeof(List<Weapon>));
            using (FileStream stream = File.OpenRead(_xmlWeapons))
            {
                var weapons = ((List<Weapon>)xmlSerializer.Deserialize(stream));
                foreach (var weapon in weapons)
                {
                    Debug.LogFormat("Weapon: {0} - Damage:{1}",
                    weapon.Name, weapon.Damage);
                }

            }
        }
    }
    public void SerializeJSON()
    {
        WeaponShop shop = new WeaponShop();

        shop.inventory = weaponInventory;

        string jsonString = JsonUtility.ToJson(shop, true);
        using (StreamWriter streamWriter = File.CreateText(_jsonWeapons))
        {
            streamWriter.WriteLine(jsonString);
        }
    }
    public void DeserializeJSON()
    {
        if (File.Exists(_jsonWeapons))
        {
            using (StreamReader streamReader = new StreamReader(_jsonWeapons))
            {
                var jsonString = streamReader.ReadToEnd();
                var weaponData = JsonUtility.FromJson<WeaponShop>(jsonString);
                foreach (var weapon in weaponData.inventory)
                {
                    Debug.LogFormat("Weapon {0} - Damage {1}",
                    weapon.Name, weapon.Damage);
                }
            }
        }
    }
}
