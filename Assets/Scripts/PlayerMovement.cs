using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    private Camera cam;
    public Animator animator;

    void Start()
    {
        cam = Camera.main;
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                
                agent.SetDestination(hit.point);
            }
        }

        HandleMovementAnimation();
    }
    void HandleMovementAnimation()
    {
        
        bool Run = agent.velocity.magnitude > 0.1f;
        animator.SetBool("Run", Run);
        

    }
}
