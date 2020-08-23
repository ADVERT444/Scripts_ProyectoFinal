//Nombre del desarrollador: Francisco Javier Ochoa
//Asignatura: Estructura de Datos
//Descripción del uso de este código:
/*
 Este script sirve para dotar de un patrón de movimiento sencillo, de un lado a otro (VERTICAL), a los objetos enemigos que lo tengan.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSeno : MonoBehaviour
{
    //Declaro la variable para punto inicial, para velocidad y para la distancia hasta la cuál va a llegar el patrón del enemigo.
    [SerializeField]
    Vector3 puntoInicial;

    [SerializeField]
    float velocidad;

    [SerializeField]
    float extension;
    

    // Start  - sirve para inicializar datos, componentes y variables una sola vez al comienzo.
    void Start()
    {
        //Con esto, variable punto inicial va a caputrar la información de posición del poseedor del script accediendo a su componente trasform
        //tal cual está en Unity.
        puntoInicial = transform.position;

    }

    // Update  - sirve para utilizar los datos, componentes y variables pues se refresca continuamente; una vez por cada frame.
    void Update()
    {
        //Creamos la variable posSeno que va a alojar el valor del eje específico donde queremos que funcione esta operación matemática para transformar
        //su posición. Esto se va a poner en el lugar de Y, pues ahí es donde quiero que ocurra el movimiento, indicando también la velocidad
        //y hasta dónde va a llegar (extensión).
        Vector3 posSeno = new Vector3(0,Mathf.Sin(Time.time*velocidad)*extension, 0);

        //Sirve esta linea para que la posición del componente transform se actualice tomando en cuenta (sumando) el resultado de la operación anterior
        //(alojado en la variable posSeno)
        transform.position = puntoInicial + posSeno;
    }
}
