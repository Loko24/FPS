using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour, IWeapon
{
    private Weapon _weapon;
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _damage;
    [SerializeField]
    private int _bulletQuantity;
    [SerializeField]
    private int _bulletCharger;
    [SerializeField]
    private float _destroyDelay;
    [SerializeField]
    private BulletType _bulletType;

    // Start is called before the first frame update
    void Start()
    {
        _weapon.Name = _name;
        _weapon.Damage = _damage;
        _weapon.BulletQuantity = _bulletQuantity;
        _weapon.BulletCharger = _bulletCharger;
        _weapon.DestroyDelay = _destroyDelay;
        _weapon.BulletType = _bulletType;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
