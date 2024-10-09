using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int width, height;
    [SerializeField] private Tile tilePrefab;
    [SerializeField] private Transform cam;

    private void Start()
    {
        //Que genere un grid al ejecutarse el programa
        GenerateGrid();
    }

    void GenerateGrid()
    {
        //Se eligen numero de filas y columnas
        for (int x = 0 ; x < width; x++)
        {
            for (int y = 0 ; y < height; y++)
            {
                //Se instancia la tile
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x, y), Quaternion.identity);
                //Cada tile se nombra por sus coordenadas
                spawnedTile.name = $"Tile {x} {y}";

                //Se averigua si sus coordenadas son pares o impares en x e y 
                var isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                //Si se cumple lo de arriba, la tile spawnea como "offset"
                spawnedTile.Init(isOffset);
            }
        }
        //Para que la camara se centre en el grid
        //cam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);
    }
}
