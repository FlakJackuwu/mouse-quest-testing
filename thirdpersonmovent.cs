using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdpersonmovent : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizantal");
        float verical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, verical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
