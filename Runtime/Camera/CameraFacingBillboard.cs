using UnityEngine;

namespace SteveJstone
{
    [ExecuteAlways]
    public class CameraFacingBillboard : MonoBehaviour
    {
        void Update()
        {
            transform.forward = Camera.main.transform.forward;
        }
    }
}