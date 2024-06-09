using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models {
  public class StripePaymentDTO {
    public StripePaymentDTO() {
      SuccessUrl = "OrderConfirmation";
      CancelUrl = "Summary";
    }
    [Required]
    public OrderDTO? Order { get; set; }
    [Required]
    public string? SuccessUrl { get; set; }
    [Required]
    public string? CancelUrl { get; set; }
  }
}
