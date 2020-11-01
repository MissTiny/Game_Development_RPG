
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveSystem
{
    //modify this file and data if we need to save  more
    public static Data Save(){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath +"/player.ability";
        FileStream stream = new FileStream(path,FileMode.Create);

        Data data = new Data();

        formatter.Serialize(stream,data);
        stream.Close();
        return data;
    }

    //disable the click on load in future.
    public static Data Load(){
        string path = Application.persistentDataPath +"/player.ability";
        if(File.Exists(path)){
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path,FileMode.Open);
            Data data = formatter.Deserialize(stream) as Data;
            stream.Close();
            return data;
        }else{
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
