namespace WVS.Abstractions.Navigation
{
    /// <summary>
    ///     Enum for colliderTypes, same order as FillGraphCollisionList
    ///     Necessary to keep it this way because this is the same enum as Pathfinding.Graphs.Grid.ColliderType from plugin
    /// </summary>
    public enum GraphCollisionsEnum
    {
        Sphere,
        Capsule,
        Ray,
    }
}
