using UnityEditor;
using UnityEditor.FrameRecorder;
using UnityEngine;
using UnityEngine.FrameRecorder;

namespace UTJ.FrameCapturer.Recorders
{
    [CustomEditor(typeof(EXRRecorderSettings))]
    public class EXRRecorderSettingsEditor : RecorderEditorBase
    {
        protected override void OnEncodingGroupGui()
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty("m_ExrEncoderSettings"), new GUIContent("Encoding"), true);
        }

    }
}
