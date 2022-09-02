using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Assets.Resources.Scripts {
    [CreateAssetMenu(fileName = "NewData", menuName = "CharacterData")]
    public class CharacterData : ScriptableObject
    {
       [SerializeField] public int Hp;
       [SerializeField] public float Speed;
       [SerializeField] public Sprite Image;
       [SerializeField] public Group Group;
    }
}
