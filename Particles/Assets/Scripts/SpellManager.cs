using UnityEngine;
using System.Collections;

public class SpellManager : MonoBehaviour {

    public GameObject[] spells;

    public void CastSpell(int currentSpell)
    {
        spells[currentSpell].GetComponent<Animator>().SetTrigger("activated");
    }
}
