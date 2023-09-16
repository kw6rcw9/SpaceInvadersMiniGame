using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Movement
{
    public interface IMovable
    {
        async Task Move(float dist, List<GameObject> objects, float speed)
        {
            await Task.Yield();
        }
    }
}
