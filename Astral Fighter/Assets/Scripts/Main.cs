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
        string dir = $"{Application.dataPath}/Scripts/Configs/KeyBindings";
        string [] files = Directory.GetFiles(dir, "*.json");

        foreach (string file in files) {
            string stringifiedJSON = File.ReadAllText(file);
            KeyBinding kb = KeyBinding.CreateFromJSON(stringifiedJSON);
            Debug.Log(kb.toString());
        }

        dir = $"{Application.dataPath}/Scripts/Configs/Player";
        files = Directory.GetFiles(dir, "*.json");

        foreach (string file in files) {
            string stringifiedJSON = File.ReadAllText(file);
            Player p = Player.CreateFromJSON(stringifiedJSON);
            Debug.Log(p.toString());
        }
    }



}
