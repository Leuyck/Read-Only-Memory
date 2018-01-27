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

public class AkPlaylistArray : IDisposable {
  private global::System.IntPtr swigCPtr;
  protected bool swigCMemOwn;

  internal AkPlaylistArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  internal static global::System.IntPtr getCPtr(AkPlaylistArray obj) {
    return (obj == null) ? global::System.IntPtr.Zero : obj.swigCPtr;
  }

  internal virtual void setCPtr(global::System.IntPtr cPtr) {
    Dispose();
    swigCPtr = cPtr;
  }

  ~AkPlaylistArray() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          AkSoundEnginePINVOKE.CSharp_delete_AkPlaylistArray(swigCPtr);
        }
        swigCPtr = global::System.IntPtr.Zero;
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public AkPlaylistArray() : this(AkSoundEnginePINVOKE.CSharp_new_AkPlaylistArray(), true) {
  }

  public AkIterator Begin() {
    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Begin(swigCPtr), true);
    return ret;
  }

  public AkIterator End() {
    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_End(swigCPtr), true);
    return ret;
  }

  public AkIterator FindEx(AkPlaylistItem in_Item) {
    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_FindEx(swigCPtr, AkPlaylistItem.getCPtr(in_Item)), true);
    return ret;
  }

  public AkIterator Erase(AkIterator in_rIter) {
    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_0(swigCPtr, AkIterator.getCPtr(in_rIter)), true);
    return ret;
  }

  public void Erase(uint in_uIndex) { AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Erase__SWIG_1(swigCPtr, in_uIndex); }

  public AkIterator EraseSwap(AkIterator in_rIter) {
    AkIterator ret = new AkIterator(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_EraseSwap(swigCPtr, AkIterator.getCPtr(in_rIter)), true);
    return ret;
  }

  public AKRESULT Reserve(uint in_ulReserve) { return (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserve(swigCPtr, in_ulReserve); }

  public uint Reserved() { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Reserved(swigCPtr); }

  public void Term() { AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Term(swigCPtr); }

  public uint Length() { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Length(swigCPtr); }

  public bool IsEmpty() { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_IsEmpty(swigCPtr); }

  public AkPlaylistItem Exists(AkPlaylistItem in_Item) {
    global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Exists(swigCPtr, AkPlaylistItem.getCPtr(in_Item));
    AkPlaylistItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlaylistItem(cPtr, false);
    return ret;
  }

  public AkPlaylistItem AddLast() {
    global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_0(swigCPtr);
    AkPlaylistItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlaylistItem(cPtr, false);
    return ret;
  }

  public AkPlaylistItem AddLast(AkPlaylistItem in_rItem) {
    global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_AddLast__SWIG_1(swigCPtr, AkPlaylistItem.getCPtr(in_rItem));
    AkPlaylistItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlaylistItem(cPtr, false);
    return ret;
  }

  public AkPlaylistItem Last() {
    AkPlaylistItem ret = new AkPlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Last(swigCPtr), false);
    return ret;
  }

  public void RemoveLast() { AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveLast(swigCPtr); }

  public AKRESULT Remove(AkPlaylistItem in_rItem) { return (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Remove(swigCPtr, AkPlaylistItem.getCPtr(in_rItem)); }

  public AKRESULT RemoveSwap(AkPlaylistItem in_rItem) { return (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveSwap(swigCPtr, AkPlaylistItem.getCPtr(in_rItem)); }

  public void RemoveAll() { AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_RemoveAll(swigCPtr); }

  public AkPlaylistItem ItemAtIndex(uint uiIndex) {
    AkPlaylistItem ret = new AkPlaylistItem(AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_ItemAtIndex(swigCPtr, uiIndex), false);
    return ret;
  }

  public AkPlaylistItem Insert(uint in_uIndex) {
    global::System.IntPtr cPtr = AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Insert(swigCPtr, in_uIndex);
    AkPlaylistItem ret = (cPtr == global::System.IntPtr.Zero) ? null : new AkPlaylistItem(cPtr, false);
    return ret;
  }

  public bool GrowArray(uint in_uGrowBy) { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_0(swigCPtr, in_uGrowBy); }

  public bool GrowArray() { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_GrowArray__SWIG_1(swigCPtr); }

  public bool Resize(uint in_uiSize) { return AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Resize(swigCPtr, in_uiSize); }

  public void Transfer(AkPlaylistArray in_rSource) { AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Transfer(swigCPtr, AkPlaylistArray.getCPtr(in_rSource)); }

  public AKRESULT Copy(AkPlaylistArray in_rSource) { return (AKRESULT)AkSoundEnginePINVOKE.CSharp_AkPlaylistArray_Copy(swigCPtr, AkPlaylistArray.getCPtr(in_rSource)); }

}
#endif // #if ! (UNITY_DASHBOARD_WIDGET || UNITY_WEBPLAYER || UNITY_WII || UNITY_WIIU || UNITY_NACL || UNITY_FLASH || UNITY_BLACKBERRY) // Disable under unsupported platforms.