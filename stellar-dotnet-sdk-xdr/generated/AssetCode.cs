// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union AssetCode switch (AssetType type)
//  {
//  case ASSET_TYPE_CREDIT_ALPHANUM4:
//      AssetCode4 assetCode4;
//  
//  case ASSET_TYPE_CREDIT_ALPHANUM12:
//      AssetCode12 assetCode12;
//  
//      // add other asset types here in the future
//  };

//  ===========================================================================
public class AssetCode  {
  public AssetCode () {}

  public AssetType Discriminant { get; set; } = new AssetType();

  public AssetCode4 AssetCode4 {get; set;}
  public AssetCode12 AssetCode12 {get; set;}
  public static void Encode(XdrDataOutputStream stream, AssetCode encodedAssetCode) {
  stream.WriteInt((int)encodedAssetCode.Discriminant.InnerValue);
  switch (encodedAssetCode.Discriminant.InnerValue) {
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
  AssetCode4.Encode(stream, encodedAssetCode.AssetCode4);
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
  AssetCode12.Encode(stream, encodedAssetCode.AssetCode12);
  break;
  }
  }
  public static AssetCode Decode(XdrDataInputStream stream) {
  AssetCode decodedAssetCode = new AssetCode();
  AssetType discriminant = AssetType.Decode(stream);
  decodedAssetCode.Discriminant = discriminant;
  switch (decodedAssetCode.Discriminant.InnerValue) {
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM4:
  decodedAssetCode.AssetCode4 = AssetCode4.Decode(stream);
  break;
  case AssetType.AssetTypeEnum.ASSET_TYPE_CREDIT_ALPHANUM12:
  decodedAssetCode.AssetCode12 = AssetCode12.Decode(stream);
  break;
  }
    return decodedAssetCode;
  }
}
}
