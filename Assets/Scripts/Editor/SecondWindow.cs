using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SecondWindow : EditorWindow
{
  private Stitch sClass;

  public static SecondWindow ShowWindow()
  {
    SecondWindow sw = GetWindow<SecondWindow>();
    return sw;
  }

  public void setSample(Stitch sc)
  {
    sClass = sc;

  }

  private void OnGUI()
  {
    if (sClass != null)
    {
      sClass.stitchName = EditorGUILayout.TextField(sClass.stitchName);
      for (int i = 0; i < sClass.performers.Length; i++)
       {
        sClass.performers[i].order = EditorGUILayout.IntField(sClass.performers[i].order);
        //sClass.performers[i].transform =(RectTransform) EditorGUILayout.ObjectField(sClass.performers[i].transform.position,typeof(Vector3),true);
        sClass.performers[i].actorSprite = (ActorSprite)EditorGUILayout.ObjectField(sClass.performers[i].actorSprite, typeof(Sprite), true);
      }
      //sClass.status = (status) EditorGUILayout.EnumPopup(sClass.status);
      sClass.stitchID = EditorGUILayout.IntField(sClass.stitchID);
      sClass.summary = EditorGUILayout.TextArea(sClass.summary);
      for (int i = 0; i < sClass.performers.Length; i++)
       {
      sClass.yarns[i].choiceStitch = (Stitch)EditorGUILayout.ObjectField(sClass.yarns[i].choiceStitch, typeof(Yarn), true);
        sClass.yarns[i].choiceString = EditorGUILayout.TextField(sClass.yarns[i].choiceString);
       }
      sClass.background = (Sprite)EditorGUILayout.ObjectField(sClass.background,typeof(Sprite),true);
      for (int i = 0; i < sClass.dialogs.Length; i++)
      {
        sClass.dialogs[i].nameShown = EditorGUILayout.TextField(sClass.dialogs[i].nameShown);
        sClass.dialogs[i].textShown = EditorGUILayout.TextField(sClass.dialogs[i].textShown);
      }
        if (GUI.Button(new Rect(10, 260, 50, 25), "Save"))
        {
          AssetDatabase.SaveAssets();
        }
      
    }
  }

}