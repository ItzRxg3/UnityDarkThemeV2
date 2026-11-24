<img width="2559" height="1377" alt="image" src="https://github.com/user-attachments/assets/34f7affa-a784-4705-97e4-0463710eb104" />

Originally made by [@haywirephoenix](https://github.com/haywirephoenix/UnityBlackTheme/tree/main)  
Modified by [@ItzRxg3](https://github.com/ItzRxg3/)  

Drop it in your Assets folder and Unity Editor will instantly turn near-black (`#141414`).  
Note: To turn the menus and top bar black, you can also install [UnityEditorDarkMode](https://github.com/0x7c13/UnityEditor-DarkMode)

## Subtle Hierarchy stripes (Unity 6 UI Toolkit Hierarchy)
The newer UI Toolkit Hierarchy ignores `StyleSheets/Extensions`, so its alternating rows stay light gray (`#3f3f3f`).
`Editor/EditorZebraRows.cs` attaches `Editor/StyleSheets/ZebraRows.uss` to every editor window and turns them into a subtle `#1c1c1c` accent; hover and selection highlights still work. Tested on Unity 6000.6.

- Change the tone: edit the color in `ZebraRows.uss`.
- No stripes at all: Preferences → General → disable **Enable Alternating Row Background**.
