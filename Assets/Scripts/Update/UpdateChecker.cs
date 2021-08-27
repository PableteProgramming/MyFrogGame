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
            //File.Delete(name);
            //Debug.Log(content);
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
                    if (lines.Length >= 3)
                    {
                        string updatezipname= @"MyFrogGame-"+lines[1].Trim();
                        Debug.Log("downloading " + lines[2].Trim());
                        gameObject.GetComponent<DownloadUpdate>().DownloadFile(lines[2].Trim(), updatezipname+@".zip");
                        ZipFile.ExtractToDirectory(updatezipname + @".zip", updatezipname);
                        File.Delete(updatezipname + @".zip");
                    }
                }
            }
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
