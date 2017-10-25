using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Dial
{
    public class Dial : MonoBehaviour
    {
        public GameObject PFItem;
        public int Count;
        public float Pivot;
        public Vector2 Center;
        public float Distance;
        public float Accel;
        public float Sensitive;


        private List<GameObject> Items = new List<GameObject>();

        private void Awake()
        {
            for (int i = 0; i < Count; i++)
            {
                Items.Add(Instantiate(PFItem, this.transform));
                if (i == 0)
                {
                    Items[0].GetComponent<Image>().color = Color.green;
                }
            }
        }
        private void Start()
        {
            GetComponent<Mask>().enabled = true;
        }

        private void Update()
        {
            Vector2 pos = Vector2.zero;
            for (int i = 0; i < Count; i++)
            {
                float theta = (Mathf.PI * 2) * (((float)i / Count) + Pivot);
                pos.x = Mathf.Cos(theta);
                pos.y = -Mathf.Sin(theta);
                pos = pos * Distance + Center;
                Items[i].transform.localPosition = pos;
            }
            Pivot += Accel * 0.001f;
            Pivot = Mathf.Repeat(Pivot, 1);
            Accel *= 0.9f;
            if (Mathf.Abs(Accel) < 0.01f)
            {
                Accel = 0;
            }
        }
        /*
            for i in range(count):
            color = (255,255,255,127)
            theta = [((math.pi * 2) * (i / count)) + pivot,((math.pi * 2) * (i / count)) + pivot]
            theta[0] += curAccel
            theta[1] += curAccel
            x = int(center[0] + math.cos(theta[0]) * radius)
            y = int(center[1] + -math.sin(theta[1]) * radius)
            if i == 0:
                color = (0,255,0,127)
            pygame.draw.circle(ourScreen,color,(x,y),5)
         */
    }
}
