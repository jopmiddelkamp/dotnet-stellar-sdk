// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct ManageOfferSuccessResult
//  {
//      // offers that got claimed while creating this offer
//      ClaimOfferAtom offersClaimed<>;
//  
//      union switch (ManageOfferEffect effect)
//      {
//      case MANAGE_OFFER_CREATED:
//      case MANAGE_OFFER_UPDATED:
//          OfferEntry offer;
//      default:
//          void;
//      }
//      offer;
//  };

//  ===========================================================================
public class ManageOfferSuccessResult  {
  public ManageOfferSuccessResult () {}
  public ClaimOfferAtom[] OffersClaimed {get; set;}
  public ManageOfferSuccessResultOffer Offer {get; set;}

  public static void Encode(XdrDataOutputStream stream, ManageOfferSuccessResult encodedManageOfferSuccessResult) {
    int offersClaimedsize = encodedManageOfferSuccessResult.OffersClaimed.Length;
    stream.WriteInt(offersClaimedsize);
    for (int i = 0; i < offersClaimedsize; i++) {
      ClaimOfferAtom.Encode(stream, encodedManageOfferSuccessResult.OffersClaimed[i]);
    }
    ManageOfferSuccessResultOffer.Encode(stream, encodedManageOfferSuccessResult.Offer);
  }
  public static ManageOfferSuccessResult Decode(XdrDataInputStream stream) {
    ManageOfferSuccessResult decodedManageOfferSuccessResult = new ManageOfferSuccessResult();
    int offersClaimedsize = stream.ReadInt();
    decodedManageOfferSuccessResult.OffersClaimed = new ClaimOfferAtom[offersClaimedsize];
    for (int i = 0; i < offersClaimedsize; i++) {
      decodedManageOfferSuccessResult.OffersClaimed[i] = ClaimOfferAtom.Decode(stream);
    }
    decodedManageOfferSuccessResult.Offer = ManageOfferSuccessResultOffer.Decode(stream);
    return decodedManageOfferSuccessResult;
  }

  public class ManageOfferSuccessResultOffer {
    public ManageOfferSuccessResultOffer () {}

    public ManageOfferEffect Discriminant { get; set; } = new ManageOfferEffect();

    public OfferEntry Offer {get; set;}
    public static void Encode(XdrDataOutputStream stream, ManageOfferSuccessResultOffer encodedManageOfferSuccessResultOffer) {
    stream.WriteInt((int)encodedManageOfferSuccessResultOffer.Discriminant.InnerValue);
    switch (encodedManageOfferSuccessResultOffer.Discriminant.InnerValue) {
    case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_CREATED:
    case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_UPDATED:
    OfferEntry.Encode(stream, encodedManageOfferSuccessResultOffer.Offer);
    break;
    default:
    break;
    }
    }
    public static ManageOfferSuccessResultOffer Decode(XdrDataInputStream stream) {
    ManageOfferSuccessResultOffer decodedManageOfferSuccessResultOffer = new ManageOfferSuccessResultOffer();
    ManageOfferEffect discriminant = ManageOfferEffect.Decode(stream);
    decodedManageOfferSuccessResultOffer.Discriminant = discriminant;
    switch (decodedManageOfferSuccessResultOffer.Discriminant.InnerValue) {
    case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_CREATED:
    case ManageOfferEffect.ManageOfferEffectEnum.MANAGE_OFFER_UPDATED:
    decodedManageOfferSuccessResultOffer.Offer = OfferEntry.Decode(stream);
    break;
    default:
    break;
    }
      return decodedManageOfferSuccessResultOffer;
    }

  }
}
}
