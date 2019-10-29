using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns launchers
/// </summary>
public class LauncherSpawner : MonoBehaviour {
    // spawning prefab support
    [SerializeField]
    GameObject prefabChainsawLauncher;
    [SerializeField]
    GameObject prefabPirateLauncher;
    [SerializeField]
    GameObject prefabZombieLauncher;
    int nextLauncher = 0;
    GameObject[] prefabLaunchers;

    // location support
    Vector3 location;

    // timing support
    protected float cooldownSeconds = 5f;
    protected Timer cooldownTimer;

    // Start is called before the first frame update
    void Start() {
        cooldownTimer = gameObject.AddComponent<Timer>();
        cooldownTimer.Duration = cooldownSeconds;
        cooldownTimer.Run();
        prefabLaunchers = new GameObject[3] { prefabChainsawLauncher, prefabPirateLauncher, prefabZombieLauncher };
        location = Camera.main.ScreenToWorldPoint(Camera.main.transform.position);
        location.z = -Camera.main.transform.position.z;
        location = Camera.main.WorldToScreenPoint(location);
    }

    // Update is called once per frame
    void Update() {
        if (cooldownTimer.Finished && nextLauncher < 3) {
            location += new Vector3(Random.Range(-1, 1), 1, 0);
            Instantiate(prefabLaunchers[nextLauncher], 
                location, 
                Quaternion.identity);
            nextLauncher++;
            cooldownTimer.Run();
        }
    }
}
