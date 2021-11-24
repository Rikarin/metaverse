using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class UICanvas : MonoBehaviour {
    public Camera MainCamera;

    // public GameObject Aim;
    // public GameObject Minimap;
    // public GameObject ExitMenu;
    // public UIChat Chat;
    // public UIInventory Inventory;
    // public UIStats Stats;
    // public UIVendor Vendor;
    // public UIMission Mission;

    public InputActions InputActions;
    PlayerController _playerController;
    bool _bracksAiming;

    // CameraMode CameraMode => Aim.activeSelf ? CameraMode.AimCross : CameraMode.Cursor;

    void Awake() {
        InputActions = new InputActions();
        _playerController = GameObject.Find("Avatar").GetComponent<PlayerController>();
    }

    void Start() {
        InputActions.Player.AimBracks.performed += Handle_AimBracks;
        InputActions.Player.AimBracks.canceled += Handle_AimBracksRelease;
        InputActions.Player.Minimap.performed += Handle_Minimap;
        InputActions.Player.LeftClick.performed += Handle_LeftClick;
        InputActions.Player.Exit.performed += Handle_Exit;
        InputActions.Player.Backpack.performed += Handle_Inventory;
        InputActions.Player.EnterChat.performed += Handle_Chat;
        InputActions.Player.SlashChat.performed += Handle_SlashChat;

        EnableAll();

        // Chat.IsTypingChanged += (bool isTyping) => {
        //     if (isTyping) {
        //         DisableAll();
        //     } else {
        //         EnableAll();
        //     }
        // };
    }

    void EnableAll() {
        // Player controller
        InputActions.Player.Movement.Enable();
        InputActions.Player.LeftDash.Enable();
        InputActions.Player.CameraSwitch.Enable();
        InputActions.Player.Scroll.Enable();
        InputActions.Player.Jump.Enable();
        InputActions.Player.Camera.Enable();

        InputActions.Player.AimBracks.Enable();
        InputActions.Player.Minimap.Enable();
        InputActions.Player.LeftClick.Enable();
        InputActions.Player.Exit.Enable();
        InputActions.Player.Backpack.Enable();
        InputActions.Player.EnterChat.Enable();
        InputActions.Player.SlashChat.Enable();
    }

    void DisableAll() {
        // Player controller
        InputActions.Player.Movement.Disable();
        InputActions.Player.LeftDash.Disable();
        InputActions.Player.CameraSwitch.Disable();
        InputActions.Player.Scroll.Disable();
        InputActions.Player.Jump.Disable();
        InputActions.Player.Camera.Disable();

        InputActions.Player.AimBracks.Disable();
        InputActions.Player.Minimap.Disable();
        InputActions.Player.LeftClick.Disable();
        InputActions.Player.Exit.Disable();
        InputActions.Player.Backpack.Disable();
        InputActions.Player.EnterChat.Disable();
        InputActions.Player.SlashChat.Disable();
    }

    void FixedUpdate() {
        // var mouse = Mouse.current.position;
        // Ray ray = MainCamera.ScreenPointToRay(mouse.ReadValue());
        // Debug.DrawRay(ray.origin, ray.direction * 20, Color.red);

        // if (_bracksAiming && CameraMode == CameraMode.AimCross) {
        //     HitTarget();
        // }
    }


    void Handle_AimBracks(InputAction.CallbackContext context) {
        // Aim.GetComponent<Image>().sprite = Resources.Load<Sprite>("Cursor/aim_bracks");
        _bracksAiming = true;
    }

    void Handle_AimBracksRelease(InputAction.CallbackContext context) {
        // Aim.GetComponent<Image>().sprite = Resources.Load<Sprite>("Cursor/aim_cross");
        _bracksAiming = false;
    }

    void Handle_Minimap(InputAction.CallbackContext context) {
        // Minimap.SetActive(!Minimap.activeSelf);
    }

    void Handle_LeftClick(InputAction.CallbackContext context) {
        // if (CameraMode == CameraMode.Cursor) {
        //     HitTarget();
        // }
    }

    void Handle_Exit(InputAction.CallbackContext context) {
        // if (WindowScript.CloseAll() || Stats.SetTarget(null)) {
        //     return;
        // }

        // ExitMenu.SetActive(!ExitMenu.activeSelf);
    }

    void Handle_Inventory(InputAction.CallbackContext context) {
        // ToggleInventory();
    }

    void Handle_Chat(InputAction.CallbackContext context) {
        // Chat.ShowInput();
    }

    void Handle_SlashChat(InputAction.CallbackContext context) {
        // Chat.ShowInput(true);
    }

    public void EnableAim(bool active) {
        // Aim.SetActive(active);
    }

    // void HitTarget() {
    //     RaycastHit hit;
    //     var mouse = Mouse.current.position;
    //     Ray ray = MainCamera.ScreenPointToRay(mouse.ReadValue());

    //     if (Physics.Raycast(ray, out hit)) {
    //         var unit = hit.transform.gameObject.GetComponent<Unit>();

    //         Debug.Log("hit " + unit?.ToString());

    //         if (unit && hit.distance <= (CameraMode == CameraMode.Cursor ? 50 : 400) && hit.distance > 0) {
    //             Stats.SetTarget(unit);
    //         } else if (CameraMode == CameraMode.Cursor) {
    //             Stats.SetTarget(null);
    //         }
    //     }
    // }



    // Handle menu bar
    // public void ToggleExit() {
    //     ExitMenu.SetActive(!ExitMenu.activeSelf);
    // }

    // public void ToggleInventory() {
    //     if (!Inventory.Open(false)) {
    //         Inventory.Close();
    //     }
    // }
}
