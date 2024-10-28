using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using WVS.Abstractions.SensorSettings.Datatypes;
using WVS.Abstractions.SensorSettings.Noise;

namespace WVS.Abstractions.SensorSettings
{
    public interface ICameraSettings : IBaseSettings
    {
        public string CameraName { get; }
        public bool TriggeredByTopic { get; }
        public string InfoTopic { get; }
        public string TriggerTopic { get; }
        public double HorizontalFoV { get; }
        public uint ImageWidth { get; }
        public uint ImageHeight { get; }
        public PixelFormatType PixelFormat { get; }
        public uint AntiAliasing { get; }
        public double NearClip { get; }
        public double FarClip { get; }
        public bool SaveFramesEnabled { get; }
        public string FramePath { get; }
        public INoise<double> ImageNoise { get; }
        public NoiseType ImageNoiseType { get; }
        public double DistortionK1 { get; }
        public double DistortionK2 { get; }
        public double DistortionK3 { get; }
        public double DistortionP1 { get; }
        public double DistortionP2 { get; }
        public IVector2<double> DistortionCenter { get; }
        public string LensType { get; }
        public bool LensScaleToHFoV { get; }
        public double LensFunctionC1 { get; }
        public double LensFunctionC2 { get; }
        public double LensFunctionC3 { get; }
        public double LensFocalLength { get; }
        public string LensFunction { get; }
        public double LensCutOffAngleDegree { get; }
        public int LensEnvTextureSize { get; }
        public bool LensHasIntrinsics { get; }
        public double LensIntrinsicsFx { get; }
        public double LensIntrinsicsFy { get; }
        public double LensIntrinsicsCx { get; }
        public double LensIntrinsicsCy { get; }
        public double LensIntrinsicsSkew { get; }
        public bool LensHasProjection { get; }
        public double LensProjectionFx { get; }
        public double LensProjectionFy { get; }
        public double LensProjectionCx { get; }
        public double LensProjectionCy { get; }
        public double LensProjectionTx { get; }
        public double LensProjectionTy { get; }
        public uint LensVisibilityMask { get; }
        public string OpticalFrameId { get; }
        public IPose<double> Pose { get; }
    }
}
