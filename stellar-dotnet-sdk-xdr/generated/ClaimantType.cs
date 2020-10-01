// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  enum ClaimantType
//  {
//      CLAIMANT_TYPE_V0 = 0
//  };
//  ===========================================================================
    public class ClaimantType
    {
        public enum ClaimantTypeEnum
        {
            CLAIMANT_TYPE_V0 = 0,
        }

        public ClaimantTypeEnum InnerValue { get; set; } = default(ClaimantTypeEnum);

        public static ClaimantType Create(ClaimantTypeEnum v)
        {
            return new ClaimantType
            {
                InnerValue = v
            };
        }

        public static ClaimantType Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(ClaimantTypeEnum.CLAIMANT_TYPE_V0);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, ClaimantType value)
        {
            stream.WriteInt((int) value.InnerValue);
        }
    }
}