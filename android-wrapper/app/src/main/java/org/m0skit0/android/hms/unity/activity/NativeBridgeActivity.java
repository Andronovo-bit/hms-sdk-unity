package org.m0skit0.android.hms.unity.activity;

import android.app.Activity;
import android.content.ContentResolver;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.net.Uri;
import android.os.Bundle;
import android.provider.MediaStore;
import android.util.Log;

import androidx.annotation.Nullable;

import com.unity3d.player.UnityPlayer;

import org.m0skit0.android.hms.unity.BridgeType;
import org.m0skit0.android.hms.unity.GenericBridge;
import org.m0skit0.android.hms.unity.base.StatusBridge;
import org.m0skit0.android.hms.unity.game.ArchiveBridge;
import org.m0skit0.android.hms.unity.helper.FilePicker.FilePickerBridge;
import org.m0skit0.android.hms.unity.inAppComment.InAppCommentBridge;
import org.m0skit0.android.hms.unity.scan.bridge.ScanKitBridge;

import java.io.IOException;
import java.util.Objects;

public class NativeBridgeActivity extends Activity {

    public static final String TYPE = "TYPE";
    private static final String TAG = NativeBridgeActivity.class.getSimpleName();

    public static void start(final String type) {
        final Intent intent = new Intent(UnityPlayer.currentActivity, NativeBridgeActivity.class)
                .putExtra(TYPE, type);
        UnityPlayer.currentActivity.startActivity(intent);
    }

    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        Log.d(TAG, "[HMS] onCreate");
        final Intent intent = getIntent();
        if (intent != null) {
            Log.d(TAG, "[HMS] onCreate getIntent " + intent);
            final String type = intent.getStringExtra(TYPE);
            if (type != null) {
                Log.d(TAG, "[HMS] onCreate type " + type);
                switch (type) {
                    case StatusBridge.STATUS:
                        Log.d(TAG, "[HMS] onCreate type StatusBridge.STATUS");
                        StatusBridge.launchStartResolutionForResult(this);
                        break;
                    case GenericBridge.GENERIC:
                        Log.d(TAG, "[HMS] onCreate type GenericBridge.GENERIC");
                        GenericBridge.launchShow(this);
                        break;
                    case ArchiveBridge.SAVED:
                        Log.d(TAG, "[HMS] onCreate type ArchiveBridge.SAVED");
                        ArchiveBridge.launchShow(this);
                        break;
                    case InAppCommentBridge.IN_APP_COMMENT:
                        Log.d(TAG, "[HMS] onCreate type ArchiveBridge.ANDROID");
                        InAppCommentBridge.launchShow(this);
                        break;
                    case ScanKitBridge.SCAN:
                        Log.d(TAG, "[HMS] onCreate type SCAN");
                        ScanKitBridge.RequestForPermission(this);
                        break;
                    case FilePickerBridge.FILE_PICKER:
                        Log.d(TAG, "[HMS] onCreate type FILE_PICKER");
                        FilePickerBridge.RequestForPermission(this);
                    default:
                        Log.e(TAG, "[HMS] Unknown type " + type);
                }
            }
        }
    }

    @Override
    protected void onActivityResult(int requestCode, int resultCode, Intent data) {
        Log.d(TAG, "[HMS] onActivityResult resultCode: " + resultCode);

        super.onActivityResult(requestCode, resultCode, data);

        if (requestCode == BridgeType.IN_APP_COMMENT) {
            InAppCommentBridge.returnShow(requestCode, resultCode);
        } else if (data != null) {
            switch (requestCode) {
                case BridgeType.GENERIC:
                    GenericBridge.returnShow(data);
                    break;
                case BridgeType.STATUS:
                    StatusBridge.returnStartResolutionForResult(data);
                    break;
                case BridgeType.ARCHIVE:
                    ArchiveBridge.returnShow(data);
                    break;
                case BridgeType.SCAN:
                    ScanKitBridge.returnShow(data);
                    break;
                case BridgeType.FILE_PICKER:
                    Uri uri = data.getData();
                    if(uri == null){
                        Log.e(TAG, "[HMS] Data is Empty. Intent data not found. " + requestCode);
                        return;
                    }
                    ContentResolver cr = this.getContentResolver();
                    Log.d(TAG, "[HMS] FILE_PICKER data type: " + cr.getType(uri));
                    boolean intentType = Objects.requireNonNull(cr.getType(uri)).contains("image");
                    Bitmap bitmap = null;
                    if(intentType) {
                        try {
                            bitmap = MediaStore.Images.Media.getBitmap(cr, uri);
                        } catch (IOException e) {
                            throw new RuntimeException(e);
                        }
                    }
                    FilePickerBridge.returnShow(data,bitmap);
                default:
                    Log.e(TAG, "[HMS] Unknown request code " + requestCode);
            }
        } else {
            Log.e(TAG, "[HMS] data on onActivityResult is null");
        }
        finish();
    }

    @Override
    public void onRequestPermissionsResult(int requestCode, String[] permissions, int[] grantResults) {

        if (permissions == null || grantResults == null ) {
            finish();
        }

        if (requestCode == BridgeType.SCAN) {

            boolean permissionCamera = this.checkCallingOrSelfPermission("android.permission.CAMERA") == PackageManager.PERMISSION_GRANTED;

            if (permissionCamera ) {
                ScanKitBridge.launchShow(this);
            }
            else
            {
                finish();
            }
        }
    }

}
