using UnityEngine;
using UnityEngine.SceneManagement;

public class PlantillaLeanTween : MonoBehaviour
{
    private GameObject objetoAAnimar;
    private float duracion = 1.0f;
    private LeanTweenType tipoDeEasing = LeanTweenType.easeOutQuad;

    private void Start()
    {
        // Asigna el objeto que deseas animar
        objetoAAnimar = GameObject.Find("ObjetoAnimado");

        // Llama a las funciones de animación
        AnimarPosicion();     // Anima la posición del objeto
        AnimarEscala();       // Anima la escala del objeto
        AnimarRotacion();     // Anima la rotación del objeto
        AnimarOpacidad();     // Anima la opacidad (alfa) del objeto
        AnimarColor();        // Anima el color del objeto
        AnimarPosicionX();    // Anima la posición en el eje X
        AnimarPosicionY();    // Anima la posición en el eje Y
        AnimarPosicionZ();    // Anima la posición en el eje Z
        AnimarEscalaX();      // Anima la escala en el eje X
        AnimarEscalaY();      // Anima la escala en el eje Y
        AnimarRotacionX();    // Anima la rotación en el eje X
        AnimarRotacionY();    // Anima la rotación en el eje Y
        AnimarRotacionZ();    // Anima la rotación en el eje Z
        AnimarDelay();        // Anima con un retraso
        AnimarCallback();     // Anima con llamada de retorno
        AnimarBuclePingPong(); // Anima con bucle pingpong
        AnimarBucleSimple(); // Anima con bucle simple
        CancelarAnimaciones(); // Cancela todas las animaciones
    }

    // Anima la posición del objeto
    private void AnimarPosicion()
    {
        LeanTween.move(objetoAAnimar, new Vector3(3f, 2f, 0f), duracion).setEase(tipoDeEasing);
    }

    // Anima la escala del objeto
    private void AnimarEscala()
    {
        LeanTween.scale(objetoAAnimar, new Vector3(2f, 2f, 2f), duracion).setEase(tipoDeEasing);
    }

    // Anima la rotación del objeto
    private void AnimarRotacion()
    {
        LeanTween.rotate(objetoAAnimar, new Vector3(0f, 90f, 0f), duracion).setEase(tipoDeEasing);
    }

    // Anima la opacidad (alfa) del objeto
    private void AnimarOpacidad()
    {
        LeanTween.alpha(objetoAAnimar, 0f, duracion).setEase(tipoDeEasing);
    }

    // Anima el color del objeto
    private void AnimarColor()
    {
        LeanTween.color(objetoAAnimar, Color.red, duracion).setEase(tipoDeEasing);
    }

    // Anima la posición en el eje X
    private void AnimarPosicionX()
    {
        LeanTween.moveX(objetoAAnimar, 5f, duracion).setEase(tipoDeEasing);
    }

    // Anima la posición en el eje Y
    private void AnimarPosicionY()
    {
        LeanTween.moveY(objetoAAnimar, 3f, duracion).setEase(tipoDeEasing);
    }

    // Anima la posición en el eje Z
    private void AnimarPosicionZ()
    {
        LeanTween.moveZ(objetoAAnimar, 1f, duracion).setEase(tipoDeEasing);
    }

    // Anima la escala en el eje X
    private void AnimarEscalaX()
    {
        LeanTween.scaleX(objetoAAnimar, 2f, duracion).setEase(tipoDeEasing);
    }

    // Anima la escala en el eje Y
    private void AnimarEscalaY()
    {
        LeanTween.scaleY(objetoAAnimar, 2f, duracion).setEase(tipoDeEasing);
    }

    // Anima la rotación en el eje X
    private void AnimarRotacionX()
    {
        LeanTween.rotateX(objetoAAnimar, 45f, duracion).setEase(tipoDeEasing);
    }

    // Anima la rotación en el eje Y
    private void AnimarRotacionY()
    {
        LeanTween.rotateY(objetoAAnimar, 90f, duracion).setEase(tipoDeEasing);
    }

    // Anima la rotación en el eje Z
    private void AnimarRotacionZ()
    {
        LeanTween.rotateZ(objetoAAnimar, 180f, duracion).setEase(tipoDeEasing);
    }

    // Anima con un retraso
    private void AnimarDelay()
    {
        LeanTween.delayedCall(1.0f, () => {
            // Código a ejecutar después del retraso de 1 segundo
            AnimarEscala();
        });
    }

    // Anima con llamada de retorno, es decir, código que se ejecutará cuando
    // termina la animación.
    private void AnimarCallback()
    {
        LeanTween.move(objetoAAnimar, new Vector3(3f, 2f, 0f), duracion).setOnComplete(() => {
            // Código a ejecutar al final de la animación
        });
    }

    // Anima con bucle, un número de veces concreta,pero en cada repetición, se invertirá.
    // Es decir, el objeto se moverá hacia adelante y hacia atrás, como si estuviera rebotando.
    private void AnimarBuclePingPong()
    {
        LeanTween.moveX(objetoAAnimar, 5f, duracion).setLoopPingPong(3);
    }

    // Anima con bucle; la animación se repetirá 3 veces antes de detenerse.
    // La animación se repetirá en bucle, pero no se invertirá.
    private void AnimarBucleSimple()
    {
        LeanTween.moveX(objetoAAnimar, 5f, duracion).setRepeat(3);
    }

    // Cancela todas las animaciones
    private void CancelarAnimaciones()
    {
        LeanTween.cancel(objetoAAnimar);
    }

}

