using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SummonAButton : MonoBehaviour
{   
    public TextMeshProUGUI priceTag;
    public void PointerOn()
    {
        priceTag.text="$ 15";
    }

    public void PointerExit()
    {
        priceTag.text = ""; // 버튼 위에서 마우스가 나가면 가격 정보를 지움
    }
    
    
}
