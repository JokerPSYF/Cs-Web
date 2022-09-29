using System.ComponentModel.DataAnnotations;

namespace MVC_Intro_Demo.Models
{
    public class ProductViewModel
    {
        /// <summary>
        /// Id of product
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of product
        /// </summary>
        public string Name { get; set; } = null!;

        public double Price { get; set; }
    }
}
