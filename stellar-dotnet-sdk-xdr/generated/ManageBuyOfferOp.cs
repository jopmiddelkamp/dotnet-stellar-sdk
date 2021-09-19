// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct ManageBuyOfferOp
//  {
//      Asset selling;
//      Asset buying;
//      int64 buyAmount; // amount being bought. if set to 0, delete the offer
//      Price price;     // price of thing being bought in terms of what you are
//                       // selling
//  
//      // 0=create a new offer, otherwise edit an existing offer
//      int64 offerID;
//  };

//  ===========================================================================
public class ManageBuyOfferOp  {
  public ManageBuyOfferOp () {}
  public Asset Selling {get; set;}
  public Asset Buying {get; set;}
  public Int64 BuyAmount {get; set;}
  public Price Price {get; set;}
  public Int64 OfferID {get; set;}

  public static void Encode(XdrDataOutputStream stream, ManageBuyOfferOp encodedManageBuyOfferOp) {
    Asset.Encode(stream, encodedManageBuyOfferOp.Selling);
    Asset.Encode(stream, encodedManageBuyOfferOp.Buying);
    Int64.Encode(stream, encodedManageBuyOfferOp.BuyAmount);
    Price.Encode(stream, encodedManageBuyOfferOp.Price);
    Int64.Encode(stream, encodedManageBuyOfferOp.OfferID);
  }
  public static ManageBuyOfferOp Decode(XdrDataInputStream stream) {
    ManageBuyOfferOp decodedManageBuyOfferOp = new ManageBuyOfferOp();
    decodedManageBuyOfferOp.Selling = Asset.Decode(stream);
    decodedManageBuyOfferOp.Buying = Asset.Decode(stream);
    decodedManageBuyOfferOp.BuyAmount = Int64.Decode(stream);
    decodedManageBuyOfferOp.Price = Price.Decode(stream);
    decodedManageBuyOfferOp.OfferID = Int64.Decode(stream);
    return decodedManageBuyOfferOp;
  }
}
}
