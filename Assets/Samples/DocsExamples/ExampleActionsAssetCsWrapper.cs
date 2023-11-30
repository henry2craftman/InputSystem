using UnityEngine;
using UnityEngine.InputSystem;

public class DocsExampleActionsAssetCsWrapper : MonoBehaviour
{
    // this field will contain the actions wrapper instance
    ExampleActions actions;

    void Awake()
    {
        // instantiate the actions wrapper class
        actions = new ExampleActions();

        // for the "jump" action, we add a callback method for when it is performed
        actions.gameplay.jump.performed += OnJump;
    }

    Vector2 moveVector;
    void Update()
    {
        // our update loop polls the "move" action value each frame
        moveVector = actions.gameplay.move.ReadValue<Vector2>();
        transform.position += new Vector3(moveVector.x, 0, moveVector.y) * Time.deltaTime;
    }

    private void OnJump(InputAction.CallbackContext context)
    {
        // this is the "jump" action callback method
        Debug.Log("Jump!");
    }

    void OnEnable()
    {
        actions.gameplay.Enable();
    }

    void OnDisable()
    {
        actions.gameplay.Disable();
    }
}
