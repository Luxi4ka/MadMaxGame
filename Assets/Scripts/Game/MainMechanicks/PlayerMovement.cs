using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float currentSpeed;
    public float deafultSpeed;
    public float acceliration;
    public float brackeing;
    public float timeInvoke;
    public float minSpeed;

    public bool canHangle;
    public float boosterFloat;
    public Slider boosterSlider;
    public float boostedSpeed;
    public void Awake()
    {
        if (PlayerPrefs.GetInt("Engine")==1)
        {
            deafultSpeed += 3;
        }
        currentSpeed = deafultSpeed;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(currentSpeed, 0);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.S)&& canHangle)
        {
            Turn(-currentSpeed);
        }
        if (Input.GetKey(KeyCode.W) && canHangle)
        {
            Turn(currentSpeed);
        }
        if (currentSpeed < deafultSpeed)
        {
            if(currentSpeed < minSpeed)
            {
                currentSpeed = minSpeed;
            }
            currentSpeed += acceliration * Time.deltaTime;
        }
        else if(currentSpeed > deafultSpeed)
        {
            currentSpeed -= brackeing * Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(currentSpeed, rb.velocity.y);
    }
    public void Turn(float speed)
    {
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }
    public float GetSpeed()
    {
        return currentSpeed;
    }
    public float GetDeafultSpeed()
    {
        return deafultSpeed;
    }
    public void SetSpeed(float decreasedSpeed)
    {
        currentSpeed -= decreasedSpeed;
    }
    public void PushForce(float force)
    {
        currentSpeed = force;
    }
    public void LockTurn()
    {
        canHangle = false;
        Invoke(nameof(UnlockTurn), timeInvoke);
    }
    public void UnlockTurn()
    {
        canHangle = true;
    }
    public void EnableScript()
    {
        enabled = true;
        rb.drag = 5;
    }
}
