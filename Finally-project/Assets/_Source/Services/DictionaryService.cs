using System.Collections.Generic;
using _Source.Blins;
using _Source.Level;
using UnityEngine;

namespace _Source.Services
{
    public static class DictionaryService
    {
        public static int  GetValue(this List<ParametersLevel> list, BlinsInfoSo key)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].key == key)
                {
                    return list[i].value;
                }
            }

            Debug.Log("Error");
            return 0;
        }
    }
}