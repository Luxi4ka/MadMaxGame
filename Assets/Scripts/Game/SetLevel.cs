using UnityEngine;

public class SetLevel : MonoBehaviour
{
    private void OnValidate()
    {
        var startLvl = GetComponentsInChildren<StartLvl>();
        for (int i = 0; i < startLvl.Length; i++)
        {
            transform.GetChild(i).name = $"Lvl {i + 1}";
            startLvl[i].ChangeIndex(i + 1);
        }
    }
}
