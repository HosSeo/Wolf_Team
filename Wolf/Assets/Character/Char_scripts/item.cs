using UnityEngine;
using System.Collections;

/// 각 아이템은 이 클래스

public class item : MonoBehaviour
{
    
    private string m_strName;   
    private string m_strSpriteName;
    // 아이콘을 표시하는 Sprite 클래스
    
    public tk2dSpriteCollection m_sprIcon;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetInfo(string spriteName)
    {
        // 같은 아틀라스에 있으니 스프라이트 이름 찾아 넣어주면 이미지가 바낌
        //m_sprIcon.spriteName = spriteName;
        // 이름도 설정(확인 위해 이름설정하는거)
        m_strName = spriteName;
    }
    
    void OnClick()
    {        
        Debug.Log(m_strName + " 클릭");
    }
}

