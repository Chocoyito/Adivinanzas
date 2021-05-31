using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroMagico : MonoBehaviour
{
    int nuMax;
    int nuMin;
    int adivinanza;

    // Start es el metodo inicializador previo a Update (Start sólo se ejecuta una vez en todo el proceso).
    void Start()
    {
        comenzarJuego();
    }

    void comenzarJuego()
    {
        nuMax = 1000;
        nuMin = 1;
        adivinanza = 500;
        
        Debug.Log("Qué onda mae. ¡Bienvenido al número \"mágico (¿?)\"!");
        Debug.Log("Vamo' a adivinar puej.");
        Debug.Log("Comenzando el número máximo es igual a " + nuMax + " y el número mínimo es igual a " + nuMin);
        Debug.Log("Entonces te pregunto... ¿Es tu número igual a " + adivinanza + "?");
        Debug.Log("Flecha superior: Número mayor | Flecha inferior: Número menor | Enter: Número correcto");

        nuMax = nuMax + 1;  /* Esto se hizo por la razón de que al llegar a 999 presionando la flecha superior, 1000 + 999 = 1999 entre 2 es
        igual a 999, lo que nunca permite que el número pensado igual a 1000 sea posible, entonces si 1001 + 999 = 2000 entre 2 es igual a 1000
        el usuario podrá llegar hasta 1000 como el deseaba y no infinitamente hasta 999. */
    }

    // Update ejecuta en tiempo real cada acción realizada por el usuario.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))  // Si el usuario presiona hacia arriba significa que su número pensado es mayor al planteado.
        {
            nuMin = adivinanza;
            siguienteAdivinanza();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))   // Caso contrario si presiona hacia abajo significa que su número es menor.
        {
            nuMax = adivinanza;
            siguienteAdivinanza();
        }
        else if (Input.GetKeyDown(KeyCode.Return))  // Si el número es adivinado el usuario presionará "Enter" y el programa finalizará.
        {
            Debug.Log("Soy la bestia.");
            comenzarJuego();
        }
    }

    void siguienteAdivinanza()
    {
        adivinanza = (nuMax + nuMin) / 2;
        Debug.Log("¿Es tu número mayor o menor que " + adivinanza + "?");
    }
}
