using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    ArrowPath path;
    public bool thisArrowIsActive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        path = GetComponentInParent<ArrowPath>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Target"))
        {
            thisArrowIsActive = false;

            if (path != null) path.NextPath(); // Llamada segura

            gameObject.SetActive(false);
        }
    }
}