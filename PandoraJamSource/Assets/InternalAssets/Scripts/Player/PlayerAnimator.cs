using UnityEngine;

namespace InternalAssets.Scripts.Player
{
    [RequireComponent(typeof(Animator))]
    public sealed class PlayerAnimator : MonoBehaviour
    {
        private string Walk_parameters = "isWalk";
        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
        }
        
        public void PlayWalkAnimation()
        {
            animator.SetBool(Walk_parameters, true);
        }
        public void PlayIdleAnimation()
        {
            animator.SetBool(Walk_parameters, false);
        }
    }
}