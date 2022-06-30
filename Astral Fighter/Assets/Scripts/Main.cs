using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using PlayerControl;


[InitializeOnLoad]
public class Main : MonoBehaviour
{
    static Main()
    {
        string dir = $"{Application.dataPath}/Scripts/Configs/Player";
        string [] files = Directory.GetFiles(dir, "*.json");

        foreach (string file in files) {
            Player p = Player.CreateFromJSON(file);
            Debug.Log(p.toString());
        }
    }



}
