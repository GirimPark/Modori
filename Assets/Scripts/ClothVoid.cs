using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothVoid : MonoBehaviour
{
    public GameObject cloth1, cloth2, cloth3, cloth4; //캐릭터 옷 목록
    public Sprite change_img1, change_img2, change_img3, change_img4, player_img;//변경할 이미지 
    bool isFairy;//동화구연에서 넘어왓는지 
    Image thisImg; //현재 이미지

    // Start is called before the first frame update
    void Start()
    {
        if((object)GameObject.Find("changeO").GetComponent<FairyVoid>().closetTF!=null){
            isFairy=true;
        }else{
            isFairy=false;
        }
        thisImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(GameObject.Find("changeO").GetComponent<FairyVoid>().closetTF);

        //isFairy = GameObject.Find("changeO").GetComponent<FairyVoid>().closetTF;
        //동화 구연에서 값이 넘어왔다면
        if(isFairy == true){
            //옷 목록 보여주기
            cloth1.SetActive(true);
            cloth2.SetActive(true);
            cloth3.SetActive(true);
            cloth4.SetActive(true);
            /*if(Input.GetMouseButtonDown(0)){//마우스 클릭시
                Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D hit = Physics2D.Raycast(pos, Camera.main.transform.forward);
                if(hit.collider!=null){//클릭한 오브젝트 이름 가져옴
                    GameObject click_obj = hit.transform.gameObject;
                    Debug.Log(click_obj.name);
                    //옷 입히기 
                    if(click_obj.name=="cloth1"){
                        thisImg.sprite = change_img1;
                    }else if(click_obj.name=="cloth2"){
                        thisImg.sprite = change_img2;
                    }else if(click_obj.name=="cloth3"){
                        thisImg.sprite = change_img3;
                    }else if(click_obj.name=="cloth4"){
                        thisImg.sprite = change_img4;
                    }else if(click_obj.name=="btn_reset"){
                        thisImg.sprite = player_img;
                    }
                }
            }*/
        }
        if(Input.GetMouseButtonDown(0)){//마우스 클릭시
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Camera.main.transform.forward);
            if(hit.collider!=null){//클릭한 오브젝트 이름 가져옴
                GameObject click_obj = hit.transform.gameObject;
                Debug.Log(click_obj.name);
                //옷 입히기 
                if(click_obj.name=="cloth1"){
                    thisImg.sprite = change_img1;
                }else if(click_obj.name=="cloth2"){
                    thisImg.sprite = change_img2;
                }else if(click_obj.name=="cloth3"){
                    thisImg.sprite = change_img3;
                }else if(click_obj.name=="cloth4"){
                    thisImg.sprite = change_img4;
                }else if(click_obj.name=="btn_reset"){
                    thisImg.sprite = player_img;
                }
            }
        }
    }
    
}
