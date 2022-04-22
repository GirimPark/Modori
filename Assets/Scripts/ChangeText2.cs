using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText2 : MonoBehaviour
{
    bool isPrincess;//공주 클릭했는지
    int clickNum;//클릭 횟수
    private TextMeshProUGUI textArrive;//변경 텍스트
    
    // Start is called before the first frame update
    void Start()
    {
        textArrive = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        isPrincess = GameObject.Find("prince").GetComponent<GameFindPrinc>().isPrincess;
        clickNum = GameObject.Find("prince").GetComponent<GameFindPrinc>().clickNum;//클릭 횟수

        if(isPrincess == true){
            textArrive.text = "정답입니다.";//텍스트 변경
            textArrive.color = Color.blue;//텍스트 색상 변경
        }else if(isPrincess == false && clickNum>0){
            textArrive.text = "다시 찾아주세요.";//텍스트 변경
            textArrive.color = Color.red;//텍스트 색상 변경
        }
    }
}
