using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

// Attaches ZebraRows.uss to every editor window so UI Toolkit lists (the Hierarchy and others)
// draw their alternating rows as a subtle accent instead of the default light-gray stripes.
// Editor/StyleSheets/Extensions only reaches IMGUI styles, so the sheet is added per window here.
[InitializeOnLoad]
static class EditorZebraRows
{
    // GUID of ZebraRows.uss (from its .meta), so the folder can live anywhere under Assets.
    const string k_StyleSheetGuid = "d6b79e488ea35e946a429f842ba64915";

    static StyleSheet s_StyleSheet;

    static EditorZebraRows()
    {
        EditorApplication.delayCall += ApplyToAllWindows;
        EditorWindow.windowFocusChanged += ApplyToAllWindows;
    }

    static void ApplyToAllWindows()
    {
        if (s_StyleSheet == null)
            s_StyleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>(AssetDatabase.GUIDToAssetPath(k_StyleSheetGuid));
        if (s_StyleSheet == null)
            return;

        foreach (var window in Resources.FindObjectsOfTypeAll<EditorWindow>())
        {
            var root = window.rootVisualElement;
            if (!root.styleSheets.Contains(s_StyleSheet))
                root.styleSheets.Add(s_StyleSheet);
        }
    }
}
