using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float horasReservadas;
    public string tipoEjercicio;
    float precioFinal;
    float precioDescuento;

    // Start is called before the first frame update
    void Start()
    {
        if (horasReservadas > 6 || horasReservadas < 1)
        {
            Debug.Log("La cantidad de horas ingresada es invalida");
            return;
        }
        if (tipoEjercicio != "cardio" && tipoEjercicio != "fuerza" && tipoEjercicio != "recreativo")
        {
            Debug.Log("El tipo de ejercicio ingresado es invalido");
            return;
        }
        if (tipoEjercicio == "cardio")
        {
            precioFinal = 1000 * horasReservadas;
        }
        if (tipoEjercicio == "fuerza")
        {
            precioFinal = 1500 * horasReservadas;
        }
        if (tipoEjercicio == "recreativo")
        {
            precioFinal = 2500 * horasReservadas;
        }
        Debug.Log("Tipo de ejercicio elegido: " + tipoEjercicio);
        Debug.Log("Cantidad de horas reservadas: " + horasReservadas);
        Debug.Log("Precio a pagar: " + precioFinal);
        if (horasReservadas == 6)
        {
            precioDescuento = precioFinal * 0.9f;
            Debug.Log("Precio descontado por reserva maxima de horas: " + precioDescuento);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
