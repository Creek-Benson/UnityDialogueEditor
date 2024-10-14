using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note
{
    /*
        - Editor Window
            L Scriptable Object (OnEnable, OnDisable, OnDestroy,)
            L ShowWindow
                L OnOpenAsset(0)
                L instanceId
                L line (just ignore)
        - Graph View
            L Manipulators
            L Zoom
            L Grid Background
            L Callbacks
                L graphViewChanged
                L nodeCreationRequest
                L deleteSelection
            L GetCompatiblePorts
        - Search Window
            L Search Tree Entries
                L Group Entry
                    L GUIContent
                        L image (icon)
                        L text
                    L Level
                L Normal Entry
                    L User Data
        - Visual Element
            L Create your own
            L Built in
                L Button
                    L ClickEvent
                L Fields
                    L Text Field, Float Field etc...
                    L valueChangedEvent
                        L evt
                            L newValue
                L Node
                    L Set Position
                    L GUID
                    L Methods
                        L RefreshExpandedState
                        L RefreshPorts
                    L Containers
                        L Title
                        L Content
                        L Input/Output
                L Port
                    L Orientation
                    L Direction
                    L Capacity
                L Edge
                    L input / output
            L RegisterCallback<MouseUp/DownEvent, FocusIn/OutEvent etc...>
        - Style Sheet
            L USS
        - Debug
            L Editor Built-in debug tools
                L UI Toolkit Debugger (Window -> UI Toolkit -> Debugger)
                L Event Debugger (Window -> UI Toolkit -> Event Debugger)
     */
}
