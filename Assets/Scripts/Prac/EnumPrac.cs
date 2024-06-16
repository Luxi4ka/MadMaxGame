using UnityEngine;

public class EnumPrac : MonoBehaviour
{
   // [SerializeField] private int[] array;
   // [SerializeField] private int[] array2;
  //  private void Start()
  ///  {
  //      for (int i = 0; i < array.Length; i++)
  //      {
  //          array2[array[i]]++;
  //      }
 //   }
    public enum CarType
    {
        Porshe = 1,
        Skoda = 2,
        Mustang = 3,
        Golf = 4,
        Mini = 5,
        Vaz = 6,
        GMC = 7,
        Audi = 8,
    }
    public CarType car;
    public CarType[] cars;
    private void Start()
    {
        switch (car)
        {
            case CarType.Mustang:
                print(":)");
                break;
            case CarType.GMC:
                print("USA");
                break;
            case CarType.Skoda:
                print("SK");
                break;
        }   
    }
    
}
