using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 15f;  // 카메라 이동 속도
    public float panBorderThickness = 150f;  // 화면 가장자리에 도달했을 때의 영역

    void Start(){
        Vector3 pos=new Vector3(-5f,-0.8f,-0.5f);
        transform.position=pos;
    }
    private void Update()
    { 
        Vector3 pos = transform.position;

        // 가로로만 이동하도록 수정
        if (Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            pos.x += panSpeed * Time.deltaTime;
        }
        if (Input.mousePosition.x <= panBorderThickness)
        {
            pos.x -= panSpeed * Time.deltaTime;
        }

        // 가로 제한을 적용 (x 범위를 -10에서 10으로 제한)
        pos.x = Mathf.Clamp(pos.x, -5f, 5f);

        transform.position = pos;
    }
}
