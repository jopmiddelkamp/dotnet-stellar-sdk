// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================
//  union StellarMessage switch (MessageType type)
//  {
//  case ERROR_MSG:
//      Error error;
//  case HELLO:
//      Hello hello;
//  case AUTH:
//      Auth auth;
//  case DONT_HAVE:
//      DontHave dontHave;
//  case GET_PEERS:
//      void;
//  case PEERS:
//      PeerAddress peers<100>;
//  
//  case GET_TX_SET:
//      uint256 txSetHash;
//  case TX_SET:
//      TransactionSet txSet;
//  
//  case TRANSACTION:
//      TransactionEnvelope transaction;
//  
//  case SURVEY_REQUEST:
//      SignedSurveyRequestMessage signedSurveyRequestMessage;
//  
//  case SURVEY_RESPONSE:
//      SignedSurveyResponseMessage signedSurveyResponseMessage;
//  
//  // SCP
//  case GET_SCP_QUORUMSET:
//      uint256 qSetHash;
//  case SCP_QUORUMSET:
//      SCPQuorumSet qSet;
//  case SCP_MESSAGE:
//      SCPEnvelope envelope;
//  case GET_SCP_STATE:
//      uint32 getSCPLedgerSeq; // ledger seq requested ; if 0, requests the latest
//  };
//  ===========================================================================
    public class StellarMessage
    {
        public StellarMessage()
        {
        }

        public MessageType Discriminant { get; set; } = new MessageType();

        public Error Error { get; set; }
        public Hello Hello { get; set; }
        public Auth Auth { get; set; }
        public DontHave DontHave { get; set; }
        public PeerAddress[] Peers { get; set; }
        public Uint256 TxSetHash { get; set; }
        public TransactionSet TxSet { get; set; }
        public TransactionEnvelope Transaction { get; set; }
        public SignedSurveyRequestMessage SignedSurveyRequestMessage { get; set; }
        public SignedSurveyResponseMessage SignedSurveyResponseMessage { get; set; }
        public Uint256 QSetHash { get; set; }
        public SCPQuorumSet QSet { get; set; }
        public SCPEnvelope Envelope { get; set; }
        public Uint32 GetSCPLedgerSeq { get; set; }

        public static void Encode(XdrDataOutputStream stream, StellarMessage encodedStellarMessage)
        {
            stream.WriteInt((int) encodedStellarMessage.Discriminant.InnerValue);
            switch (encodedStellarMessage.Discriminant.InnerValue)
            {
                case MessageType.MessageTypeEnum.ERROR_MSG:
                    Error.Encode(stream, encodedStellarMessage.Error);
                    break;
                case MessageType.MessageTypeEnum.HELLO:
                    Hello.Encode(stream, encodedStellarMessage.Hello);
                    break;
                case MessageType.MessageTypeEnum.AUTH:
                    Auth.Encode(stream, encodedStellarMessage.Auth);
                    break;
                case MessageType.MessageTypeEnum.DONT_HAVE:
                    DontHave.Encode(stream, encodedStellarMessage.DontHave);
                    break;
                case MessageType.MessageTypeEnum.GET_PEERS:
                    break;
                case MessageType.MessageTypeEnum.PEERS:
                    int peerssize = encodedStellarMessage.Peers.Length;
                    stream.WriteInt(peerssize);
                    for (int i = 0; i < peerssize; i++)
                    {
                        PeerAddress.Encode(stream, encodedStellarMessage.Peers[i]);
                    }

                    break;
                case MessageType.MessageTypeEnum.GET_TX_SET:
                    Uint256.Encode(stream, encodedStellarMessage.TxSetHash);
                    break;
                case MessageType.MessageTypeEnum.TX_SET:
                    TransactionSet.Encode(stream, encodedStellarMessage.TxSet);
                    break;
                case MessageType.MessageTypeEnum.TRANSACTION:
                    TransactionEnvelope.Encode(stream, encodedStellarMessage.Transaction);
                    break;
                case MessageType.MessageTypeEnum.SURVEY_REQUEST:
                    SignedSurveyRequestMessage.Encode(stream, encodedStellarMessage.SignedSurveyRequestMessage);
                    break;
                case MessageType.MessageTypeEnum.SURVEY_RESPONSE:
                    SignedSurveyResponseMessage.Encode(stream, encodedStellarMessage.SignedSurveyResponseMessage);
                    break;
                case MessageType.MessageTypeEnum.GET_SCP_QUORUMSET:
                    Uint256.Encode(stream, encodedStellarMessage.QSetHash);
                    break;
                case MessageType.MessageTypeEnum.SCP_QUORUMSET:
                    SCPQuorumSet.Encode(stream, encodedStellarMessage.QSet);
                    break;
                case MessageType.MessageTypeEnum.SCP_MESSAGE:
                    SCPEnvelope.Encode(stream, encodedStellarMessage.Envelope);
                    break;
                case MessageType.MessageTypeEnum.GET_SCP_STATE:
                    Uint32.Encode(stream, encodedStellarMessage.GetSCPLedgerSeq);
                    break;
            }
        }

        public static StellarMessage Decode(XdrDataInputStream stream)
        {
            StellarMessage decodedStellarMessage = new StellarMessage();
            MessageType discriminant = MessageType.Decode(stream);
            decodedStellarMessage.Discriminant = discriminant;
            switch (decodedStellarMessage.Discriminant.InnerValue)
            {
                case MessageType.MessageTypeEnum.ERROR_MSG:
                    decodedStellarMessage.Error = Error.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.HELLO:
                    decodedStellarMessage.Hello = Hello.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.AUTH:
                    decodedStellarMessage.Auth = Auth.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.DONT_HAVE:
                    decodedStellarMessage.DontHave = DontHave.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.GET_PEERS:
                    break;
                case MessageType.MessageTypeEnum.PEERS:
                    int peerssize = stream.ReadInt();
                    decodedStellarMessage.Peers = new PeerAddress[peerssize];
                    for (int i = 0; i < peerssize; i++)
                    {
                        decodedStellarMessage.Peers[i] = PeerAddress.Decode(stream);
                    }

                    break;
                case MessageType.MessageTypeEnum.GET_TX_SET:
                    decodedStellarMessage.TxSetHash = Uint256.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.TX_SET:
                    decodedStellarMessage.TxSet = TransactionSet.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.TRANSACTION:
                    decodedStellarMessage.Transaction = TransactionEnvelope.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.SURVEY_REQUEST:
                    decodedStellarMessage.SignedSurveyRequestMessage = SignedSurveyRequestMessage.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.SURVEY_RESPONSE:
                    decodedStellarMessage.SignedSurveyResponseMessage = SignedSurveyResponseMessage.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.GET_SCP_QUORUMSET:
                    decodedStellarMessage.QSetHash = Uint256.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.SCP_QUORUMSET:
                    decodedStellarMessage.QSet = SCPQuorumSet.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.SCP_MESSAGE:
                    decodedStellarMessage.Envelope = SCPEnvelope.Decode(stream);
                    break;
                case MessageType.MessageTypeEnum.GET_SCP_STATE:
                    decodedStellarMessage.GetSCPLedgerSeq = Uint32.Decode(stream);
                    break;
            }

            return decodedStellarMessage;
        }
    }
}