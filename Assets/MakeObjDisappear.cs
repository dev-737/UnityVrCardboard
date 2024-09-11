using UnityEngine;

public class MakeObjDisappear : MonoBehaviour
{

    void TiltInteract()
    {
        transform.gameObject.SetActive(false);
    }

    void TiltInteractStop()
    {
        transform.gameObject.SetActive(true);
    }
}
