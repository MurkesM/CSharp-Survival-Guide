using UnityEngine;

public class TestCommandPattern : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Cube")
                {
                    Color randomColor = new(Random.value, Random.value, Random.value);

                    new CubeClickCommand(hit.transform.gameObject, randomColor);
                }
            }
        }
    }
}