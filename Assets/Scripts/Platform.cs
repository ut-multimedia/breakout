using UnityEngine;

public class Platform : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 mostLeftPoint = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 mostRightPoint = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float platformWidth = transform.localScale.x / 2;
        mostLeftPoint.x += platformWidth;
        mostRightPoint.x -= platformWidth;
        
        float clampedX = Mathf.Clamp(worldPoint.x, mostLeftPoint.x, mostRightPoint.x);
        
        var tempPosition = transform.position;
        tempPosition.x = clampedX;
        transform.position = tempPosition;
    }
}
