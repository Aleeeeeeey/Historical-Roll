using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject canvases;
    public GameObject menuCanvas;
    public GameObject aventuraCanvas;
    public GameObject fichasCanvas;
    public GameObject fichasArchivosDePjCanvas;
    public GameObject fichasNPCsYEnemigosCanvas;
    public GameObject reglasCanvas;
    public GameObject reglasDeJuegoCanvas;
    public GameObject reglasCreacionPersonajeCanvas;
    public GameObject reglasLoreYDocsCanvas;
    public GameObject chatCanvas;

    public GameObject subCanvases;
    public GameObject rCanvas;
    public GameObject tCanvas;
    public GameObject hCanvas;
    public GameObject fCanvas;

    public bool isTokenReady = false;


    void Awake()
    {
        Instance = this;
    }

    public void DeactivateCanvases()
    {
        canvases.GetComponent<DeactivateCanvas>().DeactivateCanvasChildren();
    }

    public void DeactivateSubcanvases()
    {
        subCanvases.GetComponent<DeactivateCanvas>().DeactivateCanvasChildren();
    }

    public void MenuCanvasActivate()
    {
        DeactivateCanvases();
        menuCanvas.SetActive(true);
    }

    public void AventuraCanvasActivate()
    {
        DeactivateCanvases();
        aventuraCanvas.SetActive(true);
    }

    public void FichasCanvasActivate()
    {
        DeactivateCanvases();
        fichasCanvas.SetActive(true);
    }

    public void FichasArchivosDePJsCanvasActivate()
    {
        DeactivateCanvases();
        fichasArchivosDePjCanvas.SetActive(true);
    }

    public void FichasNPCsYEnemigosCanvasActivate()
    {
        DeactivateCanvases();
        fichasNPCsYEnemigosCanvas.SetActive(true);
    }

    public void ReglasCanvasActivate()
    {
        DeactivateCanvases();
        reglasCanvas.SetActive(true);
    }

    public void ReglasDeJuegoCanvasActivate()
    {
        DeactivateCanvases();
        reglasDeJuegoCanvas.SetActive(true);
    }

    public void ReglasCreacionPersonajeCanvasActivate()
    {
        DeactivateCanvases();
        reglasCreacionPersonajeCanvas.SetActive(true);
    }

    public void ReglasLoreYDocsCanvasActivate()
    {
        DeactivateCanvases();
        reglasLoreYDocsCanvas.SetActive(true);
    }

    public void SubCanvasRActivate()
    {
        DeactivateSubcanvases();
        rCanvas.SetActive(true);
    }

    public void SubCanvasTActivate()
    {
        DeactivateSubcanvases();
        tCanvas.SetActive(true);
    }

    public void SubCanvasHActivate()
    {
        DeactivateSubcanvases();
        hCanvas.SetActive(true);
    }

    public void SubCanvasFActivate()
    {
        DeactivateSubcanvases();
        fCanvas.SetActive(true);
    }

    public void ChatCanvasActivate()
    {
        chatCanvas.SetActive(true);
    }

    public void ChatCanvasDeactivate()
    {
        chatCanvas.SetActive(false);
    }

    public void PrepareToSpawnToken()
    {
        isTokenReady = true;
    }
}
