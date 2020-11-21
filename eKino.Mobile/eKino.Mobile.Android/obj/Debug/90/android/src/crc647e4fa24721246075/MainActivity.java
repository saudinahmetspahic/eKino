package crc647e4fa24721246075;


public class MainActivity
	extends crc643f46942d9dd1fff9.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_startService:(Landroid/content/Intent;)Landroid/content/ComponentName;:GetStartService_Landroid_content_Intent_Handler\n" +
			"n_stopService:(Landroid/content/Intent;)Z:GetStopService_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("eKino.Mobile.Droid.MainActivity, eKino.Mobile.Android", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("eKino.Mobile.Droid.MainActivity, eKino.Mobile.Android", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public android.content.ComponentName startService (android.content.Intent p0)
	{
		return n_startService (p0);
	}

	private native android.content.ComponentName n_startService (android.content.Intent p0);


	public boolean stopService (android.content.Intent p0)
	{
		return n_stopService (p0);
	}

	private native boolean n_stopService (android.content.Intent p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
