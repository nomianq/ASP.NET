using System.ComponentModel.DataAnnotations;

namespace ItprogerShop.Models;
public class Blog
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Введите название")]
    [Required(ErrorMessage = "Название обязательно для заполнения")]
    [StringLength(30, ErrorMessage = "Название должно быть менее 30 символов")]
    public string Title { get; set; }

    [Display(Name = "Введите анонс")]
    [Required(ErrorMessage = "Анонс обязателен для заполнения")]
    [StringLength(50, ErrorMessage = "Анонс должен быть менее 50 символов")]
    public string Anons { get; set; }

    [Display(Name = "Введите текст")]
    [Required(ErrorMessage = "Текст обязателен для заполнения")]
    [StringLength(100, ErrorMessage = "Текст должен быть менее 100 символов")]
    public string FullText { get; set; }

}
