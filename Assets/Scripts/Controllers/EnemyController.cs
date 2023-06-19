using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour, IEnemy
{
    private Enemy _enemy;
    [SerializeField]
    private float _health;
    [SerializeField]
    private float _respawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        _enemy = FindAnyObjectByType<Enemy>();
        _enemy.Life = _health;
        _enemy.RespawnDelay = _respawnDelay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Death(float damage)
    {
        throw new System.NotImplementedException();
    }
}
