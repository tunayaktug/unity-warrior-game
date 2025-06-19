using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PlayerCombat : MonoBehaviour
{
    private NavMeshAgent agent;
    private Camera cam;
    public Animator animator;
    public float attackRange = 2f;
    public int damage = 10;
    public float attackCooldown = 1f;
    

    private float lastAttackTime = 0f;
    private MetinTasiBase currentTarget;



    void Start()
    {
        cam = Camera.main;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        HandleInput();
        HandleAttack();
    }

    void HandleInput()
    {

        if (Input.GetMouseButtonDown(1)) 
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MetinTasiBase metin = hit.collider.GetComponent<MetinTasiBase>();


                if (metin != null)
                {

                    currentTarget = metin;
                    AttackAnimation();
                    agent.SetDestination(metin.transform.position);
                }
                else
                {
                    currentTarget = null;
                    AttackAnimation();
                    agent.SetDestination(hit.point);
                }
            }
        }
    }

    void AttackAnimation()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                MetinTasiBase metin = hit.collider.GetComponent<MetinTasiBase>();


                if (metin != null)
                {
                    animator.SetBool("Attack", true);

                }
                else
                {
                    animator.SetBool("Attack", false);
                }
            }
        }
    }


    void HandleAttack()
    {
        if (currentTarget == null)
        {
            agent.isStopped = false; 
            return;
        }

        float distance = Vector3.Distance(transform.position, currentTarget.transform.position);

        if (distance <= attackRange)
        {
            agent.isStopped = true;

            if (Time.time - lastAttackTime > attackCooldown)
            {
                currentTarget.TakeDamage(damage, gameObject);
                lastAttackTime = Time.time;

                
                if (currentTarget == null || currentTarget.gameObject == null)
                {
                    agent.isStopped = false;
                }
            }
        }
        else
        {
            agent.isStopped = false;
            agent.SetDestination(currentTarget.transform.position);
        }
    }

}
