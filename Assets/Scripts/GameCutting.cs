using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCutting : MonoBehaviour
{
    int clickP1, clickP2, clickP3;//공주 123 클릭 횟수
    public Sprite change_img;//바꿀 이미지
    GameObject princess1, princess2, princess3;//기존 이미지
    void Start()
    {
        clickP1 = 0;
        clickP2 = 0;
        clickP3 = 0;
        princess1 = GameObject.Find("princess1");
        princess2 = GameObject.Find("princess2");
        princess3 = GameObject.Find("princess3");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){//마우스 클릭시
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Camera.main.transform.forward);
            if(hit.collider!=null){//클릭한 오브젝트 이름 가져옴
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj.name);
                if(click_obj.name=="princess1"){//공주1 클릭했을 때
                    clickP1++;
                    if(clickP1>=2){//이미지 변경
                        princess1.GetComponent<Image>().sprite = change_img;
                    }
                }else if(click_obj.name=="princess2"){//공주2 클릭했을 때
                    clickP2++;
                    if(clickP2>=2){//이미지 변경
                        princess2.GetComponent<Image>().sprite = change_img;
                    }
                }else if(click_obj.name=="princess3"){//공주3 클릭했을 때
                    clickP3++;
                    if(clickP3>=2){//이미지 변경
                        princess3.GetComponent<Image>().sprite = change_img;
                    }
                }
            }
        }   
    }
}