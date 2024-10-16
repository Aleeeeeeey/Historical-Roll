using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject highlight;
    [SerializeField] private GameObject testToken;

    public void Init(bool isOffset)
    {
        //Cambiar el color del sprite si es offset o no
        spriteRenderer.color = isOffset ? offsetColor : baseColor;
    }

    private void OnMouseEnter()
    {
        //Activar el highlight al pasar el ratón por encima
        highlight.SetActive(true);
    }

    private void OnMouseExit()
    {
        //Desactivar el highlight al quitar el ratón
        highlight.SetActive(false);
    }

    private void OnMouseDown()
    {
        //Si esta listo para crear un token, se crea en la posicion del tile seleccionado
        if (GameManager.Instance.isTokenReady == true)
        {
            Instantiate(testToken, new Vector3(transform.position.x, transform.position.y, -8f), transform.rotation);
            GameManager.Instance.isTokenReady = false;
        }
    }
}
