package md59135238fb0e6a124e3a2b245eb5d2fa7;


public class OnDrawableTouchListener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnTouchListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouch:(Landroid/view/View;Landroid/view/MotionEvent;)Z:GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler:Android.Views.View/IOnTouchListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("PiposX.Droid.Effects.OnDrawableTouchListener, PiposX.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", OnDrawableTouchListener.class, __md_methods);
	}


	public OnDrawableTouchListener ()
	{
		super ();
		if (getClass () == OnDrawableTouchListener.class)
			mono.android.TypeManager.Activate ("PiposX.Droid.Effects.OnDrawableTouchListener, PiposX.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public boolean onTouch (android.view.View p0, android.view.MotionEvent p1)
	{
		return n_onTouch (p0, p1);
	}

	private native boolean n_onTouch (android.view.View p0, android.view.MotionEvent p1);

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
