using UnityEngine;

public class Testing : Mod
{
    public void Start()
    {
        Debug.Log("THE MOD HAS LOADED! WOOOOOO!");
    }

    public void OnModUnload()
    {
        Debug.Log("The mod is unloaded :(.");
    }
}