using UnityEngine;

public class CameraRotate : MonoBehaviour
{

    float time;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, time * 50, 0);
    }
}
