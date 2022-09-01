using UnityEditor;
using UnityEngine;

namespace Assets.Resources.Scripts
{
    [System.Serializable]
    public class Group 
    {
        public SHOTTYPE shot_type_;  
    }

    public enum SHOTTYPE
    {
        reflect,
        penetrate
    }
}