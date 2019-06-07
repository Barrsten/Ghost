using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    static int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
    	if(collision.gameObject.tag == "Enemy")
        {
        	Destroy(collision.gameObject);
        	score=score+1;
            scoreText.text = "Score:"+score;
            if(score>=4)
            {
                SceneManager.LoadScene(0);
                score=0;
            }
        }
    }

}
