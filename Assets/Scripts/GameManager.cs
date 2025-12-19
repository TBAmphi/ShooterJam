using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Instance Game Manager
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
    public float shootCooldownTime = 1f;
    bool isShootActivated = false;

    [Header("Score")]
    public int totalScore;
    public int pointsValue;

    [Header("Main Character")]
    public GameObject mc;
    bool isPowerInCooldown = false;
    [SerializeField] float powerCooldownTime = 2f;
    bool inAction = false;

    void Update()
    {
        if(cooldown == true && !isShootActivated)
        {
            isShootActivated = true;
            StartCoroutine(WeaponCooldown());
        }

        if(!isPowerInCooldown)
        {
            isPowerInCooldown = true;
            StartCoroutine(PowerManager());
        }

        if(!inAction)
        {
            inAction = true;
            StartCoroutine(PowerManager());
        }
    }

    IEnumerator WeaponCooldown()
    {
        yield return new WaitForSeconds(shootCooldownTime);
        cooldown = false;
        isShootActivated = false;
    }

    IEnumerator PowerManager()
    {
        //Debug.Log("Before Wait");
        yield return new WaitForSeconds(powerCooldownTime);
        ChoosePower();
        //Debug.Log("After Wait");
        isPowerInCooldown = false;
        inAction = false;
    }

    void ChoosePower()
    {
        bool isHappeningSomething = false;
        int nbPowers = 3;

        int rand = Random.Range(0, 10);
        Debug.Log(rand);
        if(rand <= 7)
        {
            rand = 0;
        }
        else if(rand > 6)
        {
            rand = 1;
        }
        switch (rand)
        {
            case 0:
                isHappeningSomething = false;
                //Debug.Log("Nothing happend");
                break;
            case 1:
                isHappeningSomething = true;
                //Debug.Log("Something happend");
                break;
        }

        if(isHappeningSomething)
        {
            isHappeningSomething = false;

            int random = Random.Range(1, nbPowers + 1);
            int choosenPower = random;
            switch (choosenPower)
            {
                case 1: 
                    Teleportation();
                    break;
                case 2:
                    Duplication();
                    break;
                case 3:
                    Invisibility();
                    break;
            }
        }
    }

    void Teleportation()
    {
        Debug.Log("Teleportation");
    }

    void Duplication()
    {
        Debug.Log("Duplication");
    }

    void Invisibility()
    {
        Debug.Log("Invisibility");
    }
}
