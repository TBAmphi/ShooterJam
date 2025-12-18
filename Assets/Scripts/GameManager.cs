using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

    [Header("Shoot")]
    public bool cooldown = false;
    public float cooldownTime = 5f;
    bool isActivated = false;

    [Header("Score")]
    public int totalScore;
    public int pointsValue;

    void Update()
    {
        if(cooldown == true && !isActivated)
        {
            isActivated = true;
            StartCoroutine(WeaponCooldown());
        }
    }

    IEnumerator WeaponCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);
        cooldown = false;
        isActivated = false;
    }
}
