using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowLevel : MonoBehaviour
{
    public LevelManager levelManager;
    public TextMeshProUGUI Level;
    public List<Image> image;
    // Update is called once per frame
    void Start()
    {
        Level.text = levelManager.LevelNumber.ToString();
        
        for (int i = 0; i < image.Count; i++)
        {
            image[i].sprite = levelManager.sprite[i];
        }

    }
}
