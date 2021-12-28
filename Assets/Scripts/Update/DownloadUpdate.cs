using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class DownloadUpdate : MonoBehaviour
{
    public void DownloadFile(string url, string name)
    {
        WebClient webClient = new WebClient();
        webClient.DownloadFile(url, name);
    }
}
