﻿using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextToSpeech
{
    //https://developer.huawei.com/consumer/en/doc/hiai-References/mlttserror-0000001050167600
    public class MLTtsError : JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.tts.MLTtsError";
        public MLTtsError(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static int ERR_ILLEGAL_PARAMETER => sJavaClass.GetStatic<int>(nameof(ERR_ILLEGAL_PARAMETER));
        public static int ERR_NET_CONNECT_FAILED => sJavaClass.GetStatic<int>(nameof(ERR_NET_CONNECT_FAILED));
        public static int ERR_INSUFFICIENT_BALANCE => sJavaClass.GetStatic<int>(nameof(ERR_INSUFFICIENT_BALANCE));
        public static int ERR_SPEECH_SYNTHESIS_FAILED => sJavaClass.GetStatic<int>(nameof(ERR_SPEECH_SYNTHESIS_FAILED));
        public static int ERR_AUDIO_PLAYER_FAILED => sJavaClass.GetStatic<int>(nameof(ERR_AUDIO_PLAYER_FAILED));
        public static int ERR_AUTHORIZE_FAILED => sJavaClass.GetStatic<int>(nameof(ERR_AUTHORIZE_FAILED));
        public static int ERR_AUTHORIZE_TOKEN_INVALIDE => sJavaClass.GetStatic<int>(nameof(ERR_AUTHORIZE_TOKEN_INVALIDE));
        public static int ERR_INTERNAL => sJavaClass.GetStatic<int>(nameof(ERR_INTERNAL));
        public static int ERR_UNKNOWN => sJavaClass.GetStatic<int>(nameof(ERR_UNKNOWN));

        public int ErrorId => Call<int>("getErrorId");
        public string ErrorMessage() => Call<string>("getErrorMsg");
        public JavaObject GetExtension() => CallAsWrapper<JavaObject>("getExtension");
        public override string ToString() => Call<string>("toString");

        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.mlsdk.tts.MLTtsError$Builder") { }

            public Builder SetErrorId(int param1Int) => CallAsWrapper<Builder>("setErrorId", param1Int);

            public Builder SetErrorMessage(string param1String) => CallAsWrapper<Builder>("setErrorMsg", param1String);

            public Builder SetExtension(JavaObject param1JavaObject) => CallAsWrapper<Builder>("setExtension", param1JavaObject);

            public MLTtsError Build() => CallAsWrapper<MLTtsError>("build");

        }

    }
}
