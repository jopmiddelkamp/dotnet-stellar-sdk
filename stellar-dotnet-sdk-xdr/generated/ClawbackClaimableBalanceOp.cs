// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct ClawbackClaimableBalanceOp
//  {
//      ClaimableBalanceID balanceID;
//  };

//  ===========================================================================
public class ClawbackClaimableBalanceOp  {
  public ClawbackClaimableBalanceOp () {}
  public ClaimableBalanceID BalanceID {get; set;}

  public static void Encode(XdrDataOutputStream stream, ClawbackClaimableBalanceOp encodedClawbackClaimableBalanceOp) {
    ClaimableBalanceID.Encode(stream, encodedClawbackClaimableBalanceOp.BalanceID);
  }
  public static ClawbackClaimableBalanceOp Decode(XdrDataInputStream stream) {
    ClawbackClaimableBalanceOp decodedClawbackClaimableBalanceOp = new ClawbackClaimableBalanceOp();
    decodedClawbackClaimableBalanceOp.BalanceID = ClaimableBalanceID.Decode(stream);
    return decodedClawbackClaimableBalanceOp;
  }
}
}
