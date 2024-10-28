using System;
using System.Collections.Generic;
using UnityEngine;


namespace WVS.Abstractions.Navigation
{
    public interface INavigationGridManager
    {
        public Guid InitializeNavGraphAndSeeker(GameObject parentGameObject, GraphTypesEnum graphTypeEnum,
            GraphCollisionsEnum collisionBoxEnum,
            float maxSlope, float agentDiameter, float agentHeight, int renderDistanceGraph, float agentSpeed, float agentRotationSpeed,
            float smoothingMaxSegmentLength, int smoothingIterations, float smoothingStrength,
            int renderDistanceTerrain, bool loadAllTerrain, float stoppingDistance, int nodeSize = 1,
            float maxStepHeight = 0.5f,
            float voxelSize = 0.25f, int tileSize = 128, int maxBorderEdgeLength = 20, bool threadCountHigh = false);

        public Vector3 GetVelocityAIPath(Guid seekerID);
        public void SeekerSetPositionAndRotation(Guid seekerID, Vector3 pos, Quaternion rot);
        public void SetDestination(Guid seekerID, Vector3 pos);
        public Vector3 GetDestination(Guid seekerID);
        public float GetRemainingDistance(Guid seekerID);
        public Vector3 GetSeekerLocation(Guid seekerID);
        public float GetStoppingDistance(Guid seekerID);
        public bool HasPath(Guid seekerID);
        public bool ReachedDestination(Guid seekerID);
        public bool PathPending(Guid seekerID);
        public float GetMaxVelocity(Guid seekerID);
        public bool HasSeeker();
        public Vector3 GetDesiredVelocity(Guid seekerID);
        public Vector3 GetTerrainHeightAtPosition(Vector3 position);
        public void SetPathLogging(PathLoggingTypeEnum pathLoggingType);
        public void SetGraphColoring(GraphColoringTypeEnum graphColoringType);
        public void SetTexturePenaltiesDictionary(Dictionary<string, uint> texturePenaltiesDictionary);
    }
}
