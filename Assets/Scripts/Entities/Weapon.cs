using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string Name { get; set; }
    public BulletType BulletType { get; set; }
    public int Damage { get; set; }
    public int BulletCharger { get; set; }
    public float DestroyDelay { get; set; }
    //public float rechargingTime { get; set; }
}
