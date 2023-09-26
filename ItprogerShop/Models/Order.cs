using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace ItprogerShop.Models
{
    public class Order
    {
        [BindNever]
        public int Id { get; set; }

        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [StringLength(30, ErrorMessage ="Имя должно быть менее 30 символов")]    
        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
        [StringLength(50, ErrorMessage = "Фамилия должна быть менее 50 символов")]
        public string Surname { get; set; }

        [Display(Name = "Введите адрес")]
        [Required(ErrorMessage = "Адрес обязателен для заполнения")]
        [StringLength(50, ErrorMessage = "Адрес должен быть менее 50 символов")]
        public string Adress { get; set; }

        [Display(Name = "Введите телефон")]
        [Required(ErrorMessage = "Телефон обязателен для заполнения")]
        [StringLength(20, ErrorMessage = "Телефон должен быть менее 20 символов")]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        
        [Display(Name = "Введите email")]
        [Required(ErrorMessage = "Email обязателен для заполнения")]
        [StringLength(20, ErrorMessage = "Email должен быть менее 20 символов")]
        [EmailAddress(ErrorMessage ="Вы ввели не почту")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Ваша корзина пуста")]
        public string Cart { get; set; }

    }
}
