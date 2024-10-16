using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{

    public void OnMouseDrag()
    {
        //Se crea un vector para igualar la posicion del raton a la camara
        Vector3 screenPoint = Input.mousePosition;
        //Se establece una posicion fija en el eje z
        screenPoint.z = 10.0f;
        //Se iguala la posicion del raton a la camara, y se establece que la posicion del objeto sea la misma
        transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
    }

    public void OnMouseUp()
    {
        //Se redondean las coordenadas del token para que haga un snap a las tiles
        Vector3 tmp = transform.position;
        tmp.x = Mathf.Round(transform.position.x);
        tmp.y = Mathf.Round(transform.position.y);
        transform.position = tmp;
    }
    
}
