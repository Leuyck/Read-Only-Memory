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

public class PathsParams : IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal PathsParams(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(PathsParams obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~PathsParams() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_PathsParams(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkVector listenerPos { set { AkSoundEnginePINVOKE.CSharp_PathsParams_listenerPos_set(swigCPtr, AkVector.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_PathsParams_listenerPos_get(swigCPtr);
      AkVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public AkVector emitterPos { set { AkSoundEnginePINVOKE.CSharp_PathsParams_emitterPos_set(swigCPtr, AkVector.getCPtr(value)); } 
    get {
      global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_PathsParams_emitterPos_get(swigCPtr);
      AkVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkVector(cPtr, false);
      return ret;
    } 
  }

  public uint numValidPaths { set { AkSoundEnginePINVOKE.CSharp_PathsParams_numValidPaths_set(swigCPtr, value); }  get { return AkSoundEnginePINVOKE.CSharp_PathsParams_numValidPaths_get(swigCPtr); } 
  }

  public PathsParams() : this(AkSoundEnginePINVOKE.CSharp_new_PathsParams(), true) {
  }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.