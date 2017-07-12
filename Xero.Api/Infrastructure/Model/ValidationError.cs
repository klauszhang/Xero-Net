using System.Runtime.Serialization;

namespace Xero.Api.Infrastructure.Model
{
  [DataContract(Namespace = "")]
  public class ValidationError
  {
    [DataMember(EmitDefaultValue = false)]
    public string Message { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string OrderId { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string CustomerName { get; set; }
  }
}