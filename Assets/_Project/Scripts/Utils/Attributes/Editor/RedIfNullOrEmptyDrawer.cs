using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(RedIfNullOrEmptyAttribute))]
public class RedIfNullOrEmptyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        
        if (CheckNullOrDefaultProperty(property))
        {
            var color = GUI.color;
            GUI.color = Color.red;
            EditorGUI.PropertyField(position, property, label);
            GUI.color = color;
        }
        else
        {
            EditorGUI.PropertyField(position, property, label);
        }        
    }

    private bool CheckNullOrDefaultProperty(SerializedProperty property)
    {
        switch (property.propertyType)
        {
            case SerializedPropertyType.Integer:
                return property.intValue == default;
            case SerializedPropertyType.Float:
                return property.floatValue == default;
            case SerializedPropertyType.String:
                return string.IsNullOrEmpty(property.stringValue);
            case SerializedPropertyType.ObjectReference:
                return property.objectReferenceValue == null;
            default:
                return false;
        }
    }
}
