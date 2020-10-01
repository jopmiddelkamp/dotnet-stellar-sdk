// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union BeginSponsoringFutureReservesResult switch (BeginSponsoringFutureReservesResultCode code)
//  {
//  case BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
//      void;
//  default:
//      void;
//  };
//  ===========================================================================
    public class BeginSponsoringFutureReservesResult
    {
        public BeginSponsoringFutureReservesResult()
        {
        }

        public BeginSponsoringFutureReservesResultCode Discriminant { get; set; } =
            new BeginSponsoringFutureReservesResultCode();

        public static void Encode(XdrDataOutputStream stream,
            BeginSponsoringFutureReservesResult encodedBeginSponsoringFutureReservesResult)
        {
            stream.WriteInt((int) encodedBeginSponsoringFutureReservesResult.Discriminant.InnerValue);
            switch (encodedBeginSponsoringFutureReservesResult.Discriminant.InnerValue)
            {
                case BeginSponsoringFutureReservesResultCode.BeginSponsoringFutureReservesResultCodeEnum
                    .BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                    break;
                default:
                    break;
            }
        }

        public static BeginSponsoringFutureReservesResult Decode(XdrDataInputStream stream)
        {
            BeginSponsoringFutureReservesResult decodedBeginSponsoringFutureReservesResult =
                new BeginSponsoringFutureReservesResult();
            BeginSponsoringFutureReservesResultCode discriminant =
                BeginSponsoringFutureReservesResultCode.Decode(stream);
            decodedBeginSponsoringFutureReservesResult.Discriminant = discriminant;
            switch (decodedBeginSponsoringFutureReservesResult.Discriminant.InnerValue)
            {
                case BeginSponsoringFutureReservesResultCode.BeginSponsoringFutureReservesResultCodeEnum
                    .BEGIN_SPONSORING_FUTURE_RESERVES_SUCCESS:
                    break;
                default:
                    break;
            }

            return decodedBeginSponsoringFutureReservesResult;
        }
    }
}