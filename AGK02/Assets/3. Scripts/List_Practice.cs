using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List_Practice : MonoBehaviour
{
    [SerializeField]
    private List<string> inven = new List<string>();

    public string ckeckStr;

    // Start is called before the first frame update
    void Start()
    {
        inven.Add("검");
        inven.Add("엄");
        inven.Add("걱");

        Debug.Log($"아이템 수: {inven.Count}");

        for (int i = 0; i < inven.Count; i++)
        {
            Debug.Log($"{i+1}번째 아이템: {inven[i]}");
        }

        Debug.Log($"{inven[2]}을 제거했습니다.");
        inven.RemoveAt(2);

        for (int i = 0; i < inven.Count; i++)
        {
            Debug.Log($"{i + 1}번째 아이템: {inven[i]}");
        }

        if (inven.Contains(ckeckStr))
        {
            Debug.Log($"{ckeckStr} 있음");
        }
        else
        {
            Debug.Log($"{ckeckStr} 없음");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
