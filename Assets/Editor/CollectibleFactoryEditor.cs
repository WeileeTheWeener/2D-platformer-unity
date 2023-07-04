using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

[InitializeOnLoad]
[CustomEditor(typeof(CollectibleFactory))]
public class CollectibleFactoryEditor : Editor
{
    [DrawGizmo(GizmoType.NotInSelectionHierarchy | GizmoType.InSelectionHierarchy | GizmoType.Selected)]
    static void RenderCustomGizmo(Transform objectTransform, GizmoType gizmoType)
    {
        CollectibleFactory t = objectTransform.gameObject.GetComponent<CollectibleFactory>();
        if (t == null) return;

        Gizmos.color = Color.blue;
        foreach (Vector2 position in t.positions)
        {
            Gizmos.DrawSphere(position, 0.3f);
        }
    }

}