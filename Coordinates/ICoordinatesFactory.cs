using UnityEngine;

namespace WVS.Abstractions.Coordinates
{
    public interface ICoordinatesFactory
    {
        /// <summary>
        ///     Convert the left-handed y-up system of Unity to the right-handed z-up system of ROS.
        /// </summary>
        Vector3 AxesUnityToRos(in Vector3 pos);

        /// <summary>
        ///     Convert the right-handed z-up system of ROS to the left-handed y-up system of Unity.
        /// </summary>
        Vector3 AxesRosToUnity(in Vector3 pos);

        /// <summary>
        ///     Converts x, y and z angles from Unity's frame of reference to ROS's frame of reference.
        ///     This is the negative of `AxesUnityToRos` because ROS is right-handed and Unity is left-handed.
        /// </summary>
        Vector3 RotationUnityToRos(in Vector3 pos);

        /// <summary>
        ///     Convert the left-handed y-up system of Unity to the right-handed z-up system of ROS.
        /// </summary>
        Quaternion OrientationUnityToRos(in Quaternion quat);

        /// <summary>
        ///     Calculate the compass heading of a given quaternion
        ///     Input must be in ROS coordinate frame
        /// </summary>
        double GetCompassHeadingFromQuaternion(in Quaternion quat);

        /// <summary>
        ///     Calculates the pitch from a given quaternion
        ///     Input must be in ROS coordinate frame
        /// </summary>
        double GetPitchFromQuaternion(in Quaternion quat);

        /// <summary>
        ///     Get GPS coordinates based on Unity world position.
        /// </summary>
        /// <returns>
        ///     Vector with {latitude, longitude, elevation} (in degrees, degrees and meters).
        /// </returns>
        Vector3 SphericalFromLocal(in Vector3 xyz);

        /// <summary>
        ///     ///     Get Unity world position based on GPS coordinates.
        /// </summary>
        /// <param name="xyz">Vector with {latitude, longitude, elevation} (in degrees, degrees and meters).</param>
        /// <returns>Vector with {X, Y, Z} (in unity scale).</returns>
        public Vector3 LocalFromSpherical(in Vector3 xyz);

        /// <summary>
        ///     Offset between world heading and GPS heading, in degrees.
        ///     A positive offset means North will effectively shift CCW (i.e. towards west) w.r.t to
        ///     the Unity axes.
        /// </summary>
        float GetHeadingOffsetDegrees();

        /// <summary>
        ///     Set world reference.
        ///     All angles are in degrees.
        /// </summary>
        public void SetCoordinatesReference(in double latitudeAngle, in double longitudeAngle, in double elevation, in double headingAngle);
    }
}
