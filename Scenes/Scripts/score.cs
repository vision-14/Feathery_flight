using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    public Transform player;
    private double hey;
    public TextMeshProUGUI scoreui;
    // Update is called once per frame
    void Update()
    {
        hey = player.position.x + 5.685;
        scoreui.text = ((int)hey).ToString("0");
    }
}
