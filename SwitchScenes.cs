

//Versatile scene transition code, exit to main being an example.
//Swap out the PopUpSystem with an actual UI element, and this would remove the confirmCheck need.


public void ExitToMainButton()
    {

        if (confirmCheck == false)
        {
            PopUpSystem pop = FindObjectOfType<PopUpSystem>();
            bool decision = pop.PopUp("Are you sure you want to return to the main menu", "Exit");
        }
        else if (confirmCheck)
        {
            SceneManager.LoadScene(1);
        }

    }
