using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement _playerMovement;

    int _screenWidth;

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
    }

    private void Start()
    {
        _screenWidth = Camera.main.pixelWidth;
    }

    private void Update()
    {
#if UNITY_EDITOR
        KeyboardInput();
#endif

        MobileInput();
    }

    private void MobileInput()
    {
        if (!Input.GetMouseButton(0)) return;
        var pos = Input.mousePosition;
            
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            if (pos.x > (_screenWidth / 2))
                _playerMovement.RightTurn();
            else
                _playerMovement.LeftTurn();
        }
    }

    private void KeyboardInput()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _playerMovement.RightTurn();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerMovement.LeftTurn();
        }
    }
}
