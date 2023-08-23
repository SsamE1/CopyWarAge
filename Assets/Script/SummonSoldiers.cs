using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonSoldiers : MonoBehaviour
{   
    public GameObject PlusMenu; 
    public GameObject SummonAButtons; 
    public GameObject SummonBButtons; 
    public GameObject SummonCButtons; 
    public GameObject BackButton; 

    void Start(){
        PlusMenu.SetActive(false);
        SummonAButtons.SetActive(false);
        SummonBButtons.SetActive(false);
        SummonCButtons.SetActive(false);
        BackButton.SetActive(false);
    }
    public void ShowSummonButtons()
    {
        PlusMenu.SetActive(true);
        SummonAButtons.SetActive(true);
        SummonBButtons.SetActive(true);
        SummonCButtons.SetActive(true);
        BackButton.SetActive(true);
    }
     public void HideSummonButtons()
    {
        PlusMenu.SetActive(false);
        SummonAButtons.SetActive(false);
        SummonBButtons.SetActive(false);
        SummonCButtons.SetActive(false);
        BackButton.SetActive(false);
    }

    /*public StatusManager manager;
    public void ClickButton(){
        if(manager.Gold>=20)manager.Gold-=20;
        else Debug.Log("ㄴㄴ");
    }*/
}
