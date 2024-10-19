using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private IMovimiento _movimiento;

    private void Start()
    {
        _movimiento = GetComponent<IMovimiento>();
    }

    public void EjecutarMovimiento(Vector3 objetivo)
    {
        _movimiento.Mover(objetivo);
    }
}