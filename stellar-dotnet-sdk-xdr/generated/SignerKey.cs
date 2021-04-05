// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union SignerKey switch (SignerKeyType type)
//  {
//  case SIGNER_KEY_TYPE_ED25519:
//      uint256 ed25519;
//  case SIGNER_KEY_TYPE_PRE_AUTH_TX:
//      /* SHA-256 Hash of TransactionSignaturePayload structure */
//      uint256 preAuthTx;
//  case SIGNER_KEY_TYPE_HASH_X:
//      /* Hash of random 256 bit preimage X */
//      uint256 hashX;
//  };

//  ===========================================================================
public class SignerKey  {
  public SignerKey () {}

  public SignerKeyType Discriminant { get; set; } = new SignerKeyType();

  public Uint256 Ed25519 {get; set;}
  public Uint256 PreAuthTx {get; set;}
  public Uint256 HashX {get; set;}
  public static void Encode(XdrDataOutputStream stream, SignerKey encodedSignerKey) {
  stream.WriteInt((int)encodedSignerKey.Discriminant.InnerValue);
  switch (encodedSignerKey.Discriminant.InnerValue) {
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_ED25519:
  Uint256.Encode(stream, encodedSignerKey.Ed25519);
  break;
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_PRE_AUTH_TX:
  Uint256.Encode(stream, encodedSignerKey.PreAuthTx);
  break;
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_HASH_X:
  Uint256.Encode(stream, encodedSignerKey.HashX);
  break;
  }
  }
  public static SignerKey Decode(XdrDataInputStream stream) {
  SignerKey decodedSignerKey = new SignerKey();
  SignerKeyType discriminant = SignerKeyType.Decode(stream);
  decodedSignerKey.Discriminant = discriminant;
  switch (decodedSignerKey.Discriminant.InnerValue) {
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_ED25519:
  decodedSignerKey.Ed25519 = Uint256.Decode(stream);
  break;
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_PRE_AUTH_TX:
  decodedSignerKey.PreAuthTx = Uint256.Decode(stream);
  break;
  case SignerKeyType.SignerKeyTypeEnum.SIGNER_KEY_TYPE_HASH_X:
  decodedSignerKey.HashX = Uint256.Decode(stream);
  break;
  }
    return decodedSignerKey;
  }
}
}
