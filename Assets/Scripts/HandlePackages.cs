using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePackages : MonoBehaviour
{
    int packageCount = 0;

    public int GetPackageCount() => this.packageCount;
    public void AddToPackages() => this.packageCount++;

    public void UnloadAll() => this.packageCount = 0;

}
