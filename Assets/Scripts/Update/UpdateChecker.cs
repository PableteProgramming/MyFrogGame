using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using UnityEngine;

public class UpdateChecker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (CheckInternetConnection())
        {
            string url = "https://raw.githubusercontent.com/PableteProgramming/MyFrogGameUpdater/master/updateFile";
            string name = @"updateFile.txt";
            gameObject.GetComponent<DownloadUpdate>().DownloadFile(url, name);
            string content = File.ReadAllText(name);
            string[] lines = content.Split('\n');
            foreach(string line in lines)
            {
                Debug.Log(line);
            }
            Debug.Log(lines.Length);
            if (lines.Length > 0)
            {
                if (lines[0].Trim() == "true")
                {
                    Debug.Log("update available");
                    File.Delete(name);
                }
            }
        }
        else
        {
            Debug.Log("No internet connection");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool CheckInternetConnection()
    {
        if (Application.internetReachability!= NetworkReachability.NotReachable)
        {
            return true;
        }
        return false;
    }
}
