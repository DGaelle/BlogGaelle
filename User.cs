//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogGaelle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int IdUser { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Merci d'entrer une adresse mail valide..")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Merci d'entrer un numéro de téléphone valide..")]
        public string Telephone { get; set; }

        public string Message { get; set; }
    }
}
