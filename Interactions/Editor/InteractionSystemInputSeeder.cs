using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

namespace Kandooz.Interactions.Editor
{
    [ScriptedImporter(1, "kandooz")]
    public class InteractionSystemInputSeeder : ScriptedImporter
    {
        /// <summary>
        /// this list is copied from unity SeedXR Binding
        /// </summary>
        private List<(string name, string descriptiveName, float dead, int axis, int type, string positiveButton, float gravity, float sensitivity)> axisList =
            new()
            {
                #region LeftHand

                //######################################################################################################################################
                // Left Hand
                //######################################################################################################################################  
                // Axis Data
                new()
                {
                    name = "XRI_Left_Primary2DAxis_Vertical",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 2,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_Primary2DAxis_Horizontal",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 1,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_Secondary2DAxis_Vertical",
                    descriptiveName = "Device joystick/touchpad horizontal motion.",
                    dead = 0.19f,
                    axis = 18,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_Secondary2DAxis_Horizontal",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 17,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_Trigger",
                    descriptiveName = "Device trigger axis",
                    axis = 9,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_Grip",
                    descriptiveName = "Device grip axis",
                    axis = 11,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_IndexTouch",
                    descriptiveName = "Device index finger proximity touch axis.",
                    dead = 0.19f,
                    axis = 13,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Left_ThumbTouch",
                    descriptiveName = "Device thumb proximity touch axis",
                    dead = 0.19f,
                    axis = 15,
                    type = 2,
                },
                // Button Data
                new()
                {
                    name = "XRI_Left_PrimaryButton",
                    descriptiveName = "Device primary button",
                    positiveButton = "joystick button 2",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_SecondaryButton",
                    descriptiveName = "Device secondary button",
                    positiveButton = "joystick button 3",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_PrimaryTouch",
                    descriptiveName = "Device primary touch",
                    positiveButton = "joystick button 12",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_SecondaryTouch",
                    descriptiveName = "Device secondary button",
                    positiveButton = "joystick button 13",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_GripButton",
                    descriptiveName = "Device grip button",
                    positiveButton = "joystick button 4",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_TriggerButton",
                    descriptiveName = "Device trigger button",
                    positiveButton = "joystick button 14",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_MenuButton",
                    descriptiveName = "Device menu button",
                    positiveButton = "joystick button 6",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_Primary2DAxisClick",
                    descriptiveName = "Device stick/touchpad click",
                    positiveButton = "joystick button 8",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_Primary2DAxisTouch",
                    descriptiveName = "Device stick/touchpad touch",
                    positiveButton = "joystick button 16",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Left_Thumbrest",
                    descriptiveName = "Device thumbrest",
                    positiveButton = "joystick button 18",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },

                #endregion

                #region RightHand

                //######################################################################################################################################
                // Right Hand
                //######################################################################################################################################
                new()
                {
                    name = "XRI_Right_Primary2DAxis_Vertical",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 5,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_Primary2DAxis_Horizontal",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 4,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_Secondary2DAxis_Vertical",
                    descriptiveName = "Device joystick/touchpad horizontal motion.",
                    dead = 0.19f,
                    axis = 20,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_Secondary2DAxis_Horizontal",
                    descriptiveName = "Device joystick/touchpad horizontal motion",
                    dead = 0.19f,
                    axis = 19,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_Trigger",
                    descriptiveName = "Device trigger axis",
                    axis = 10,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_Grip",
                    descriptiveName = "Device grip axis",
                    axis = 12,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_IndexTouch",
                    descriptiveName = "Device index finger proximity touch axis.",
                    dead = 0.19f,
                    axis = 14,
                    type = 2,
                },
                new()
                {
                    name = "XRI_Right_ThumbTouch",
                    descriptiveName = "Device thumb proximity touch axis",
                    dead = 0.19f,
                    axis = 16,
                    type = 2,
                },
                // Button Data
                new()
                {
                    name = "XRI_Right_PrimaryButton",
                    descriptiveName = "Device primary button",
                    positiveButton = "joystick button 0",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_SecondaryButton",
                    descriptiveName = "Device secondary button",
                    positiveButton = "joystick button 1",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_PrimaryTouch",
                    descriptiveName = "Device primary touch",
                    positiveButton = "joystick button 10",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_SecondaryTouch",
                    descriptiveName = "Device secondary button",
                    positiveButton = "joystick button 11",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_GripButton",
                    descriptiveName = "Device grip button",
                    positiveButton = "joystick button 5",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_TriggerButton",
                    descriptiveName = "Device trigger button",
                    positiveButton = "joystick button 15",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_MenuButton",
                    descriptiveName = "Device menu button",
                    positiveButton = "joystick button 7",
                    gravity = 1000.0f,
                    sensitivity = 1000.0f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_Primary2DAxisClick",
                    descriptiveName = "Device stick/touchpad click",
                    positiveButton = "joystick button 9",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_Primary2DAxisTouch",
                    descriptiveName = "Device stick/touchpad touch",
                    positiveButton = "joystick button 17",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "XRI_Right_Thumbrest",
                    descriptiveName = "Device thumbrest",
                    positiveButton = "joystick button 19",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },

                #endregion

                #region UGuiRequired

                //######################################################################################################################################
                // UGui Required
                //######################################################################################################################################
                new()
                {
                    name = "Submit",
                    descriptiveName = "Submit",
                    positiveButton = "joystick button 0",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "Cancel",
                    descriptiveName = "Cancel",
                    positiveButton = "joystick button 1",
                    gravity = 0.0f,
                    dead = 0.0f,
                    sensitivity = 0.1f,
                    type = 0,
                },
                new()
                {
                    name = "Horizontal",
                    descriptiveName = "Horizontal",
                    dead = 0.19f,
                    axis = 4,
                    type = 2,
                },
                new()
                {
                    name = "Vertical",
                    descriptiveName = "Vertical",
                    dead = 0.19f,
                    axis = 5,
                    type = 2,
                },

                #endregion

                //######################################################################################################################################
                // Combined Trigger
                //######################################################################################################################################

                #region Combined

                new()
                {
                    name = "XRI_Combined_Trigger",
                    descriptiveName = "Combined Trigger",
                    dead = 0.19f,
                    axis = 3,
                    type = 2,
                },
                new()
                {
                    name = "XRI_DPad_Vertical",
                    descriptiveName = "Device directional pad. These values are replicated l/r",
                    axis = 7,
                    type = 2,
                },
                new()
                {
                    name = "XRI_DPad_Horizontal",
                    descriptiveName = "Device directional pad. These values are replicated l/r",
                    axis = 6,
                    type = 2,
                },

                #endregion
            };

