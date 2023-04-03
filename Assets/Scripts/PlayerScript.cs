using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //movement values
    public float speed;
    public float jumpPower;

    //character info
    public string playerName;
    int playerLevel;

    //experience gain
    public int expAmt;
    int expToLevel;

    // Start is called before the first frame update
    void Start()
    {
        playerName = "Link";
        playerLevel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(gameObject);
            //add code to restart game later
            //reset exp gain?
        }
    }

    void ExperienceGain()
    {

    }

}
