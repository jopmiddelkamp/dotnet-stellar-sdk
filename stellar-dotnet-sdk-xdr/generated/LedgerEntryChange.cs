// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union LedgerEntryChange switch (LedgerEntryChangeType type)
//  {
//  case LEDGER_ENTRY_CREATED:
//      LedgerEntry created;
//  case LEDGER_ENTRY_UPDATED:
//      LedgerEntry updated;
//  case LEDGER_ENTRY_REMOVED:
//      LedgerKey removed;
//  case LEDGER_ENTRY_STATE:
//      LedgerEntry state;
//  };

//  ===========================================================================
public class LedgerEntryChange  {
  public LedgerEntryChange () {}

  public LedgerEntryChangeType Discriminant { get; set; } = new LedgerEntryChangeType();

  public LedgerEntry Created {get; set;}
  public LedgerEntry Updated {get; set;}
  public LedgerKey Removed {get; set;}
  public LedgerEntry State {get; set;}
  public static void Encode(XdrDataOutputStream stream, LedgerEntryChange encodedLedgerEntryChange) {
  stream.WriteInt((int)encodedLedgerEntryChange.Discriminant.InnerValue);
  switch (encodedLedgerEntryChange.Discriminant.InnerValue) {
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_CREATED:
  LedgerEntry.Encode(stream, encodedLedgerEntryChange.Created);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_UPDATED:
  LedgerEntry.Encode(stream, encodedLedgerEntryChange.Updated);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_REMOVED:
  LedgerKey.Encode(stream, encodedLedgerEntryChange.Removed);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_STATE:
  LedgerEntry.Encode(stream, encodedLedgerEntryChange.State);
  break;
  }
  }
  public static LedgerEntryChange Decode(XdrDataInputStream stream) {
  LedgerEntryChange decodedLedgerEntryChange = new LedgerEntryChange();
  LedgerEntryChangeType discriminant = LedgerEntryChangeType.Decode(stream);
  decodedLedgerEntryChange.Discriminant = discriminant;
  switch (decodedLedgerEntryChange.Discriminant.InnerValue) {
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_CREATED:
  decodedLedgerEntryChange.Created = LedgerEntry.Decode(stream);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_UPDATED:
  decodedLedgerEntryChange.Updated = LedgerEntry.Decode(stream);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_REMOVED:
  decodedLedgerEntryChange.Removed = LedgerKey.Decode(stream);
  break;
  case LedgerEntryChangeType.LedgerEntryChangeTypeEnum.LEDGER_ENTRY_STATE:
  decodedLedgerEntryChange.State = LedgerEntry.Decode(stream);
  break;
  }
    return decodedLedgerEntryChange;
  }
}
}
