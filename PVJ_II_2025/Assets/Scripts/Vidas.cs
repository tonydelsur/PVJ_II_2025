using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private float vida = 5f;
    

    public void ModificarVida(float puntos)
    {
        vida += puntos;
        
        if (vida >= 0)
        {
            Debug.Log("Sigues Vivo");
        } else {
            Debug.Log("GAME OVER");
        }
    }


    private bool EstasVivo()
    {
        return vida > 0;
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta")) { return; }

        Debug.Log("GANASTE");
    }
}
