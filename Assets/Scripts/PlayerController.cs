using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public enum CameraMode {
    AimCross,
    Cursor
}

public class PlayerController : MonoBehaviour {
    // public delegate void OnMovementUpdate(Vector3 position, float orientation);
    // public event OnMovementUpdate OnMovementUpdate;

    public CharacterController Controller;
    public CinemachineFreeLook CinemachineFreeLook;
    public Transform Camera;
    public float Speed = 24f;
    public float turnSmoothTime = 0.1f;
    public float Gravity = -9.81f;

    public Transform GroundCheck;
    public LayerMask GroundMask;
    public float GroundDistance = 0.4f;
    public float JumpHeight = 10f;

    UICanvas _uiCanvas;
    InputActions _inputActions;
    UnityEngine.Vector3 _moveAxis;
    UnityEngine.Vector3 _velocity;
    bool _isGrounded;
    float _turnSmoothVelocity;

    public CameraMode CameraMode { get; private set; } = CameraMode.Cursor;

    void Start() {
        _uiCanvas = GameObject.Find("Canvas").GetComponent<UICanvas>();
        _inputActions = _uiCanvas.InputActions;

        _inputActions.Player.Movement.performed += Handle_Movement;
        _inputActions.Player.Movement.canceled += ctx => _moveAxis = Vector2.zero;
        _inputActions.Player.LeftDash.performed += Handle_LeftDash;
        _inputActions.Player.CameraSwitch.performed += Handle_CameraSwitch;
        _inputActions.Player.Scroll.performed += Handle_Scroll;
        _inputActions.Player.Jump.performed += Handle_Jump;

        CinemachineCore.GetInputAxis = GetAxisCustom;
    }

    void Update() {
        _isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);

        if (_moveAxis.magnitude >= 0.1f) {
            var targetAngle = Mathf.Atan2(_moveAxis.x, _moveAxis.z) * Mathf.Rad2Deg + Camera.eulerAngles.y;
            var angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            var direction = Quaternion.Euler(0f, targetAngle, 0f) * UnityEngine.Vector3.forward;
            Controller.Move(direction * Speed * Time.deltaTime);

            // var p = transform.position;
            // Network.Send(new ClientPlayerMovement {
            //     MovementInfo = new MovementInfo {
            //         Position = new Position(p.x, p.y, p.z, transform.rotation.y),
            //         MovementFlags = MovementFlags.Forward
            //     }
            // });
        }

        if (_isGrounded && _velocity.y < 0) {
            _velocity.y = 0f;
        }

        _velocity.y += Gravity * Time.deltaTime;
        Controller.Move(_velocity * Time.deltaTime);
    }

    void Handle_Movement(InputAction.CallbackContext context) {
        var direction = context.ReadValue<Vector2>();
        _moveAxis = new UnityEngine.Vector3(direction.x, 0f, direction.y).normalized;
    }

    void Handle_LeftDash(InputAction.CallbackContext context) {
        Debug.Log("left dash");
    }

    void Handle_Jump(InputAction.CallbackContext context) {
        _velocity.y = Mathf.Sqrt(JumpHeight * -2f * Gravity);
    }

    void Handle_CameraSwitch(InputAction.CallbackContext context) {
        bool willCursor = CameraMode == CameraMode.AimCross;
        CameraMode = willCursor ? CameraMode.Cursor : CameraMode.AimCross;

        Cursor.visible = willCursor;
        Cursor.lockState = !willCursor ? CursorLockMode.Locked : CursorLockMode.None;

        // _uiCanvas.EnableAim(!willCursor);
    }

    void Handle_Scroll(InputAction.CallbackContext context) {
        var scroll = context.ReadValue<float>();
        var newRadius = CinemachineFreeLook.m_Orbits[1].m_Radius + scroll / 10f;

        if (newRadius >= 8f && newRadius <= 30f) {
            CinemachineFreeLook.m_Orbits[0].m_Height += scroll / 10f;
            CinemachineFreeLook.m_Orbits[1].m_Radius += scroll / 10f;
        }
    }

    float GetAxisCustom(string axisName) {
        if (CameraMode == CameraMode.Cursor) {
            if (axisName == "Mouse X") {
                return -_moveAxis.x;
            }

            // TODO: interpolate Mouse Y to 65 or something degrees during movement
        } else {
            var lookDelta = _inputActions.Player.Camera.ReadValue<Vector2>();
            if (axisName == "Mouse X") {
                return lookDelta.x;
            } else if (axisName == "Mouse Y") {
                return lookDelta.y;
            }
        }

        return 0;
    }
}
