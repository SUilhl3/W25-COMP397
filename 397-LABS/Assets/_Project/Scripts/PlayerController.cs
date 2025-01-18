using UnityEngine;

namespace Platformer397
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private InputReader input;
        void Start()
        {
            Debug.Log("[Start]");
            input.EnablePlayerAction();
        }

        private void OnEnable()
        {
            input.Move += GetMovement;
        }

        private void OnDisable()
        {
            Debug.Log("[OnDisable]");
        }

        private void GetMovement(Vector2 move)
        {
            Debug.Log("Input working " + move);
        }
    }
}
