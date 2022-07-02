using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) // means when the player only presses on the left arrow
        {
            if (transform.position.x < 7f)
                transform.position = transform.position + new Vector3(7f, 0, 0); // If the object did not get out of the border u can move to the right(x axis) by 7
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            if (transform.position.x > -7)
                transform.position = transform.position + new Vector3(-7f, 0, 0);

        
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemies")
            SceneManager.LoadScene("SampleScene");
    }

}
