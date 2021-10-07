// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  enum LiquidityPoolWithdrawResultCode
    //  {
    //      // codes considered as "success" for the operation
    //      LIQUIDITY_POOL_WITHDRAW_SUCCESS = 0,
    //  
    //      // codes considered as "failure" for the operation
    //      LIQUIDITY_POOL_WITHDRAW_MALFORMED = -1,      // bad input
    //      LIQUIDITY_POOL_WITHDRAW_NO_TRUST = -2,       // no trust line for one of the
    //                                                   // assets
    //      LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = -3,    // not enough balance of the
    //                                                   // pool share
    //      LIQUIDITY_POOL_WITHDRAW_LINE_FULL = -4,      // would go above limit for one
    //                                                   // of the assets
    //      LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = -5   // didn't withdraw enough
    //  };

    //  ===========================================================================
    public class LiquidityPoolWithdrawResultCode
    {
        public enum LiquidityPoolWithdrawResultCodeEnum
        {
            LIQUIDITY_POOL_WITHDRAW_SUCCESS = 0,
            LIQUIDITY_POOL_WITHDRAW_MALFORMED = -1,
            LIQUIDITY_POOL_WITHDRAW_NO_TRUST = -2,
            LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED = -3,
            LIQUIDITY_POOL_WITHDRAW_LINE_FULL = -4,
            LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM = -5,
        }
        public LiquidityPoolWithdrawResultCodeEnum InnerValue { get; set; } = default(LiquidityPoolWithdrawResultCodeEnum);

        public static LiquidityPoolWithdrawResultCode Create(LiquidityPoolWithdrawResultCodeEnum v)
        {
            return new LiquidityPoolWithdrawResultCode
            {
                InnerValue = v
            };
        }

        public static LiquidityPoolWithdrawResultCode Decode(XdrDataInputStream stream)
        {
            int value = stream.ReadInt();
            switch (value)
            {
                case 0: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_SUCCESS);
                case -1: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_MALFORMED);
                case -2: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_NO_TRUST);
                case -3: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_UNDERFUNDED);
                case -4: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_LINE_FULL);
                case -5: return Create(LiquidityPoolWithdrawResultCodeEnum.LIQUIDITY_POOL_WITHDRAW_UNDER_MINIMUM);
                default:
                    throw new Exception("Unknown enum value: " + value);
            }
        }

        public static void Encode(XdrDataOutputStream stream, LiquidityPoolWithdrawResultCode value)
        {
            stream.WriteInt((int)value.InnerValue);
        }
    }
}
