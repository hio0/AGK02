using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryPractice : MonoBehaviour
{
    public Dictionary<string, int> lb = new Dictionary<string, int>();

    string manyitem;
    int allItem;

    public string what;
    public bool get;
    public bool use;

    // Start is called before the first frame update
    void Start()
    {
        lb.Add("화살", 1); // 넣기
        lb.Add("돌맹이", 3);
        lb.Add("물약", 5);

        ItemConsole();
        ShowAllIB();
    }

    // Update is called once per frame
    void Update()
    {
        if (get) // 아이템 획득하는 코드
        {
            lb[what]++;

            int i = lb[what];
            Debug.Log($"{what} 획득(현재 수량: {i})");

            get = false;
        }

        if (use) // 아이템 사용하는 코드
        {
            bool isit = false;
            bool isNoZero = true;
            foreach (KeyValuePair<string, int> book in lb) 
            {
                if (book.Key == what)
                {
                   isit = true;
                    if(book.Value <= 0)
                    {
                        isNoZero = false;
                    }
                }
            }

            if(isNoZero)
            {
                if (isit)
                {
                    lb[what]--;

                    int i = lb[what];
                    Debug.Log($"{what} 사용 완료(남은 수량: {i})");
                }
                else
                {
                    Debug.Log($"{what}은 존재하지 않는 아이템입니다;;; ");
                }
            }
            else
            {
                Debug.Log($"{what}의 수량이 부족합니다");
            }
            use = false;
        }
    }

    void ItemConsole() // 가장 많이 가지고 있는 템이랑 총 개수 표시해주는 함수
    {
        int many = 0;

        foreach (KeyValuePair<string, int> book in lb)
        {
            if (book.Value > many)
            {
                many = book.Value;
                manyitem = book.Key;
            }

            allItem += book.Value;
        }
        Debug.Log($"가장 많은 아이템:{manyitem}");
        Debug.Log($"총 아이템 개수:{allItem}");
    }

    void ShowAllIB() // 모든 템 표시해주는 함수
    {
        foreach (KeyValuePair<string, int> book in lb) 
        {
            Debug.Log($"{book.Key} x{book.Value}");
        }
    }
}
