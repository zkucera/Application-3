using System.Collections;
using UnityEngine;
[RequireComponent(typeof(CanvasGroup))]
public class Mobs : MonoBehaviour
{
	static int AnimatorWalk = Animator.StringToHash("Walk");
	static int AnimatorAttack = Animator.StringToHash("Attack");
	Animator _animator;
	void Awake()
	{
		_animator = GetComponentInChildren<Animator>();
	}
	void Start()
	{
		StartCoroutine(Animate());
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player_Movement>().Death();
        }
    }

    IEnumerator Animate()
	{
		yield return new WaitForSeconds(5f);
		while (true)
		{
			_animator.SetBool(AnimatorWalk, true);
			yield return new WaitForSeconds(0.5f);

			

			_animator.SetBool(AnimatorWalk, false);
			yield return new WaitForSeconds(1f);

			_animator.SetTrigger(AnimatorAttack);
			yield return new WaitForSeconds(1f);


		}
	}

    public void Death()
    {
        Debug.Log("Enemy Killed!");
        Destroy(gameObject);
    }
}
