// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  enum SetOptionsResultCode
//  {
//      // codes considered as "success" for the operation
//      SET_OPTIONS_SUCCESS = 0,
//      // codes considered as "failure" for the operation
//      SET_OPTIONS_LOW_RESERVE = -1,      // not enough funds to add a signer
//      SET_OPTIONS_TOO_MANY_SIGNERS = -2, // max number of signers already reached
//      SET_OPTIONS_BAD_FLAGS = -3,        // invalid combination of clear/set flags
//      SET_OPTIONS_INVALID_INFLATION = -4,      // inflation account does not exist
//      SET_OPTIONS_CANT_CHANGE = -5,            // can no longer change this option
//      SET_OPTIONS_UNKNOWN_FLAG = -6,           // can't set an unknown flag
//      SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = -7, // bad value for weight/threshold
//      SET_OPTIONS_BAD_SIGNER = -8,             // signer cannot be masterkey
//      SET_OPTIONS_INVALID_HOME_DOMAIN = -9,    // malformed home domain
//      SET_OPTIONS_AUTH_REVOCABLE_REQUIRED =
//          -10 // auth revocable is required for clawback
//  };

//  ===========================================================================
public class SetOptionsResultCode  {
  public enum SetOptionsResultCodeEnum {
  SET_OPTIONS_SUCCESS = 0,
  SET_OPTIONS_LOW_RESERVE = -1,
  SET_OPTIONS_TOO_MANY_SIGNERS = -2,
  SET_OPTIONS_BAD_FLAGS = -3,
  SET_OPTIONS_INVALID_INFLATION = -4,
  SET_OPTIONS_CANT_CHANGE = -5,
  SET_OPTIONS_UNKNOWN_FLAG = -6,
  SET_OPTIONS_THRESHOLD_OUT_OF_RANGE = -7,
  SET_OPTIONS_BAD_SIGNER = -8,
  SET_OPTIONS_INVALID_HOME_DOMAIN = -9,
  SET_OPTIONS_AUTH_REVOCABLE_REQUIRED = -10,
  }
  public SetOptionsResultCodeEnum InnerValue {get; set;} = default(SetOptionsResultCodeEnum);

  public static SetOptionsResultCode Create(SetOptionsResultCodeEnum v)
  {
    return new SetOptionsResultCode {
      InnerValue = v
    };
  }

  public static SetOptionsResultCode Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_SUCCESS);
      case -1: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_LOW_RESERVE);
      case -2: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_TOO_MANY_SIGNERS);
      case -3: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_BAD_FLAGS);
      case -4: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_INVALID_INFLATION);
      case -5: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_CANT_CHANGE);
      case -6: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_UNKNOWN_FLAG);
      case -7: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_THRESHOLD_OUT_OF_RANGE);
      case -8: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_BAD_SIGNER);
      case -9: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_INVALID_HOME_DOMAIN);
      case -10: return Create(SetOptionsResultCodeEnum.SET_OPTIONS_AUTH_REVOCABLE_REQUIRED);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(XdrDataOutputStream stream, SetOptionsResultCode value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
