namespace OneSky.CSharp.Json
{
    public interface IProjectNew : IProject
    {
        IProjectType ProjectType { get; }

        string Description { get; }
    }
}
