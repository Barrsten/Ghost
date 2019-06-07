using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
	Rigidbody rb;
    public GameObject bullet;
    GameObject bulletClone;
    Rigidbody rbClone;
    public Text hpText;
    
    int hp = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
       transform.Rotate(0, moveHorizontal, 0 * 60f);
       if(Input.GetKeyDown("space"))
       {
          bulletClone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
          rbClone = bulletClone.GetComponent<Rigidbody>();
          rbClone.AddForce(transform.forward * 1000f);
       }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            hp=hp-1;
            hpText.text = "HP:"+hp;
            if(hp == 0)
            {
              SceneManager.LoadScene(1);
            }
        }
    }
}
