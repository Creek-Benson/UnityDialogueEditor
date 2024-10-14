using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AG.Dialogue
{
    [System.Serializable]
    public class EndData : BaseData
    {
        public Container_EndNodeType EndNodeType = new Container_EndNodeType();
    }
}