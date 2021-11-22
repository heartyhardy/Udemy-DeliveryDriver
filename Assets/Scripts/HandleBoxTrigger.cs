using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBoxTrigger : MonoBehaviour
{
    HandlePackages packagesComp = null;
    private void Start() {
        packagesComp = GetComponent<HandlePackages>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        switch (other.tag)
        {
            case "Package":
            Destroy(other.gameObject);
            packagesComp.AddToPackages();
            Debug.Log("Package picked up! " + packagesComp.GetPackageCount() + " Packages");
            break;
            case "Customer":
            if(packagesComp.GetPackageCount() > 0){
                Debug.Log("Delivered " + packagesComp.GetPackageCount() + " packages to customer!");
                packagesComp.UnloadAll();
                break;
            }else{
                Debug.Log("No packages to deliver!!");
                break;
            }
        }
    }
}
