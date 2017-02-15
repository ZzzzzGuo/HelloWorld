using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public class Ammo
    {
        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Ammo(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
        public Ammo(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

    }

    internal Ammo ammo = new Ammo(10, 50, 5);

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
