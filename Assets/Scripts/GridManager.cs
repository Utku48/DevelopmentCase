using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int gridSizeN; // satir degeri
    public int gridSizeNPrime; // Sutun degeri
    public GameObject[] gridObjectPrefab; // Grid objesinin prefab'i
    public float gapSize = 2f; // Ara bosluk boyutu


    private void Start()
    {
        // Grid oluşturma işlemi
        CreateGrid();
    }

    private void CreateGrid()
    {
        Vector3 instantiatePosition = new Vector3(transform.position.x, 1, transform.position.z);

        for (int i = 0; i < gridSizeN; i++)
        {
            for (int j = 0; j < gridSizeNPrime; j++)
            {
                int n = Random.Range(0, gridObjectPrefab.Length);
                // Grid objesini instantiate etme işlemi
                GameObject gridObject = Instantiate(gridObjectPrefab[n], instantiatePosition, Quaternion.identity);

                // Instantiate pozisyonunu güncelleme
                instantiatePosition.z += gapSize;
            }

            instantiatePosition.x += gapSize;
            instantiatePosition.z = 0f;
        }
    }
}