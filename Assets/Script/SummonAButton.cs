using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SummonAButton : MonoBehaviour
{   
    public GameObject unitPrefab;
    public TextMeshProUGUI priceTag;
    Vector3 spawnPosition = new Vector3(-11.0f, -5.0f, 0.0f); // 생성 위치 설정
    public string unitSortingLayer = "Default"; // 유닛의 Sorting Layer 이름
    public int unitSortingOrder = 1; // 유닛의 Sorting Order 값
    
    public void PointerOn()
    {
        priceTag.text = "$ 15";
    }

    public void PointerExit()
    {
        priceTag.text = ""; // 버튼 위에서 마우스가 나가면 가격 정보를 지움
    }
    
    public void clickButton()
    {
        StartCoroutine(SummonCoroutine());
    }

    private IEnumerator SummonCoroutine()
    {
        if (StatusManager.Gold >= 15)
        {
            StatusManager.Gold -= 15;
            yield return new WaitForSeconds(3.0f);
            
            // 유닛 생성
            GameObject newUnit = Instantiate(unitPrefab, spawnPosition, Quaternion.identity);
            
            // 유닛의 Sorting Layer와 Order 설정
            SetSortingLayer(newUnit);
        }
        else
        {
            Debug.Log("돈 부족");
        }
    }

    private void SetSortingLayer(GameObject unit)
    {
        Renderer renderer = unit.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.sortingLayerName = unitSortingLayer;
            renderer.sortingOrder = unitSortingOrder;
        }
    }
}
