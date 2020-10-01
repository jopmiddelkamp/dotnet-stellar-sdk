// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  struct BeginSponsoringFutureReservesOp
//  {
//      AccountID sponsoredID;
//  };
//  ===========================================================================
    public class BeginSponsoringFutureReservesOp
    {
        public BeginSponsoringFutureReservesOp()
        {
        }

        public AccountID SponsoredID { get; set; }

        public static void Encode(XdrDataOutputStream stream,
            BeginSponsoringFutureReservesOp encodedBeginSponsoringFutureReservesOp)
        {
            AccountID.Encode(stream, encodedBeginSponsoringFutureReservesOp.SponsoredID);
        }

        public static BeginSponsoringFutureReservesOp Decode(XdrDataInputStream stream)
        {
            BeginSponsoringFutureReservesOp decodedBeginSponsoringFutureReservesOp =
                new BeginSponsoringFutureReservesOp();
            decodedBeginSponsoringFutureReservesOp.SponsoredID = AccountID.Decode(stream);
            return decodedBeginSponsoringFutureReservesOp;
        }
    }
}