#if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.
/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class AkPropagationPathInfo : IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPropagationPathInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkPropagationPathInfo obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkPropagationPathInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkPropagationPathInfo(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkVector nodePoint { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_nodePoint_set(swigCPtr, AkVector.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_nodePoint_get(swigCPtr);
      AkVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public uint numNodes { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_numNodes_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_numNodes_get(swigCPtr); } 
  }

  public float length { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_length_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_length_get(swigCPtr); } 
  }

  public float gain { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_gain_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_gain_get(swigCPtr); } 
  }

  public float dryDiffractionAngle { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_dryDiffractionAngle_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_dryDiffractionAngle_get(swigCPtr); } 
  }

  public float wetDiffractionAngle { set { AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_wetDiffractionAngle_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_AkPropagationPathInfo_wetDiffractionAngle_get(swigCPtr); } 
  }

  public AkPropagationPathInfo() : this(AkSoundEnginePINVOKE.CSharp_new_AkPropagationPathInfo(), true) {
  }

  public const uint kMaxNodes = 8;
}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.