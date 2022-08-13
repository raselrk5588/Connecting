using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMnager : MonoBehaviour
{
    public List<Tail> tails;
    public Tail CurrentTail;
    public TailManager tailManager;

    public UIManager uIManager;

    public RanderLine randerLine;

    public int CountNumber;
    public int WorngCountNumber;

    void Start()
    {
        for (int i = 0; i < tails.Count; i++)
        {
            tails[i].gameMnager = this;
        }
    }

    public void Create(Tail _tails)
    {

        CurrentTail = _tails;
    }

    public void FinalLinne(Tail j)
    {
        CurrentTail.tailBoader.SetActive(true);
        tailManager.LineRanderFinal(CurrentTail.Index, j.Index);

    }

    public void TwoPointerConnecte(Tail _t)
    {
        if (CurrentTail.ItemName == _t.ItemName )
        {

            CountNumber++;
            LevelUp();

        }
        else
        {
            WorngCountNumber++;
            wrongLevel();

        }
    }
    public void LevelUp()
    {
        int i = tailManager.lineCounter;

        if (i == 3 && CountNumber == 3 && WorngCountNumber == 0)
        {
            uIManager.LevelComplete();
          //  Debug.Log("Level Up");

        }

    }
    public void wrongLevel()
    {
        int i = tailManager.lineCounter;
        if (i == 3)
        {
           // Debug.Log("worng");
            uIManager.LevelFail();
        }
    }

}























// public void StartPosition(Tail _start)
// {

//     randerLine.CreatRanderstart(_start.transform.position);
//     Debug.Log("StartPosition");
// }
// public void EndPosition(Tail _endPos)
// {
//     randerLine.CreatRanderEnd(_endPos.transform.position);
//     Debug.Log("StartPosition");
// }


