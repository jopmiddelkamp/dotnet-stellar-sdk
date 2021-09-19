// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct TransactionHistoryResultEntry
//  {
//      uint32 ledgerSeq;
//      TransactionResultSet txResultSet;
//  
//      // reserved for future use
//      union switch (int v)
//      {
//      case 0:
//          void;
//      }
//      ext;
//  };

//  ===========================================================================
public class TransactionHistoryResultEntry  {
  public TransactionHistoryResultEntry () {}
  public Uint32 LedgerSeq {get; set;}
  public TransactionResultSet TxResultSet {get; set;}
  public TransactionHistoryResultEntryExt Ext {get; set;}

  public static void Encode(XdrDataOutputStream stream, TransactionHistoryResultEntry encodedTransactionHistoryResultEntry) {
    Uint32.Encode(stream, encodedTransactionHistoryResultEntry.LedgerSeq);
    TransactionResultSet.Encode(stream, encodedTransactionHistoryResultEntry.TxResultSet);
    TransactionHistoryResultEntryExt.Encode(stream, encodedTransactionHistoryResultEntry.Ext);
  }
  public static TransactionHistoryResultEntry Decode(XdrDataInputStream stream) {
    TransactionHistoryResultEntry decodedTransactionHistoryResultEntry = new TransactionHistoryResultEntry();
    decodedTransactionHistoryResultEntry.LedgerSeq = Uint32.Decode(stream);
    decodedTransactionHistoryResultEntry.TxResultSet = TransactionResultSet.Decode(stream);
    decodedTransactionHistoryResultEntry.Ext = TransactionHistoryResultEntryExt.Decode(stream);
    return decodedTransactionHistoryResultEntry;
  }

  public class TransactionHistoryResultEntryExt {
    public TransactionHistoryResultEntryExt () {}

    public int Discriminant { get; set; } = new int();

    public static void Encode(XdrDataOutputStream stream, TransactionHistoryResultEntryExt encodedTransactionHistoryResultEntryExt) {
    stream.WriteInt((int)encodedTransactionHistoryResultEntryExt.Discriminant);
    switch (encodedTransactionHistoryResultEntryExt.Discriminant) {
    case 0:
    break;
    }
    }
    public static TransactionHistoryResultEntryExt Decode(XdrDataInputStream stream) {
    TransactionHistoryResultEntryExt decodedTransactionHistoryResultEntryExt = new TransactionHistoryResultEntryExt();
    int discriminant =  stream.ReadInt();
    decodedTransactionHistoryResultEntryExt.Discriminant = discriminant;
    switch (decodedTransactionHistoryResultEntryExt.Discriminant) {
    case 0:
    break;
    }
      return decodedTransactionHistoryResultEntryExt;
    }

  }
}
}
