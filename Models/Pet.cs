using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    public enum PetBreedType {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }

    public enum PetColorType {
        Black,
        White,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet {
        public int id {get; set;}
        public string name {get; set;}
        public PetBreedType petBreedType {get; set;}
        public PetColorType petColorType {get; set;}
        public bool checkedIn {get; set;}
        public int petOwner {get; set;}
    }
}
