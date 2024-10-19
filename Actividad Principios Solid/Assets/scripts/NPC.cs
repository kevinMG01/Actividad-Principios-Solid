using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private IMovimiento _movimiento;
    private Vector3 _destino;
    private bool _estaMoviendose = false;
    private NPCAtaca _npcAtaca;

    private void Start()
    {
        _movimiento = GetComponent<IMovimiento>();
        _npcAtaca = GetComponent<NPCAtaca>();
    }

    public void EjecutarMovimiento(Vector3 objetivo)
    {
        _destino = objetivo;
        _estaMoviendose = true;
    }

    private void Update()
    {
        if (_estaMoviendose)
        {
            _movimiento.Mover(_destino);

            if (Vector3.Distance(transform.position, _destino) < 0.1f)
            {
                _estaMoviendose =false;
   
                if (_npcAtaca != null)
                {
                    _npcAtaca.atacar();

                }
                
            }
        }
    }
}