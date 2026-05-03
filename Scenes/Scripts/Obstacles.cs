
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    public GameObject gameoverUI;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "OBSTACLE")
        {
            Debug.Log("Game Over");
            overgame();

        }
    }
    // Update is called once per frame
    void overgame()
    {
        gameoverUI.SetActive(true);

        Time.timeScale = 0f;
        GameObject.Find("Back music").GetComponent<AudioSource>().Stop();


    }
    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
