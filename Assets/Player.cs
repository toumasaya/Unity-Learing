using UnityEngine;

public class Player : MonoBehaviour, IDamagable
{
    public int Health { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Damage(int damageAmount)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
