using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{

    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureUploadListener.
    /// <see cref="Modeling3dTextureUploadListener" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureuploadlistener-0000001153013001"/>
    /// </summary>
    public class Modeling3dTextureUploadListener : AndroidJavaProxy
    {
        private readonly IModeling3dTextureUploadListener _IModeling3dTextureUploadListener;
        public Modeling3dTextureUploadListener(IModeling3dTextureUploadListener iModeling3dTextureUploadListener) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureUploadListener")
        {
            _IModeling3dTextureUploadListener = iModeling3dTextureUploadListener;
        }
        public void onUploadProgress(string taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureUploadListener.onUploadProgress(taskId, progress, javaObject);
        }
        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dTextureUploadListener.onError(taskId, errorCode, errorMsg);
        }
        public void onResult(string taskId, Modeling3dTextureUploadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureUploadListener.onResult(taskId, result, javaObject);
        }

        public interface IModeling3dTextureUploadListener
        {
            //TODO: AndroidObject maybe make problems be careful doing test. AndroidObject = Android Object Class
            void onUploadProgress(string taskId, double progress, AndroidJavaObject javaObject);

            void onError(string taskId, int errorCode, string errorMessage);

            void onResult(string taskId, Modeling3dTextureUploadResult result, AndroidJavaObject javaObject);

        }
    }
}