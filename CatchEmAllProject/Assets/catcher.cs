using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catcher : MonoBehaviour
{
    public GameObject texts;
    public Text txt;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        txt = texts.GetComponent<Text>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Diamondo(Clone)")
        {
            Destroy(collision.collider.gameObject);
            score += 1;
            txt.text = "Score: " + score;
            if (score >= 20)
                SceneManager.LoadScene("win");
        }
    }
}
