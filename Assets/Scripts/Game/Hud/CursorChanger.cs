using UnityEngine;

public class CursorChanger : MonoBehaviour
{
  public void ChangeCursor(Texture2D setCursor)
  {
        Cursor.SetCursor(setCursor, Vector3.zero, CursorMode.Auto);
  }
}
