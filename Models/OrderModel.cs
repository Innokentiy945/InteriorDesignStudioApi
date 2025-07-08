using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace InteriorDesignStudioApi.Models;

public class OrderModel
{
    [Key]
    public Guid OrderId { get; set; }
    public string OrderNumber { get; set; }
    public DateTime OrderDate { get; set; }
    public string OrderDetails { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
}