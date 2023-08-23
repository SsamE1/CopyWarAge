using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StatusManager : MonoBehaviour
{   
    public TextMeshProUGUI TotalGold;
    public TextMeshProUGUI TotalExp;
    public GameObject Hp;
    public int Gold=175;
    public int Exp=0;
    public int CurrentHp=500;
    private TextMeshPro HpText;


    public void Awake(){
        TotalGold.text=Gold.ToString();
        TotalExp.text=Exp.ToString();
        HpText = Hp.GetComponent<TextMeshPro>();
        HpText.text =CurrentHp.ToString();
        
    }

    void Update(){
        TotalGold.text=Gold.ToString();
        TotalExp.text=Exp.ToString();
       
    }
    public void KillEnemy(int KillGold,int KillExp){
        Gold+=KillGold;
        TotalGold.text=Gold.ToString();
        Exp+=KillExp;
        TotalExp.text=Exp.ToString();
    }
    
}
