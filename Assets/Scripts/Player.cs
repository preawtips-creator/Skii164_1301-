using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float forcePower;

    [SerializeField]
    private Rigidbody rb;
    private Vector2 moveValue;
    private InputAction moveAction;

    [SerializeField]
    private int point;
    public int Point 
    { 
        get => point; 
        set => point = value; 
    }

    [SerializeField]
    private int hp;
    public int Hp
    {
        get { return hp; }
        set { hp = value; }
    }
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeftorRight();
    }

    private void MoveLeftorRight()
    {
        moveValue = moveAction.ReadValue<Vector2>();
        rb.AddForce(moveValue.x * Vector3.right * forcePower);
    }
}
