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
        lb.Add("화살", 1);
        lb.Add("돌맹이", 3);
        lb.Add("물약", 5);

        ItemConsole();
        ShowAllIB();
    }

    // Update is called once per frame
    void Update()
    {
        if (get)
        {
            lb[what]++;

            int i = lb[what];
            Debug.Log($"{what} 획득(현재 수량: {i})");

            get = false;
        }

        if (use)
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

    void ItemConsole()
    {
        int many = 0;

        foreach (KeyValuePair<string, int> book in lb) // foreach는 for과는 달리 무조건 대상 리스트의 처음부터 끝까지 반복.
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

    void ShowAllIB()
    {
        foreach (KeyValuePair<string, int> book in lb) 
        {
            Debug.Log($"{book.Key} x{book.Value}");
        }
    }
}
