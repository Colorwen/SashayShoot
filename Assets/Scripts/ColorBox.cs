using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorBox : MonoBehaviour
{

    //颜色总图片列表
    public Texture[] colorTextures;

    //颜色总图片字典
    public static Dictionary<string, Texture> colorTexturesDic = new Dictionary<string, Texture>();

    void Awake()
    {
        if (colorTextures.Length > 0)
        {
            for (int i = 0; i < colorTextures.Length; i++)
            {
                if (!colorTexturesDic.ContainsKey(colorTextures[i].name))
                    colorTexturesDic.Add(colorTextures[i].name, colorTextures[i]);
            }
        }
    }
}
