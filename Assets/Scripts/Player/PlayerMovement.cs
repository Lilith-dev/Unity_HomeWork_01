using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Range(1, 10)]
    [SerializeField] private float moveSpeed;
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * moveInput * moveSpeed * Time.deltaTime);
    }
}