        public override void OnImportAsset(AssetImportContext ctx)
        {
            var inputManagerAsset = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0];
            var serializedObject = new SerializedObject(inputManagerAsset);
            var axis = serializedObject.FindProperty("m_Axes");
            if (axis is not { isArray: true }) return;
            var count = axis.arraySize;
            for (int i = 0; i < count; i++)
            {
                var name = axis.GetArrayElementAtIndex(i).FindPropertyRelative("m_Name")?.stringValue;
                if (name != null )
                {
                    FindAndRemoveItem(name);
                }
            }
            for (var i = 0; i < axisList.Count; i++)
            {
                var axe = axisList[i];
                axis.InsertArrayElementAtIndex(count + i);
                var property = axis.GetArrayElementAtIndex(count + i);
                property.FindPropertyRelative("m_Name").stringValue = axe.name;
                property.FindPropertyRelative("descriptiveName").stringValue = axe.descriptiveName;
                property.FindPropertyRelative("positiveButton").stringValue = axe.positiveButton;
                property.FindPropertyRelative("gravity").floatValue = axe.gravity;
                property.FindPropertyRelative("dead").floatValue = axe.dead;
                property.FindPropertyRelative("sensitivity").floatValue = axe.sensitivity;
                property.FindPropertyRelative("type").intValue = axe.type;
                property.FindPropertyRelative("axis").intValue = axe.axis;
            }

            serializedObject.ApplyModifiedProperties();
        }

        private void FindAndRemoveItem(string name)
        {
            var index=axisList.FindIndex(tuple => tuple.name == name);
            if(index>=0) 
                axisList.RemoveAt(index);
        }
    }
}