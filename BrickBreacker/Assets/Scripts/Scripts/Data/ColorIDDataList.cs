using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Data
{
    [CreateAssetMenu(menuName = "Single Variables/ColorData")]
    public class ColorIDDataList : ScriptableObject
    {
        public List<ColorID> colorIDList;
        public ColorID  currentColor;

        private int num;

        public void SetCurrentColorRandomly()
        {
            num = Random.Range(0, colorIDList.Count);
            currentColor = colorIDList[num];
        }
    }
}
