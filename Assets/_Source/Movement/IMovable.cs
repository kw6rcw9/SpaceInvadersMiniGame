using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Movement
{
    public interface IMovable
    {
        public void Move(float dist, float speed, List<Transform> objects);



    }
}
