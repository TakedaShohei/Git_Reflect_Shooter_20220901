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

    public enum GIMMICK
    {

    }

    public enum SIZE
    {
        none,
        S,
        M,
        L
    }
}