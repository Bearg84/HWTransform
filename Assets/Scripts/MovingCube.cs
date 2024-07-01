using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MovingCube : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private float _rotationSpeed = 45f;
    [SerializeField] private float _growthRate = 0.1f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);

        transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);

        transform.localScale += Vector3.one * _growthRate * Time.deltaTime;
    }
}