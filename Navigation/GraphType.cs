namespace WVS.Abstractions.Navigation
{
    /// <summary>
    ///     Enum for different types of graphs, same order as fillGraphList
    ///     If you want to change this enum, or extent it, also extent the list and change functions of NavigationGridManager
    /// </summary>
    public enum GraphTypesEnum
    {
        GridGraph,
        RecastGraph
    }
}
