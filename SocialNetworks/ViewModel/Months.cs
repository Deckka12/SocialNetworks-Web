using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SocialNetworks.ViewModel {
    public enum Months {
        [Display(Name = "Январь")]
        Jan = 1,
        [Display(Name = "Февраль")]
        Feb ,
        [Display(Name = "Март")]
        Mar ,
        [Display(Name = "Аперль")]
        Apr,
        [Display(Name = "Май")]
        May,
        [Display(Name = "Июнь")]
        June,
        [Display(Name = "Июль")]
        Jule,
        [Display(Name = "Август")]
        Aug,
        [Display(Name = "Сентябрь")]
        Sep,
        [Display(Name = "Октябрь")]
        Oct,
        [Display(Name = "Ноябрь")]
        Nov,
        [Display(Name = "Декабрь")]
        Dec,
    }
}
