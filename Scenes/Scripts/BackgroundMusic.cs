using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bgm;
    // Start is called before the first frame update
    void Awake()
    {
        if (bgm == null)
        {
            bgm = this;
            DontDestroyOnLoad(bgm);
        }
        else
            Destroy(gameObject);
    }
}
