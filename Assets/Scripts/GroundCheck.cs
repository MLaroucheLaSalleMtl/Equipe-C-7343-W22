using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public float maxGroundDistance = .3f;
    public bool isGrounded;

    void LateUpdate()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, maxGroundDistance);
    }
    public static GroundCheck Create(Transform parent)
    {
        GameObject newGroundCheck = new GameObject("Ground Check");
        newGroundCheck.transform.parent = parent;
        newGroundCheck.transform.localPosition = Vector3.up * .01f;
        return newGroundCheck.AddComponent<GroundCheck>();
    }
}
