using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Sword")
        {
            StartCoroutine(PlayAnimationRoutine());
        }
    }
    private IEnumerator PlayAnimationRoutine()
    {
        animator.Play("EnemyDeath");
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}
