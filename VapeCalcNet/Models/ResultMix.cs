using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VapeCalc.Models
{
    public class ResultMix
    {
        /// <summary>
        /// Пропиленгликоль
        /// </summary>
        [Display(Name = "Пропиленгликоля (мл)")]
        public double PG { get; set; }
        /// <summary>
        /// Глицерин
        /// </summary>
        [Display(Name = "Глицерина (мл)")]
        public double VG { get; set; }
        /// <summary>
        /// Никотин
        /// </summary>
        [Display(Name = "Никотина (мл)")]
        public double Nic { get; set; }
        /// <summary>
        /// Вода
        /// </summary>
        [Display(Name = "Воды (мл)")]
        public double H20 { get; set; }
        /// <summary>
        /// Ароматизатор
        /// </summary>
        [Display(Name = "Ароматизаторов (мл) ")]
        public double Aroma { get; set; }
    }
}
