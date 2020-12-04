﻿using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class File : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public File(AndroidJavaObject javaObject) : base(javaObject) { }

        [UnityEngine.Scripting.Preserve]
        public File() : base("com.huawei.cloud.services.drive.model.File") { }

        public Boolean GetDirectlyRecycled()
        {
            return Call<Boolean>("getDirectlyRecycled");
        }

        public File SetDirectlyRecycled(Boolean var1)
        {
            return CallAsWrapper<File>("setDirectlyRecylcled", var1);
        }

        public String GetFileSuffix()
        {
            return Call<String>("getFileSuffix");
        }

        public File SetFileSuffix(String var1)
        {
            return CallAsWrapper<File>("setFileSuffix", var1);
        }

        public String GetFullFileSuffix()
        {
            return Call<String>("getFullFileSuffix");
        }

        public File SetFullFileSuffix(String var1)
        {
            return CallAsWrapper<File>("setFullFileSuffix", var1);
        }

        public Boolean GetIsAppAuthorized()
        {
            return Call<Boolean>("getIsAppAuthorized");
        }

        public File SetIsAppAuthorized(Boolean var1)
        {
            return CallAsWrapper<File>("setIsAppAuthorized", var1);
        }

        public String GetCategory()
        {
            return Call<String>("getCategory");
        }

        public File SetCategory(String var1)
        {
            return CallAsWrapper<File>("setCategory", var1);
        }

        public File.ContentExtras GetContentExtras()
        {
            return CallAsWrapper<File.ContentExtras>("getContentExtras");
        }

        public File SetContentExtras(File.ContentExtras var1)
        {
            return CallAsWrapper<File>("setContentExtras");

        }


        public String GetId()
        {
            return Call<String>("getId");
        }

        public File SetId(String var1)
        {
            return CallAsWrapper<File>("setId", var1);
        }

        public String GetFileName()
        {
            return Call<String>("getFileName");
        }

        public File SetFileName(String var1)
        {
            return CallAsWrapper<File>("setFileName", var1);
        }

        public AndroidJavaObject GetSize() => Call<AndroidJavaObject>("getSize");

        public File SetSize(long var1)
        {
            return CallAsWrapper<File>("setSize", var1);

        }

        public String GetMimeType()
        {
            return Call<String>("getMimeType");
        }

        public File SetMimeType(String var1)
        {
            return CallAsWrapper<File>("setMimeType", var1);

        }

        public IList<string> GetParentFolder()
        {
            return Call<AndroidJavaObject>("getParentFolder").AsStringList();

        }

        public File SetParentFolder(AndroidJavaObject var1)
        {
            return CallAsWrapper<File>("setParentFolder", var1);

        }

        public Dictionary<String, String> GetAppSettings()
        {
            return Call<Dictionary<String, String>>("getAppSettings");
        }

        public File SetAppSettings(Dictionary<String, String> var1)
        {
            return CallAsWrapper<File>("setAppSettings", var1);

        }


        public String GetOriginalFilename()
        {
            return Call<String>("getOriginalFilename");
        }

        public File SetOriginalFilename(String var1)
        {
            return CallAsWrapper<File>("setOriginalFilename", var1);

        }

        public long GetThumbnailVersion()
        {
            return Call<long>("getThumbnailVersion");
        }

        public File SetThumbnailVersion(long var1)
        {
            return CallAsWrapper<File>("setThumbnailVersion", var1);

        }

        public long GetVersion()
        {
            return Call<long>("getVersion");
        }

        public File SetVersion(long var1)
        {
            return CallAsWrapper<File>("setVersion", var1);

        }

        public String GetContentVersion()
        {
            return Call<String>("getContentVersion");
        }

        public File SetContentVersion(String var1)
        {
            return CallAsWrapper<File>("setContentVersion", var1);

        }

        public String GetOnLineViewLink()
        {
            return Call<String>("getOnLineViewLink");
        }

        public File SetOnLineViewLink(String var1)
        {
            return CallAsWrapper<File>("setOnLineViewLink", var1);

        }

        public File Set(String var1, AndroidJavaObject var2) => CallAsWrapper<File>("set", var1, var2);

        public File Clone() => CallAsWrapper<File>("clone");

        public Boolean GetExistThumbnail()
        {
            return Call<Boolean>("getExistThumbnail");
        }

        public File SetExistThumbnail(Boolean var1)
        {
            return CallAsWrapper<File>("setExistThumbnail");

        }

        public String GetThumbnailDownloadLink()
        {
            return Call<String>("getThumbnailDownloadLink");
        }

        public String GetSmallThumbnailDownloadLink()
        {
            return Call<String>("getSmallThumbnailDownloadLink");
        }

        public File SetThumbnailDownloadLink(String var1)
        {
            return CallAsWrapper<File>("setThumbnailDownloadLink", var1);
        }

        public File SetSmallThumbnailDownloadLink(String var1)
        {
            return CallAsWrapper<File>("setSmallThumbnailDownloadLink", var1);

        }

        public File SetSharer(User var1)
        {
            return CallAsWrapper<File>("setSharer", var1);

        }

        public User GetRecyclingUser()
        {
            return CallAsWrapper<User>("getRecyclingUser");
        }

        public File SetRecyclingUser(User var1)
        {
            return CallAsWrapper<File>("setRecyclingUser", var1);

        }

        public Boolean GetWritersHasSharePermission()
        {
            return Call<Boolean>("getWritersHasSharePermission");
        }

        public File SetWritersHasSharePermission(Boolean var1)
        {
            return CallAsWrapper<File>("setWritersHasSharePermission", var1);

        }

        public Boolean GetWriterHasCopyPermission()
        {
            return Call<Boolean>("getWriterHasCopyPermission");
        }

        public File SetWriterHasCopyPermission(Boolean var1)
        {
            return CallAsWrapper<File>("WriterHasCopyPermission", var1);

        }

        public User GetLastEditor()
        {
            return CallAsWrapper<User>("getLasEditor");
        }

        public File SetLastEditor(User var1)
        {
            return CallAsWrapper<File>("setLastEditor", var1);

        }
        public class Capabilities : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Capabilities(AndroidJavaObject javaObject) : base(javaObject)
            {
            }

            [UnityEngine.Scripting.Preserve]
            public Capabilities() : base("com.huawei.cloud.services.drive.model.File$Capabilities") { }

        }

        public class ContentExtras : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public ContentExtras(AndroidJavaObject javaObject) : base(javaObject) { }

            [UnityEngine.Scripting.Preserve]
            public ContentExtras() : base("com.huawei.cloud.services.drive.model.File$ContentExtras") { }

            public File.ContentExtras SetThumbnail(File.ContentExtras.Thumbnail var1)
            {
                return CallAsWrapper<File.ContentExtras>("setThumbnail", var1);

            }

            public class Thumbnail : JavaObjectWrapper
            {
                [UnityEngine.Scripting.Preserve]

                public Thumbnail(AndroidJavaObject javaObject) : base(javaObject)
                {
                }
                [UnityEngine.Scripting.Preserve]
                public Thumbnail() : base("com.huawei.cloud.services.drive.model.File.ContentExtras$Thumbnail") { }
                public File.ContentExtras.Thumbnail SetThumbnailPublic(Boolean var1)
                {
                    return CallAsWrapper<File.ContentExtras.Thumbnail>("setThumbnailPublic", var1);
                }

                public File.ContentExtras.Thumbnail SetContent(String var1)
                {

                    return CallAsWrapper<File.ContentExtras.Thumbnail>("setContent", var1);

                }
                public File.ContentExtras.Thumbnail SetMimeType(String var1)
                {

                    return CallAsWrapper<File.ContentExtras.Thumbnail>("setMimeType", var1);

                }

            }

        }

    }
}
