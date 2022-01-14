namespace Money_Manager.View
{
    internal interface IViewInputBudget
    {

        decimal InputBudget { get; }
        event EventHandler<EventArgs> GetBudget;

    }
}
