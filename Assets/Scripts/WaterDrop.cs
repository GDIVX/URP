using UnityEngine;

public class WaterDrop : MonoBehaviour
{
    public Material waterMaterial;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Ray ray = mainCamera.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                // Convert world position to UV space
                Renderer renderer = hit.collider.GetComponent<Renderer>();
                if (renderer != null)
                {
                    Vector2 uv = hit.textureCoord;
                    waterMaterial.SetVector("_HitPosition", uv);
                }
            }
        }
    }
}