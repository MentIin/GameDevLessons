using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform head;
    void Update()
    {
        head.forward = Camera.main.transform.forward;
    }


    public void BeBigger()
    {
        transform.localScale = new Vector3(1f, 1, 1f) * 10f;
    }
}
