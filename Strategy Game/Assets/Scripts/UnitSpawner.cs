using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject unitPrefab;

    [Header("Stats")]
    [SerializeField] private float spawnTime = 10f;

    private float currentTime;

    private void Start()
    {
        ResetTimer();
    }

    private void Update()
    {
        if(currentTime > 0f)
        {
            currentTime -= Time.deltaTime;
        } else if(currentTime <= 0f)
        {
            SpawnUnit();
        }
    }

    private void ResetTimer()
    {
        currentTime = spawnTime;
    }

    private void SpawnUnit()
    {
        Instantiate(unitPrefab, Vector3.zero, Quaternion.identity);
        ResetTimer();
    }
}
