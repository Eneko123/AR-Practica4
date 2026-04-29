using UnityEngine;

public class ArrowPath : MonoBehaviour
{
    [SerializeField] GameObject[] arrows;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            if (arrows[i] == arrows[0])
            {
                continue;
            }
            else
            {
                arrows[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPath()
    {
        for (int i = 0; i < arrows.Length; i++)
        {
            Arrow arrow = arrows[i].GetComponent<Arrow>();
            if (arrows[i].gameObject.activeSelf && !arrow.thisArrowIsActive)
            {
                arrows[i + 1].SetActive(true);
            }
        }
    }
}
