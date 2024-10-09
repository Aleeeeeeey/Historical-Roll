using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private Color baseColor, offsetColor;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject highlight;

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
}
