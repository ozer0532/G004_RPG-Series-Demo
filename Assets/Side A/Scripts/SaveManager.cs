using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Tutorial {

    public class SaveManager : MonoBehaviour
    {
        public void Save()
        {
            SaveGame();
        }

        public void Load()
        {
            LoadGame();
        }

        public static void SaveGame()
        {
            SaveData saveData = new SaveData();
            saveData.stats = Statistics.stats;
            saveData.coin = MoneyManager.coins;
            Serialize(saveData, File.Open(Path.Combine(Application.persistentDataPath, "savetutor.dat"), FileMode.Create));
        }

        public static void LoadGame()
        {
            SaveData saveData = Deserialize(File.Open(Path.Combine(Application.persistentDataPath, "savetutor.dat"), FileMode.Open));
            Statistics.stats = saveData.stats;
            MoneyManager.coins = saveData.coin;
        }

        public static void Serialize(SaveData saveData, Stream stream)
        {
            try
            {
                using (stream)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, saveData);
                }
            }
            catch (IOException e)
            {
                Debug.LogError(e);
            }
        }

        public static SaveData Deserialize(Stream stream)
        {
            SaveData data = null;
            try
            {
                using (stream)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    data = (SaveData)bf.Deserialize(stream);
                }
            }
            catch (IOException e)
            {
                Debug.LogError(e);
            }
            return data;
        }
    }
}
