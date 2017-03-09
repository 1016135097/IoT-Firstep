package com.example.studybroadcastreceiver;

import android.os.Bundle;
import android.app.Activity;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;

public class MainActivity extends Activity {
	
	//���ܶ��ŵ��¼�
	private static final String SMS_RECIVED_ACTION = "android.provider.Telephony.SMS_RECEIVED";
	
	SMSReceiver receiver;
	
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        
        //���һ��IntentFilter,��������SMS_RECIVED_ACTION����¼���
        IntentFilter intentFilter = new IntentFilter();
        intentFilter.addAction(SMS_RECIVED_ACTION);
        
        receiver = new SMSReceiver();
        //ע��㲥
        registerReceiver(receiver, intentFilter);
    }
    
    @Override
    protected void onDestroy() {
    	// TODO Auto-generated method stub
    	super.onDestroy();
    	unregisterReceiver(receiver);//���ע��
    }
    
    public class SMSReceiver extends BroadcastReceiver{

		@Override
		public void onReceive(Context context, Intent intent) {
			// TODO Auto-generated method stub
			if (intent.getAction().equals(SMS_RECIVED_ACTION)) {
				System.out.println("�յ��˶���");
			}
		}
    }
}
