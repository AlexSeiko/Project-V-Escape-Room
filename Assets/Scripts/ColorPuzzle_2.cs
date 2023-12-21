using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPuzzle_2 : MonoBehaviour
{
    [SerializeField] private GameObject Button1;
    [SerializeField] private GameObject Button2;
    [SerializeField] private GameObject Button3;
    [SerializeField] private GameObject Button4;

    [SerializeField] private int Button1RepeatEmission;
    [SerializeField] private int Button2RepeatEmission;
    [SerializeField] private int Button3RepeatEmission;
    [SerializeField] private int Button4RepeatEmission;

    private Material Button1Material;
    private Material Button2Material;
    private Material Button3Material;
    private Material Button4Material;

    private Coroutine SimonSaysCoroutine;

    private void Start()
    {
        List<Material> materials = new List<Material>();
        Button1.GetComponent<MeshRenderer>().GetMaterials(materials);
        Button1Material = materials[0];

        materials.Clear();
        Button2.GetComponent<MeshRenderer>().GetMaterials(materials);
        Button2Material = materials[0];

        materials.Clear();
        Button3.GetComponent<MeshRenderer>().GetMaterials(materials);
        Button3Material = materials[0];

        materials.Clear();
        Button4.GetComponent<MeshRenderer>().GetMaterials(materials);
        Button4Material = materials[0];

        Interact();
    }

    public void Interact()
    {
        if (SimonSaysCoroutine != null)
            return;

        SimonSaysCoroutine = StartCoroutine(SimonSaysLightUpObjects());
    }

    private IEnumerator SimonSaysLightUpObjects()
    {
        yield return new WaitForSeconds(1f);

        for(int i = 0; i < Button1RepeatEmission; ++i)
        {
            Button1Material.EnableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);

            Button1Material.DisableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);
        }

        for (int i = 0; i < Button2RepeatEmission; ++i)
        {
            Button2Material.EnableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);

            Button2Material.DisableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);
        }

        for (int i = 0; i < Button3RepeatEmission; ++i)
        {
            Button3Material.EnableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);

            Button3Material.DisableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);
        }

        for (int i = 0; i < Button4RepeatEmission; ++i)
        {
            Button4Material.EnableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);

            Button4Material.DisableKeyword("_EMISSION");

            yield return new WaitForSeconds(0.5f);
        }


    }
}
