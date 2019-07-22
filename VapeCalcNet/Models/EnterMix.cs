using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VapeCalc.Models
{
    public class EnterMix
    {
        /// <summary>
        /// Пропиленгликоль
        /// </summary>
        [Required]
        [Display(Name ="Пропиленгликоля (%)")]
        public double PG { get; set; }
        /// <summary>
        /// Глицерин
        /// </summary>
        [Required]
        [Display(Name = "Глицерина (%)")]        
        public double VG { get; set; }
        /// <summary>
        /// Никотин
        /// </summary>
        [Required]
        [Display(Name = "Никотина (%)")]
        public double Nic { get; set; }
        /// <summary>
        /// Вода
        /// </summary>
        [Required]
        [Display(Name = "Воды (%)")]
        public double H2O { get; set; }
        /// <summary>
        /// Ароматизатор
        /// </summary>
        [Required]
        [Display(Name = "Ароматизаторов (%) ")]
        public double Aroma { get; set; }
        /// <summary>
        /// Требуемый объем
        /// </summary>
        [Required]
        [Display(Name = "Объем (мл)")]
        public double Volume { get; set; }
        /// <summary>
        /// Концентрация никотина в базе
        /// </summary>
        [Required]
        [Display(Name = "Концентрация никотина в базе")]
        public double NicMix { get; set; }
        
    }
}
