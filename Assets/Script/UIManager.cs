using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject failLevel;
    public GameObject LevelUpdate;
    [SerializeField] GameObject Level1;

    public void LevelFail()
    {
        failLevel.SetActive(true);
        failLevel.transform.DOScale(1.2f, 0.3f);
    }

    public void LevelComplete()
    {
        LevelUpdate.transform.DOScale(1.2f, 0.3f);
        LevelUpdate.SetActive(true);
    }
    public void ResetLevel()
    {
        failLevel.transform.DOScale(0, 5f);
    }
    public void LevelOneDone()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void tailAnimation(Tail _tail)
    {
        _tail.transform.DOScale(1.2f, 0.3f);
    }

    public void TailAnimationReset(Tail _tail)
    {
        _tail.transform.DOScale(1f, 0.3f);
    }

}

