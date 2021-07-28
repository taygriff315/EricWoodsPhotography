using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EricWoodsPhotography.DATA.EF/*.PhotographyMetaData*/
{
    public class PictureMetaData
    {
        [Required(ErrorMessage ="The name field is required")]
        [StringLength(50,ErrorMessage ="The name cannot contain more than 50 characters")]
        public string Name { get; set; }
        [StringLength(100,ErrorMessage ="The desciption cannont be longer than 100 characters")]
        public string  Description { get; set; }
        [Required(ErrorMessage ="You must select an image to upload")]
        public string Image { get; set; }
    }

    [MetadataType(typeof(PictureMetaData))]
    public partial class Picture
    {

    }

    public partial class FamilyMetaData
    {
        [Required(ErrorMessage ="You must enter a family name")]
        [StringLength(50,ErrorMessage ="The name cannont contain more than 50 characters")]
        public string FamilyName { get; set; }
    }

    [MetadataType(typeof(FamilyMetaData))]
    public partial class Family
    {

    }

    public partial class SchoolMetaData
    {
        [Required(ErrorMessage = "You must enter a School name")]
        [StringLength(50, ErrorMessage = "The name cannont contain more than 50 characters")]
        public string SchoolName { get; set; }
    }

    [MetadataType(typeof(SchoolMetaData))]
    public partial class School
    {

    }

    public partial class SportMetaData
    {
        [Required(ErrorMessage = "You must enter a Sport name")]
        [StringLength(50, ErrorMessage = "The name cannont contain more than 50 characters")]
        public string  SportName { get; set; }
    }

    [MetadataType(typeof(SportMetaData))]
    public partial class Sport
    {

    }

}
