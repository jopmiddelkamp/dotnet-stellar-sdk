// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  struct AccountEntryExtensionV1
//  {
//      Liabilities liabilities;
//  
//      union switch (int v)
//      {
//      case 0:
//          void;
//      case 2:
//          AccountEntryExtensionV2 v2;
//      }
//      ext;
//  };

//  ===========================================================================
public class AccountEntryExtensionV1  {
  public AccountEntryExtensionV1 () {}
  public Liabilities Liabilities {get; set;}
  public AccountEntryExtensionV1Ext Ext {get; set;}

  public static void Encode(XdrDataOutputStream stream, AccountEntryExtensionV1 encodedAccountEntryExtensionV1) {
    Liabilities.Encode(stream, encodedAccountEntryExtensionV1.Liabilities);
    AccountEntryExtensionV1Ext.Encode(stream, encodedAccountEntryExtensionV1.Ext);
  }
  public static AccountEntryExtensionV1 Decode(XdrDataInputStream stream) {
    AccountEntryExtensionV1 decodedAccountEntryExtensionV1 = new AccountEntryExtensionV1();
    decodedAccountEntryExtensionV1.Liabilities = Liabilities.Decode(stream);
    decodedAccountEntryExtensionV1.Ext = AccountEntryExtensionV1Ext.Decode(stream);
    return decodedAccountEntryExtensionV1;
  }

  public class AccountEntryExtensionV1Ext {
    public AccountEntryExtensionV1Ext () {}

    public int Discriminant { get; set; } = new int();

    public AccountEntryExtensionV2 V2 {get; set;}
    public static void Encode(XdrDataOutputStream stream, AccountEntryExtensionV1Ext encodedAccountEntryExtensionV1Ext) {
    stream.WriteInt((int)encodedAccountEntryExtensionV1Ext.Discriminant);
    switch (encodedAccountEntryExtensionV1Ext.Discriminant) {
    case 0:
    break;
    case 2:
    AccountEntryExtensionV2.Encode(stream, encodedAccountEntryExtensionV1Ext.V2);
    break;
    }
    }
    public static AccountEntryExtensionV1Ext Decode(XdrDataInputStream stream) {
    AccountEntryExtensionV1Ext decodedAccountEntryExtensionV1Ext = new AccountEntryExtensionV1Ext();
    int discriminant =  stream.ReadInt();
    decodedAccountEntryExtensionV1Ext.Discriminant = discriminant;
    switch (decodedAccountEntryExtensionV1Ext.Discriminant) {
    case 0:
    break;
    case 2:
    decodedAccountEntryExtensionV1Ext.V2 = AccountEntryExtensionV2.Decode(stream);
    break;
    }
      return decodedAccountEntryExtensionV1Ext;
    }

  }
}
}
