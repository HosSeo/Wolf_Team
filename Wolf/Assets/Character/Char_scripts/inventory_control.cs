using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class inventory_control : MonoBehaviour
{    
    private List<string> m_lItemNames = new List<string>(); 
    private List<item> m_lItems = new List<item>();    
    public GameObject m_gObjSampleItem;

    // 스크롤뷰를 reposition
    //public UIScrollView m_scrollView;

    // 그리드를 reset position
    //public UIGrid m_grid;

    // Use this for initialization
    void Start()
    {
        InitItems();
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.A))
        {
           // AddItem();
        }
       
        if (Input.GetKeyDown(KeyCode.C))
        {
            ClearAll();
        }
      
        if (Input.GetKeyDown(KeyCode.R))
        {
            ClearRand();
        }
    }
  
    private void InitItems()
    {
       
        m_lItemNames.Add("Berry_02");
        m_lItemNames.Add("Book_00");
        m_lItemNames.Add("Coin_03");
        m_lItemNames.Add("Cloak_02");
        m_lItemNames.Add("Crystal Ball_02");
        m_lItemNames.Add("Crystal Ball_03");
        m_lItemNames.Add("Essence_03");
        m_lItemNames.Add("Flower Bunch_03");
        m_lItemNames.Add("Gems_01");
        m_lItemNames.Add("Necklace_03");
        m_lItemNames.Add("metal sword");
        m_lItemNames.Add("Shirt_01");
    }
    
    //private void AddItem()
    //{       
    //    int nRandomIndex = Random.Range(0, m_lItemNames.Count);

    //    // 그리드 자식
    //    //GameObject gObjItem = NGUITools.AddChild(m_grid.gameObject, m_gObjSampleItem);
      

    //    // SampleItem의 Active
    //   // gObjItem.SetActive(true);

    //    // 이제 이름과 아이콘을 세팅할께요.
    //    // 그럴려면 먼저 아까 만든 ItemScript를 가져와야겠죠.      
    //   // item item = gObjItem.GetComponent<item>();
    //   // item.SetInfo(m_lItemNames[nRandomIndex]);
       
        
        
    //  //  m_grid.Reposition();
    //   // m_scrollView.ResetPosition();
        
    //   // m_lItems.Add(item);
    //}

    // 모두 삭제
    private void ClearAll()
    {
        
        for (int nIndex = 0; nIndex < m_lItems.Count; nIndex++)
        {
            if (m_lItems[nIndex] != null && m_lItems[nIndex].gameObject != null)
                Destroy(m_lItems[nIndex].gameObject);
        }
        m_lItems.Clear();
       
        
       
       // m_grid.Reposition();
       // m_scrollView.ResetPosition();
    }

    // 하나 랜덤으로 삭제
    private void ClearRand()
    {
        
        if (m_lItems.Count == 0) return;


        // 지울꺼 랜덤으로 찾고.
        int nRandomIndex = Random.Range(0, m_lItems.Count);
        // 게임오브젝트 없애줍니다.
        // 여기에서는 DestroyImmediate를 사용합니다. 지우고 바로 갱신을 해야하니까요.
        // 나중에 천천히 설명하겠습니다.
        DestroyImmediate(m_lItems[nRandomIndex].gameObject);
        // 리스트에서도 지워줍시다.
        m_lItems.RemoveAt(nRandomIndex);



      //  m_grid.Reposition();
       // m_scrollView.ResetPosition();
    }
  
    private void OnDestroy()
    {
        for (int nIndex = 0; nIndex < m_lItems.Count; nIndex++)
        {
            // 혹시 모르니까 null이 아닐 때에만 삭제하도록 해요.
            if (m_lItems[nIndex] != null && m_lItems[nIndex].gameObject != null)
                Destroy(m_lItems[nIndex].gameObject);
        }

        m_lItems.Clear();
        m_lItems = null;

        m_lItemNames.Clear();
        m_lItemNames = null;
    }
}