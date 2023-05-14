using Cinemachine;
using InternalAssets.Scripts.Player;
using UnityEngine;

namespace InternalAssets.Scripts
{
    [RequireComponent(typeof(CinemachineVirtualCamera))]
    public class CameraBinder : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<CinemachineVirtualCamera>().m_Follow = FindObjectOfType<PlayerMovement>().transform;
        }
    }
}