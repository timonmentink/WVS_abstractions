using System.Collections.Generic;
using UnityEngine;

namespace WVS.Abstractions.UnityHelpers
{
    /// <summary>
    ///     Collection of helper functions to traverse, find, manipulate, etc. Unity game objects.
    /// </summary>
    public interface IUnityHelpersFactory
    {
        /// <summary>
        ///     Recursively find all children with a given tag of an object.
        /// </summary>
        public List<GameObject> FindChildrenWithTagRecursive(GameObject obj, string tag);

        /// <summary>
        ///     Finds the first parent of a child object with a given tag. null if no parent was found.
        /// </summary>
        public GameObject FindParentWithTag(GameObject obj, string tag);

        /// <summary>
        ///     Make a fully-qualified name (FQN) for a GameObject.
        ///     This FQN will reflect the chain of links/models. Other object types are ignored.
        ///     The root model is skipped from the name!
        ///     Only Links can really move w.r.t. to each other, but without Models most names would
        ///     not be unique.
        ///     Examples: `base_link`, `base_link/wheel_left_front/link`, `base_link/gps/link`
        /// </summary>
        public string GetFrameId(in GameObject obj);

        /// <summary>
        ///     Make object a child of another object, resetting its local position/rotation/scale.
        /// </summary>
        public void SetParentObject(GameObject childObject, GameObject parentObject);

        /// <summary>
        ///     Find the first child of given object with given name and given tag
        /// </summary>
        public GameObject FindChildWithNameAndTag(GameObject obj, string name, string tag);
    }
}
