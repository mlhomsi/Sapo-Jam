using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    // Start is called before the first frame update
    //int life;
    //private Rigidbody2D rb;
    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        //life = 50;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Fall")
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (col.gameObject.tag == "Enemy")
        {

            //life -= 1;
            //UnityEngine.Debug.Log(life);
            //if (life >= 0)
            //{
            //  rb.AddForce(transform.up * thrust);
            //}
            // else
            //{
            UnityEngine.Debug.Log("mort");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //}

        }
    }
}
