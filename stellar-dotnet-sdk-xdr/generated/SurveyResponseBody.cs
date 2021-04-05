// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr {

// === xdr source ============================================================

//  union SurveyResponseBody switch (SurveyMessageCommandType type)
//  {
//  case SURVEY_TOPOLOGY:
//      TopologyResponseBody topologyResponseBody;
//  };

//  ===========================================================================
public class SurveyResponseBody  {
  public SurveyResponseBody () {}

  public SurveyMessageCommandType Discriminant { get; set; } = new SurveyMessageCommandType();

  public TopologyResponseBody TopologyResponseBody {get; set;}
  public static void Encode(XdrDataOutputStream stream, SurveyResponseBody encodedSurveyResponseBody) {
  stream.WriteInt((int)encodedSurveyResponseBody.Discriminant.InnerValue);
  switch (encodedSurveyResponseBody.Discriminant.InnerValue) {
  case SurveyMessageCommandType.SurveyMessageCommandTypeEnum.SURVEY_TOPOLOGY:
  TopologyResponseBody.Encode(stream, encodedSurveyResponseBody.TopologyResponseBody);
  break;
  }
  }
  public static SurveyResponseBody Decode(XdrDataInputStream stream) {
  SurveyResponseBody decodedSurveyResponseBody = new SurveyResponseBody();
  SurveyMessageCommandType discriminant = SurveyMessageCommandType.Decode(stream);
  decodedSurveyResponseBody.Discriminant = discriminant;
  switch (decodedSurveyResponseBody.Discriminant.InnerValue) {
  case SurveyMessageCommandType.SurveyMessageCommandTypeEnum.SURVEY_TOPOLOGY:
  decodedSurveyResponseBody.TopologyResponseBody = TopologyResponseBody.Decode(stream);
  break;
  }
    return decodedSurveyResponseBody;
  }
}
}
