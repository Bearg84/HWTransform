using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowCapsule : MonoBehaviour
{
    [SerializeField] private float _growthRate;

    private void Update()
    {
        Vector3 newScale = transform.localScale + Vector3.one * _growthRate * Time.deltaTime;

        transform.localScale = newScale;
    }
}