

//Typical reference to another class in the Unity Scene.
//FindObjectOfType is in scene, GetComponent would be fromt he same object.


SaveManager saveManager;

private void Start()
{
    saveManager = FindObjectOfType<SaveManager>();
}
