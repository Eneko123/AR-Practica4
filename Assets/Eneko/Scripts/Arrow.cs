using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody rb;
    ArrowPath path;
    public bool thisArrowIsActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
            path.NextPath();
            gameObject.SetActive(false);
        }
    }
}
