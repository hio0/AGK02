using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryPractice : MonoBehaviour
{
    public Dictionary<string,int> lb = new Dictionary<string, int>();

    public string bililbook;

    public bool isbannap;
    public bool isit;

    // Start is called before the first frame update
    void Start()
    {
        
        lb.Add("∞∆∞∆∞∆∞∆", 1);
        lb.Add("Å¶Å¶Å¶Å¶", 2);
        lb.Add("Å Å Å Å ", 3);
        /*
        lb["«ÿ∏Æ∆˜≈Õ"] = 1;

        foreach(KeyValuePair<string,int> book in lb) // string, int dictionary ¡ﬂ√∏ «¸Ωƒ¿« book ∫Øºˆ∑Œ lb∏¶ ≥÷¿Ω.
        {
            Debug.Log("√• ¡¶∏Ò" + book.Key + "¿Á∞Ì" + book.Value);
        }

        if(lb.ContainsKey("∞∆∞∆∞∆∞∆"))
        {
            Debug.Log("∞∆∞∆∞∆∞∆¿« «ˆ¿Á ¿Á∞Ì: " + lb["∞∆∞∆∞∆∞∆"]);
        }

        lb["∞∆∞∆∞∆∞∆"]++;
        */
        foreach (KeyValuePair<string, int> book in lb) // foreach¥¬ for∞˙¥¬ ¥ﬁ∏Æ π´¡∂∞« ¥ÎªÛ ∏ÆΩ∫∆Æ¿« √≥¿Ω∫Œ≈Õ ≥°±Ó¡ˆ π›∫π.
        {
            if (book.Key == bililbook && book.Value > 0)
            {
                isit = true;
            }
        }

        if(isit)
        {
            Debug.Log($"{bililbook}¿ª ¥Î√‚«’¥œ¥Ÿ.");
            lb[bililbook]--;
            Debug.Log($"{bililbook}¿« ¥Î√‚¿ª øœ∑·«œø¥Ω¿¥œ¥Ÿ.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isbannap)
        {
            lb[bililbook]++;
            Debug.Log($"{bililbook}¿« π›≥≥¿ª øœ∑·«œø¥Ω¿¥œ¥Ÿ.");
            isbannap = false;
        }
    }
}
