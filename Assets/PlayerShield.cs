using UnityEngine;
using System.Collections;

public class PlayerShield : MonoBehaviour
{
    public Animator animator;
    public PlayerHealth playerHealth;
    public float shieldDuration = 60f;
    public GameObject shieldGameObject;

    private bool isShieldActive = false;
    private Coroutine shieldRoutine;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ActivateShield();
        }
    }

    public void ActivateShield()
    {
        if (isShieldActive)
            return; // prevent re-activation

        isShieldActive = true;

        if (animator != null)
            animator.Play("Box");

        shieldGameObject.SetActive(true);
        playerHealth.isProtected = true;

        shieldRoutine = StartCoroutine(ShieldCoroutine());
    }

    private IEnumerator ShieldCoroutine()
    {
        Debug.Log("Shield ON");

        yield return new WaitForSeconds(shieldDuration);

        isShieldActive = false;
        playerHealth.isProtected = false;
        shieldGameObject.SetActive(false);

        Debug.Log("Shield OFF");
    }
}




