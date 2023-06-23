using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class JsonController : MonoBehaviour
{
    public static JsonSave save;

    private void Start()
    {
        UploadJSon();

    }

    private void OnApplicationQuit()
    {
        SaveJSon();
    }

    public void SaveJSon()
    {
        save = new JsonSave();
        string jSonString = JsonUtility.ToJson(save);
        File.WriteAllText(Application.dataPath + "/Saves/kullaniciJson.json", jSonString);


    }

    public void UploadJSon()
    {
        string path = Application.dataPath + "/Saves/kullaniciJson.json";
        if (File.Exists(path))
        {
            //yukleme yap
            string ReadJson = File.ReadAllText(path);
            save = JsonUtility.FromJson<JsonSave>(ReadJson);
        }
        else
        {
            Debug.Log("kayit yok");
        }
    }

}
