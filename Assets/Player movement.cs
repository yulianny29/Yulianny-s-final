using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); 
    Vector3 movement = new Vector3(moveX, 0f, 0f);
    transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
