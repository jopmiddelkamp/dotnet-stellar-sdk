// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  enum RevokeSponsorshipResultCode
//  {
//      // codes considered as "success" for the operation
//      REVOKE_SPONSORSHIP_SUCCESS = 0,
//  
//      // codes considered as "failure" for the operation
//      REVOKE_SPONSORSHIP_DOES_NOT_EXIST = -1,
//      REVOKE_SPONSORSHIP_NOT_SPONSOR = -2,
//      REVOKE_SPONSORSHIP_LOW_RESERVE = -3,
//      REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = -4
//  };

//  ===========================================================================
public class RevokeSponsorshipResultCode  {
  public enum RevokeSponsorshipResultCodeEnum {
  REVOKE_SPONSORSHIP_SUCCESS = 0,
  REVOKE_SPONSORSHIP_DOES_NOT_EXIST = -1,
  REVOKE_SPONSORSHIP_NOT_SPONSOR = -2,
  REVOKE_SPONSORSHIP_LOW_RESERVE = -3,
  REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE = -4,
  }
  public RevokeSponsorshipResultCodeEnum InnerValue {get; set;} = default(RevokeSponsorshipResultCodeEnum);

  public static RevokeSponsorshipResultCode Create(RevokeSponsorshipResultCodeEnum v)
  {
    return new RevokeSponsorshipResultCode {
      InnerValue = v
    };
  }

  public static RevokeSponsorshipResultCode Decode(XdrDataInputStream stream) {
    int value = stream.ReadInt();
    switch (value) {
      case 0: return Create(RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_SUCCESS);
      case -1: return Create(RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_DOES_NOT_EXIST);
      case -2: return Create(RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_NOT_SPONSOR);
      case -3: return Create(RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_LOW_RESERVE);
      case -4: return Create(RevokeSponsorshipResultCodeEnum.REVOKE_SPONSORSHIP_ONLY_TRANSFERABLE);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(XdrDataOutputStream stream, RevokeSponsorshipResultCode value) {
    stream.WriteInt((int)value.InnerValue);
  }
}
}
