package com.example.petadoptionappsamtrenter;

public class Pet {

// Declare constants for all six combinations of pets and fee types
    static int Dog_Adoption_Fee = 30;
    static int Dog_Microchip_Fee = 50;
    static int Dog_SpayingNeutering_Fee= 20;
    static int Cat_Adoption_Fee= 25;
    static int Cat_Microchip_Fee= 45;
    static int Cat_SpayingNeutering_Fee= 15;



// Declare private fields for the adoption fee, microchip fee, spaying and neutering fee, and total fees
    private int AdoptionFee;
    private int MicrochipFee;
    private int SpayNeutFee;
    private int TotalFee;


// Add a constructor method to initialize all field (member variable) values to 0
    public Pet(){
        AdoptionFee=0;
        MicrochipFee=0;
        SpayNeutFee=0;
        TotalFee=0;
    }


// Add three setter methods to set each fee type

    public void setAdoptionFee(int adoptionFee) {
        AdoptionFee = adoptionFee;
    }

    public void setMicrochipFee(int microchipFee) {
        MicrochipFee = microchipFee;
    }

    public void setSpayNeutFee(int spayNeutFee) {
        SpayNeutFee = spayNeutFee;
    }


// Add one getter method to return the total fees

    public int getTotalFee() {
        return TotalFee;
    }
}
