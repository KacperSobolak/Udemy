namespace Mediator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var submitButton = new Button();
            var clientTypeCheckbox = new Checkbox();

            new RegisterClientView(clientTypeCheckbox, submitButton);

            submitButton.Click();
            clientTypeCheckbox.Select();
        }
    }
}
