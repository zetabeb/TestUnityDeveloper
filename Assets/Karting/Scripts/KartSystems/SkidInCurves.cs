using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkidInCurves : MonoBehaviour
{
    [SerializeField] ArcadeKart arcadeKart;//Necesitamos saber cual carrito afectar, lo atacharemos desde el inspector
    float initialGrip; //Necesitamos tener este valor inicial para cuando salga de las curvas reestablecer el Grip del carro
    bool isInCurve; //Identificamos si esta en una curva donde puede derrapar
    Rigidbody rb; //Necesitaremos el rigid body para aplicarle las fuerzas para el derrape
    private void Start()
    {
        initialGrip = arcadeKart.baseStats.Grip;//Estamos guardando el valor inicial del grip
        rb = GetComponent<Rigidbody>();//Buscamos este elemento solo al iniciar para evitar consumo de memoria innecesario si se llamara todo el tiempo en Update
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SkidArea")) //si el trigger es del tag que necesitamos activará el derrape
        {
            isInCurve = true;//Activar el derrape, esto lo usamos en el FixedUpdate porque usaremos físicas
            arcadeKart.baseStats.Grip = 0;//Dejamos el Grip en 0 para que tenga menos agarre las llantas
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SkidArea"))//si el trigger es del tag que necesitamos desactiva el derrape
        {
            isInCurve = false;//desactivamos el derrape
            arcadeKart.baseStats.Grip = initialGrip;//dejamos el grip en un estado "Normal" tal cual como inicia
        }
    }

    private void FixedUpdate()
    {
        if (isInCurve)//Si está en la curva le aplicaremos una fuerza a la inversa del giro! 
        {
            var horizontal = Input.GetAxis("Horizontal");
            rb.AddForce(new Vector3(horizontal * -5, 0, 0));
        }
    }
}
