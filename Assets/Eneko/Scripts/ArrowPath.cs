using UnityEngine;

public class ArrowPath : MonoBehaviour
{
    [SerializeField] GameObject[] arrows;
    private int currentIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 1; i < arrows.Length; i++)
        {
            arrows[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextPath()
    {
        if (currentIndex + 1 < arrows.Length)
        {
            currentIndex++;
            arrows[currentIndex].SetActive(true);
        }
        else
        {
            Debug.Log("Se ha llegado al final de la ruta de flechas.");
        }
    }
    //private void LateUpdate()
    //{
    //    for (int i = 0; i < arrows.Length; i++)
    //    {
    //        if (arrows[i].activeSelf)
    //        {
    //            arrows[i].transform.rotation = Quaternion.LookRotation(Vector3.forward);
    //        }
    //    }
    //}
}
