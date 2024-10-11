using GameJolt.API;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;
    private int count;
    private bool isDead;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        if(isDead)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            rb.AddForce(speed * Vector3.up, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (isDead)
        {
            return;
        }
        isDead = true;
        Scores.Add(count, $"Spacebar count: {count}", 943029, "", OnCallback);
        
    }

    private void OnCallback(bool success)
    {
        Destroy(gameObject);

        GameManager.Instance.GameOver();

    }

}
