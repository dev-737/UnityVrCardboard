using UnityEngine;

public class TiltInteract : MonoBehaviour
{

    public Transform cam;
    // public Transform otherCrosshair;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = cam.position + cam.forward * 2;
        transform.position = target;
        // transform.LookAt(cam.position);
        // otherCrosshair.position = target;
        // otherCrosshair.LookAt(cam.position);
        // otherCrosshair.Rotate(0, 0, -45);
        // transform.Rotate(0, 0, -cam.rotation.eulerAngles.z);
    }
}
