using System.ComponentModel.DataAnnotations;
namespace VendasMvc.ViewModels;
public class VendaFormVM
{
    [Required]
    public int ClienteId { get; set; }
    public List<VendaItemVM> Itens { get; set; } = new();
}
