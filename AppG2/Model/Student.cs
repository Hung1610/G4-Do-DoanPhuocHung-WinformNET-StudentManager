using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG2.Model
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public long Id { get; set; }
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public GENDER Gender { get; set; }
        public string PlaceOfBirth { get; set; }
        public MAJOR Major { get; set; }
        public decimal? scoreVHCD { get; set; }
        public decimal? scoreVHHD { get; set; }
        public decimal? scoreCoHoc { get; set; }
        public decimal? scoreQuangHoc { get; set; }
        public decimal? scoreDien { get; set; }
        public decimal? scoreHatNhan { get; set; }
        public decimal? scoreSQL { get; set; }
        public decimal? scoreCSharp { get; set; }
        public decimal? scorePascal { get; set; }
    }
    public enum MAJOR
    {
        Van, VatLy, CNTT
    }
    public enum GENDER
    {
        Male, Female, Other
    }
}
