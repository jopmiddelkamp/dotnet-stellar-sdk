// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct TrustLineEntryExtensionV2
//  {
//      int32 liquidityPoolUseCount;
//  
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
public class TrustLineEntryExtensionV2  {
  public TrustLineEntryExtensionV2 () {}
  public Int32 LiquidityPoolUseCount {get; set;}
  public TrustLineEntryExtensionV2Ext Ext {get; set;}

  public static void Encode(XdrDataOutputStream stream, TrustLineEntryExtensionV2 encodedTrustLineEntryExtensionV2) {
    Int32.Encode(stream, encodedTrustLineEntryExtensionV2.LiquidityPoolUseCount);
    TrustLineEntryExtensionV2Ext.Encode(stream, encodedTrustLineEntryExtensionV2.Ext);
  }
  public static TrustLineEntryExtensionV2 Decode(XdrDataInputStream stream) {
    TrustLineEntryExtensionV2 decodedTrustLineEntryExtensionV2 = new TrustLineEntryExtensionV2();
    decodedTrustLineEntryExtensionV2.LiquidityPoolUseCount = Int32.Decode(stream);
    decodedTrustLineEntryExtensionV2.Ext = TrustLineEntryExtensionV2Ext.Decode(stream);
    return decodedTrustLineEntryExtensionV2;
  }

  public class TrustLineEntryExtensionV2Ext {
    public TrustLineEntryExtensionV2Ext () {}

    public int Discriminant { get; set; } = new int();

    public static void Encode(XdrDataOutputStream stream, TrustLineEntryExtensionV2Ext encodedTrustLineEntryExtensionV2Ext) {
    stream.WriteInt((int)encodedTrustLineEntryExtensionV2Ext.Discriminant);
    switch (encodedTrustLineEntryExtensionV2Ext.Discriminant) {
    case 0:
    break;
    }
    }
    public static TrustLineEntryExtensionV2Ext Decode(XdrDataInputStream stream) {
    TrustLineEntryExtensionV2Ext decodedTrustLineEntryExtensionV2Ext = new TrustLineEntryExtensionV2Ext();
    int discriminant =  stream.ReadInt();
    decodedTrustLineEntryExtensionV2Ext.Discriminant = discriminant;
    switch (decodedTrustLineEntryExtensionV2Ext.Discriminant) {
    case 0:
    break;
    }
      return decodedTrustLineEntryExtensionV2Ext;
    }

  }
}
}
