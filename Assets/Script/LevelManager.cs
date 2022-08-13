using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level Creator", menuName = "Level")]
public class LevelManager : ScriptableObject
{
    public string LevelNumber;
    public List<Sprite> sprite;

}
