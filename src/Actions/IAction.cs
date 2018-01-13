namespace Cardyff.Actions
{
    public interface IAction
    {
        string Type { get; set; }
        string Name { get; set; }
    }
}