using UnityEngine;

public class TiltInteract : MonoBehaviour
{

    public Transform cam;
    public Transform otherCrosshair;

    // Update is called once per frame
    void Update()
    {
        Vector3 target = cam.position + cam.forward * 2;

        transform.SetPositionAndRotation(target, cam.rotation);

        otherCrosshair.SetPositionAndRotation(target, cam.rotation);
        otherCrosshair.Rotate(0, 0, -45);

        // rotate original crosshair when head moves accross z axis
        transform.Rotate(0, 0, -cam.rotation.eulerAngles.z);

        float angle = Quaternion.Angle(transform.rotation, otherCrosshair.rotation);
        RaycastHit hit;

        if (angle < 3)
        {
            if (Physics.Raycast(cam.position, cam.forward, out hit, 5))
            {
                hit.transform.gameObject.SendMessage("TiltInteract");
            }
        }
    }
}
