package com.example.currentcyconvertyappsamtrenter;

public class CurrencyConversion {
    //constants
    static double UKP = 0.76;
    static double USD = 1.13;

    //private
    private double enterAmount;
    private double conversionRate;
    private double convertedAmount;

    public CurrencyConversion(){
        enterAmount = 0.0;
        conversionRate = 0.0;
        convertedAmount = 0.0;
    }
    //setter
    public void setEnterAmount(double enterAmount) {
        this.enterAmount = enterAmount;
    }

    public void setConversionRate(double conversionRate) {
        this.conversionRate = conversionRate;
    }
    //getter

    public double getConvertedAmount() {
        return convertedAmount;
    }
}
