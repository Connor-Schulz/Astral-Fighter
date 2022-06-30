using System;
using System.IO;
using UnityEngine;


namespace PlayerControl
{
    [System.Serializable]
    public class KeyBinding {
 
        public string moveLeft;
        public string moveRight;
        public string jump;
        public string attack;
        public string projectile;

        public KeyBinding(string fileName) {

        }

        public static KeyBinding CreateFromJSON(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonUtility.FromJson<KeyBinding>(jsonString);
        }

        public string toString() {
            return @$"
            left : {moveLeft},
            right : {moveRight},
            jump : {jump},
            attack : {attack},
            projectile : {projectile},";
        }

    }
    
    [System.Serializable]
    public class Player{

        /* Health Points */
        public int healthMax;
        public int healthCurrent;

        /* Physical attributes */
        public int mass;
        public int runSpeed;
        public int jumpHeight;

        /* Other */
        public string playerName;
        public string keyBindingFile;
        public KeyBinding keyMapping;

        public Player() { 

            /* Health Points */
            healthMax = 100; 
            healthCurrent = healthMax;

            /* Physical attributes */
            mass = 100;
            runSpeed = 100;
            jumpHeight = 100;

            /* Other */
            playerName = "test";
        }

        public static Player CreateFromJSON(string fileName)
        {   
            string jsonString = File.ReadAllText(fileName);
            Player newPlayer = JsonUtility.FromJson<Player>(jsonString);
            newPlayer.keyMapping = KeyBinding.CreateFromJSON($"{Application.dataPath}/Scripts/Configs/KeyBindings/"+newPlayer.keyBindingFile);
            return newPlayer;
        }

        public void DamagePlayer (int damageAmount) {
            healthCurrent = ((damageAmount >= healthCurrent)? 0 : (healthCurrent- damageAmount));
        }

        public void HealPlayer (int healAmount) {
            healthCurrent = ((healthCurrent + healAmount >= healthMax)? healthMax : (healthCurrent + healAmount));
        }

        public string toString() {
            return @$"
            healthMax : {healthMax},
            healthCurrent: {healthCurrent},
            mass : {mass},
            runSpeed : {runSpeed},
            jumpHeight : {jumpHeight},
            playerName : {playerName},
            keyBinding : {keyMapping.toString().Replace("\n","\n\t")}";
        }
    }
}
