using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class StatusManager : MonoBehaviour
{   
    public TextMeshProUGUI TotalGold;
    public TextMeshProUGUI TotalExp;
    public GameObject MyHp;
    public GameObject EnemyHp;
    public int Gold=175;
    public int Exp=0;
    public int MyCurrentHp=500;
    public int EnemyCurrentHp=500;
    private TextMeshPro MyHpText;
    private TextMeshPro EnemyHpText;


    public void Awake(){
        TotalGold.text=Gold.ToString();
        TotalExp.text=Exp.ToString();
        MyHpText = MyHp.GetComponent<TextMeshPro>();
        MyHpText.text =MyCurrentHp.ToString();
        EnemyHpText = EnemyHp.GetComponent<TextMeshPro>();
        EnemyHpText.text =EnemyCurrentHp.ToString();
        
    }

    void Update(){
        TotalGold.text=Gold.ToString();
        TotalExp.text=Exp.ToString();
        MyHpText.text=MyCurrentHp.ToString();
        EnemyHpText.text=EnemyCurrentHp.ToString();
    }
    public void KillEnemy(int KillGold,int KillExp){
        Gold+=KillGold;
        TotalGold.text=Gold.ToString();
        Exp+=KillExp;
        TotalExp.text=Exp.ToString();
    }
    
}
