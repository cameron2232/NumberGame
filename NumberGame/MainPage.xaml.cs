namespace NumberGame;

public partial class MainPage : ContentPage
{
    int systemNumber;
    int userNumber;
    Random randomGen;
	public MainPage()
	{
		InitializeComponent();
        // creates an instance of Random, same as randomGem = Random() in python
        randomGen = new Random();
        systemNumber = randomGen.Next(100, 1000); // upper bound is excluded
        userNumber = randomGen.Next(100, 1000);
    }

    void OnPlay(object sender, EventArgs e)
    {
        //DisplayAlert("System Number", $"The number is {systemNumber = GenerateNumber()}", "Ok");
        //DisplayAlert("User Number", $"The number is {userNumber = GenerateNumber()}", "Ok");

        systemNumber = randomGen.Next(100, 1000); // upper bound is excluded
        userNumber = randomGen.Next(100, 1000);

        if (userNumber > systemNumber)
        {
            DisplayAlert("Result", $"Win! {userNumber} is greater than {systemNumber}", "Ok");
        }
        else if (userNumber < systemNumber)
        {
            DisplayAlert("Result", $"Lose! {userNumber} is less than {systemNumber}", "Ok");
        }
        else
        {
            DisplayAlert("Result", $"Jackpot! both numbers are equal to {userNumber}", "Ok");
        }
        

    }
}


