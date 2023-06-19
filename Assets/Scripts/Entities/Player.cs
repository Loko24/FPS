using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Life { get; set; }
    public float Speed { get; set; }
    public List<Weapon> Weapons { get; set; }
}
